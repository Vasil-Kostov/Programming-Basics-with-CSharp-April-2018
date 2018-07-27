namespace WindowsFormsApp1
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
            this.CatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchMe
            // 
            this.CatchMe.Location = new System.Drawing.Point(137, 152);
            this.CatchMe.Name = "CatchMe";
            this.CatchMe.Size = new System.Drawing.Size(75, 23);
            this.CatchMe.TabIndex = 0;
            this.CatchMe.Text = "Catch Me";
            this.CatchMe.UseVisualStyleBackColor = true;
            this.CatchMe.Click += new System.EventHandler(this.CatchMe_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CatchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button CatchMe;
    }
}

