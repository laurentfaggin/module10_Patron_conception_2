namespace module10_patron_de_conception2
{
    partial class fClient
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
            this.tbAffichageClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAffichageClient
            // 
            this.tbAffichageClient.Location = new System.Drawing.Point(33, 48);
            this.tbAffichageClient.Name = "tbAffichageClient";
            this.tbAffichageClient.Size = new System.Drawing.Size(848, 27);
            this.tbAffichageClient.TabIndex = 0;
            // 
            // fClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 132);
            this.Controls.Add(this.tbAffichageClient);
            this.Name = "fClient";
            this.Text = "Ecran client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAffichageClient;
    }
}