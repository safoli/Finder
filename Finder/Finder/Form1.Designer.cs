namespace Finder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.txtSearchPattern = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMaxDegreeOfParallelism = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(9, 10);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(788, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\Nebim\\Projects\\V3ERP\\Main";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(800, 32);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 19);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grdResult
            // 
            this.grdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(9, 56);
            this.grdResult.Margin = new System.Windows.Forms.Padding(2);
            this.grdResult.Name = "grdResult";
            this.grdResult.RowTemplate.Height = 24;
            this.grdResult.Size = new System.Drawing.Size(848, 424);
            this.grdResult.TabIndex = 2;
            this.grdResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResult_CellContentDoubleClick);
            // 
            // txtSearchPattern
            // 
            this.txtSearchPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPattern.Location = new System.Drawing.Point(800, 10);
            this.txtSearchPattern.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPattern.Name = "txtSearchPattern";
            this.txtSearchPattern.Size = new System.Drawing.Size(57, 20);
            this.txtSearchPattern.TabIndex = 3;
            this.txtSearchPattern.Text = "*.vbproj";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(54, 32);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(545, 20);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "log4net";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Content";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(9, 484);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(848, 140);
            this.txtLog.TabIndex = 6;
            // 
            // txtMaxDegreeOfParallelism
            // 
            this.txtMaxDegreeOfParallelism.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxDegreeOfParallelism.Location = new System.Drawing.Point(732, 32);
            this.txtMaxDegreeOfParallelism.Name = "txtMaxDegreeOfParallelism";
            this.txtMaxDegreeOfParallelism.Size = new System.Drawing.Size(65, 20);
            this.txtMaxDegreeOfParallelism.TabIndex = 7;
            this.txtMaxDegreeOfParallelism.Text = "10";
            this.txtMaxDegreeOfParallelism.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MaxDegreeOfParallelism";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxDegreeOfParallelism);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSearchPattern);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Search Content";
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.TextBox txtSearchPattern;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMaxDegreeOfParallelism;
        private System.Windows.Forms.Label label2;
    }
}

