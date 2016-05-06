namespace AssessmentSubmissions
{
    partial class Home
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
            this.classes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateClass = new System.Windows.Forms.Button();
            this.className = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // classes
            // 
            this.classes.FormattingEnabled = true;
            this.classes.Location = new System.Drawing.Point(9, 36);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(154, 21);
            this.classes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Class";
            // 
            // SelectClass
            // 
            this.SelectClass.Location = new System.Drawing.Point(9, 64);
            this.SelectClass.Name = "SelectClass";
            this.SelectClass.Size = new System.Drawing.Size(75, 23);
            this.SelectClass.TabIndex = 2;
            this.SelectClass.Text = "Confirm";
            this.SelectClass.UseVisualStyleBackColor = true;
            this.SelectClass.Click += new System.EventHandler(this.SelectClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectClass);
            this.groupBox1.Controls.Add(this.classes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Classes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreateClass);
            this.groupBox2.Controls.Add(this.className);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(188, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 94);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Class";
            // 
            // CreateClass
            // 
            this.CreateClass.Location = new System.Drawing.Point(10, 62);
            this.CreateClass.Name = "CreateClass";
            this.CreateClass.Size = new System.Drawing.Size(75, 23);
            this.CreateClass.TabIndex = 2;
            this.CreateClass.Text = "Create";
            this.CreateClass.UseVisualStyleBackColor = true;
            this.CreateClass.Click += new System.EventHandler(this.CreateClass_Click);
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(10, 36);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(154, 20);
            this.className.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 123);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox classes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateClass;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label2;
    }
}