namespace UniversityChoosing
{
    partial class AddUniversity
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
            this.add = new System.Windows.Forms.Button();
            this.university = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(4, 183);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(162, 44);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // university
            // 
            this.university.Location = new System.Drawing.Point(150, 58);
            this.university.Name = "university";
            this.university.Size = new System.Drawing.Size(401, 31);
            this.university.TabIndex = 1;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(150, 117);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(401, 31);
            this.city.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Университет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город";
            // 
            // AddUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(574, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.university);
            this.Controls.Add(this.add);
            this.Name = "AddUniversity";
            this.Text = "AddUniversity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox university;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}