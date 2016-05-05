namespace AssessmentSubmissions
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.Button();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(98, 37);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(100, 20);
            this.studentName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Student";
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(12, 74);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(75, 23);
            this.addStudent.TabIndex = 7;
            this.addStudent.Text = "Add";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // cancelAdd
            // 
            this.cancelAdd.Location = new System.Drawing.Point(125, 74);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(75, 23);
            this.cancelAdd.TabIndex = 8;
            this.cancelAdd.Text = "Cancel";
            this.cancelAdd.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 106);
            this.Controls.Add(this.cancelAdd);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button cancelAdd;
    }
}