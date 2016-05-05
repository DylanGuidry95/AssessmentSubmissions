namespace AssessmentSubmissions
{
    partial class Mock
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
            this.components = new System.ComponentModel.Container();
            this.StudentNames = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfo = new System.Windows.Forms.RichTextBox();
            this.Control = new System.Windows.Forms.GroupBox();
            this.Help = new System.Windows.Forms.Button();
            this.AssessmentCreate = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentNames
            // 
            this.StudentNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNames.FormattingEnabled = true;
            this.StudentNames.ItemHeight = 16;
            this.StudentNames.Location = new System.Drawing.Point(13, 13);
            this.StudentNames.Name = "StudentNames";
            this.StudentNames.Size = new System.Drawing.Size(120, 372);
            this.StudentNames.TabIndex = 0;
            this.StudentNames.SelectedIndexChanged += new System.EventHandler(this.StudentNames_SelectedIndexChanged);
            this.StudentNames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudentNames_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assignment,
            this.Grade,
            this.Download,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 311);
            this.dataGridView1.TabIndex = 1;
            // 
            // Assignment
            // 
            this.Assignment.HeaderText = "Assignment";
            this.Assignment.Name = "Assignment";
            this.Assignment.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // Download
            // 
            this.Download.HeaderText = "Download Url";
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(AssessmentSubmissions.Student);
            // 
            // studentInfo
            // 
            this.studentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfo.Location = new System.Drawing.Point(140, 13);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.ReadOnly = true;
            this.studentInfo.Size = new System.Drawing.Size(247, 55);
            this.studentInfo.TabIndex = 2;
            this.studentInfo.Text = "Name:\nGitHub:\nWebsite:";
            // 
            // Control
            // 
            this.Control.Controls.Add(this.Help);
            this.Control.Controls.Add(this.AssessmentCreate);
            this.Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.Location = new System.Drawing.Point(13, 392);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(129, 85);
            this.Control.TabIndex = 3;
            this.Control.TabStop = false;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(7, 51);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(113, 23);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // AssessmentCreate
            // 
            this.AssessmentCreate.Location = new System.Drawing.Point(7, 21);
            this.AssessmentCreate.Name = "AssessmentCreate";
            this.AssessmentCreate.Size = new System.Drawing.Size(113, 23);
            this.AssessmentCreate.TabIndex = 0;
            this.AssessmentCreate.Text = "New Assignment";
            this.AssessmentCreate.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Mock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.studentInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentNames);
            this.Name = "Mock";
            this.Text = "Mock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentNames;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment;
        private System.Windows.Forms.DataGridViewComboBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Download;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.RichTextBox studentInfo;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button AssessmentCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}