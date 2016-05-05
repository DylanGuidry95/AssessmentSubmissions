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
            this.assignmentLog = new System.Windows.Forms.DataGridView();
            this.Assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfo = new System.Windows.Forms.RichTextBox();
            this.Control = new System.Windows.Forms.GroupBox();
            this.Help = new System.Windows.Forms.Button();
            this.AssignmentEditor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentLog)).BeginInit();
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
            // assignmentLog
            // 
            this.assignmentLog.AutoGenerateColumns = false;
            this.assignmentLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assignment,
            this.Grade,
            this.Download});
            this.assignmentLog.DataSource = this.studentBindingSource;
            this.assignmentLog.Location = new System.Drawing.Point(139, 74);
            this.assignmentLog.Name = "assignmentLog";
            this.assignmentLog.Size = new System.Drawing.Size(599, 311);
            this.assignmentLog.TabIndex = 1;
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
            this.Control.Controls.Add(this.AssignmentEditor);
            this.Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.Location = new System.Drawing.Point(13, 392);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(139, 85);
            this.Control.TabIndex = 3;
            this.Control.TabStop = false;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(7, 51);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(126, 23);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // AssignmentEditor
            // 
            this.AssignmentEditor.Location = new System.Drawing.Point(7, 21);
            this.AssignmentEditor.Name = "AssignmentEditor";
            this.AssignmentEditor.Size = new System.Drawing.Size(126, 23);
            this.AssignmentEditor.TabIndex = 0;
            this.AssignmentEditor.Text = "Assignment Editor";
            this.AssignmentEditor.UseVisualStyleBackColor = true;
            this.AssignmentEditor.Click += new System.EventHandler(this.AssignmentEditor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(393, 12);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(75, 23);
            this.editStudent.TabIndex = 6;
            this.editStudent.Text = "Edit Info";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // Mock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.studentInfo);
            this.Controls.Add(this.assignmentLog);
            this.Controls.Add(this.StudentNames);
            this.Name = "Mock";
            this.Text = "Mock";
            ((System.ComponentModel.ISupportInitialize)(this.assignmentLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentNames;
        private System.Windows.Forms.DataGridView assignmentLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment;
        private System.Windows.Forms.DataGridViewComboBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Download;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.RichTextBox studentInfo;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button AssignmentEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editStudent;
    }
}