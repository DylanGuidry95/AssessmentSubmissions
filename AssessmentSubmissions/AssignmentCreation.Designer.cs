namespace AssessmentSubmissions
{
    partial class AssignmentCreation
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
            this.assignmentList = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newItem = new System.Windows.Forms.RadioButton();
            this.editItem = new System.Windows.Forms.RadioButton();
            this.saveItem = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentList
            // 
            this.assignmentList.FormattingEnabled = true;
            this.assignmentList.Location = new System.Drawing.Point(13, 13);
            this.assignmentList.Name = "assignmentList";
            this.assignmentList.Size = new System.Drawing.Size(120, 459);
            this.assignmentList.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(139, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 23);
            this.name.TabIndex = 1;
            this.name.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assignment";
            // 
            // newItem
            // 
            this.newItem.AutoSize = true;
            this.newItem.Location = new System.Drawing.Point(304, 29);
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(104, 17);
            this.newItem.TabIndex = 4;
            this.newItem.TabStop = true;
            this.newItem.Text = "New Assignment";
            this.newItem.UseVisualStyleBackColor = true;
            // 
            // editItem
            // 
            this.editItem.AutoSize = true;
            this.editItem.Location = new System.Drawing.Point(415, 29);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(100, 17);
            this.editItem.TabIndex = 5;
            this.editItem.TabStop = true;
            this.editItem.Text = "Edit Assignment";
            this.editItem.UseVisualStyleBackColor = true;
            // 
            // saveItem
            // 
            this.saveItem.Location = new System.Drawing.Point(139, 448);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(75, 23);
            this.saveItem.TabIndex = 6;
            this.saveItem.Text = "Save";
            this.saveItem.UseVisualStyleBackColor = true;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // discard
            // 
            this.discard.Location = new System.Drawing.Point(221, 449);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(75, 23);
            this.discard.TabIndex = 7;
            this.discard.Text = "Discard";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataSource = typeof(AssessmentSubmissions.Assignment);
            this.assignmentBindingSource.CurrentChanged += new System.EventHandler(this.assignmentBindingSource_CurrentChanged);
            // 
            // AssignmentCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 493);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.saveItem);
            this.Controls.Add(this.editItem);
            this.Controls.Add(this.newItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.assignmentList);
            this.Name = "AssignmentCreation";
            this.Text = "AssignmentCreation";
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox assignmentList;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private System.Windows.Forms.RadioButton newItem;
        private System.Windows.Forms.RadioButton editItem;
        private System.Windows.Forms.Button saveItem;
        private System.Windows.Forms.Button discard;
    }
}