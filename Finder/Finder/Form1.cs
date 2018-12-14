using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finder
{
    public partial class Form1 : Form
    {
        public DataTable Source { get; set; }
        private System.Threading.CancellationTokenSource TokenSource;
        private bool IsSearching;

        public Form1()
        {
            InitializeComponent();

            Source = new DataTable();
            Source.Columns.Add("File", typeof(string));

            grdResult.DataSource = Source;
            grdResult.ReadOnly = true;
            grdResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            txtMaxDegreeOfParallelism.Text = Environment.ProcessorCount.ToString();

            SetupCancelSource();
        }

        void SetupCancelSource()
        {
            TokenSource = new System.Threading.CancellationTokenSource();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (IsSearching)
            {
                if (MessageBox.Show("Dursun mu?", "Search", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                TokenSource.Cancel();
                return;
            }

            if (string.IsNullOrEmpty(txtPath.Text) ||
                string.IsNullOrEmpty(txtSearchPattern.Text) ||
                string.IsNullOrEmpty(txtContent.Text) ||
                string.IsNullOrEmpty(txtMaxDegreeOfParallelism.Text))
            {
                return;
            }

            Source.Clear();
            txtLog.Clear();

            Cursor = Cursors.WaitCursor;
            btnFind.Text = "Cancel";

            var options = new ParallelOptions() { MaxDegreeOfParallelism = Convert.ToInt32(txtMaxDegreeOfParallelism.Text), CancellationToken = TokenSource.Token };

            var task = Task.Factory.StartNew(() =>
            {
                var files = System.IO.Directory.GetFiles(txtPath.Text, txtSearchPattern.Text, System.IO.SearchOption.AllDirectories);

                Parallel.ForEach(files, options, (file) =>
                         {
                             try
                             {
                                 options.CancellationToken.ThrowIfCancellationRequested();

                                 var content = System.IO.File.ReadAllText(file, System.Text.Encoding.UTF8);

                                 if (content.IndexOf(txtContent.Text, StringComparison.InvariantCultureIgnoreCase) >= 0)
                                 {
                                     Source.Rows.Add(file);

                                     grdResult.InvokeIfRequired(() =>
                                     {
                                         grdResult.Refresh();
                                     });
                                 }
                             }
                             catch (Exception ex)
                             {
                                 txtLog.InvokeIfRequired(() =>
                                 {
                                     txtLog.Text += ex.Message + Environment.NewLine;
                                 });
                             }
                         });
            });

            IsSearching = true;

            while (task.Status != TaskStatus.RanToCompletion && task.Status != TaskStatus.Faulted)
            {
                Application.DoEvents();
            }

            Cursor = Cursors.Default;
            IsSearching = false;
            btnFind.Text = "Find";
            SetupCancelSource();

            if (!(task.Exception is null))
            {
                MessageBox.Show(task.Exception.GetBaseException().Message);
            }
            else
            {
                MessageBox.Show("Done!");
            }
        }

        private void grdResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var file = grdResult.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string;

            try
            {
                System.Diagnostics.Process.Start(file);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

    static class MyExt
    {
        public static void InvokeIfRequired(this ISynchronizeInvoke obj, MethodInvoker action)
        {
            if (obj.InvokeRequired)
            {
                var args = new object[0];
                obj.Invoke(action, args);
            }
            else
            {
                action();
            }
        }
    }

}
