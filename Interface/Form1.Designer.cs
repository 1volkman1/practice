namespace Interface
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
            this.tolkAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tolkAbout
            // 
            this.tolkAbout.Location = new System.Drawing.Point(58, 101);
            this.tolkAbout.Name = "tolkAbout";
            this.tolkAbout.Size = new System.Drawing.Size(169, 45);
            this.tolkAbout.TabIndex = 0;
            this.tolkAbout.Text = "Click me!and i`m say about you";
            this.tolkAbout.UseVisualStyleBackColor = true;
            this.tolkAbout.Click += new System.EventHandler(this.tolkAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tolkAbout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tolkAbout;
    }
}

