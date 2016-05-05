namespace AssessmentSubmissions
{
    partial class EditStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.TextBox();
            this.infoGit = new System.Windows.Forms.TextBox();
            this.infoWebsite = new System.Windows.Forms.TextBox();
            this.confirmRequest = new System.Windows.Forms.Button();
            this.cancelRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "GitHub: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Website: ";
            // 
            // infoName
            // 
            this.infoName.Location = new System.Drawing.Point(96, 10);
            this.infoName.Name = "infoName";
            this.infoName.ReadOnly = true;
            this.infoName.Size = new System.Drawing.Size(176, 20);
            this.infoName.TabIndex = 3;
            // 
            // infoGit
            // 
            this.infoGit.Location = new System.Drawing.Point(96, 37);
            this.infoGit.Name = "infoGit";
            this.infoGit.Size = new System.Drawing.Size(176, 20);
            this.infoGit.TabIndex = 4;
            // 
            // infoWebsite
            // 
            this.infoWebsite.Location = new System.Drawing.Point(96, 67);
            this.infoWebsite.Name = "infoWebsite";
            this.infoWebsite.Size = new System.Drawing.Size(176, 20);
            this.infoWebsite.TabIndex = 5;
            // 
            // confirmRequest
            // 
            this.confirmRequest.Location = new System.Drawing.Point(48, 93);
            this.confirmRequest.Name = "confirmRequest";
            this.confirmRequest.Size = new System.Drawing.Size(75, 23);
            this.confirmRequest.TabIndex = 6;
            this.confirmRequest.Text = "Confirm";
            this.confirmRequest.UseVisualStyleBackColor = true;
            this.confirmRequest.Click += new System.EventHandler(this.confirmRequest_Click);
            // 
            // cancelRequest
            // 
            this.cancelRequest.Location = new System.Drawing.Point(169, 93);
            this.cancelRequest.Name = "cancelRequest";
            this.cancelRequest.Size = new System.Drawing.Size(75, 23);
            this.cancelRequest.TabIndex = 7;
            this.cancelRequest.Text = "Cancel";
            this.cancelRequest.UseVisualStyleBackColor = true;
            this.cancelRequest.Click += new System.EventHandler(this.cancelRequest_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.cancelRequest);
            this.Controls.Add(this.confirmRequest);
            this.Controls.Add(this.infoWebsite);
            this.Controls.Add(this.infoGit);
            this.Controls.Add(this.infoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox infoName;
        private System.Windows.Forms.TextBox infoGit;
        private System.Windows.Forms.TextBox infoWebsite;
        private System.Windows.Forms.Button confirmRequest;
        private System.Windows.Forms.Button cancelRequest;
    }
}