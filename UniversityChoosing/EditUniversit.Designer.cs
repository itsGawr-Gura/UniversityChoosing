namespace UniversityChoosing
{
    partial class EditUniversit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.university = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Университет";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(168, 84);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(401, 31);
            this.city.TabIndex = 7;
            // 
            // university
            // 
            this.university.Location = new System.Drawing.Point(168, 25);
            this.university.Name = "university";
            this.university.Size = new System.Drawing.Size(401, 31);
            this.university.TabIndex = 6;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(22, 150);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(162, 44);
            this.edit.TabIndex = 5;
            this.edit.Text = "Добавить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // EditUniversit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.university);
            this.Controls.Add(this.edit);
            this.Name = "EditUniversit";
            this.Text = "EditUniversit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox university;
        private System.Windows.Forms.Button edit;
    }
}