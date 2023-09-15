namespace module10_patron_de_conception2
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbArticles = new System.Windows.Forms.Label();
            this.dgvLigne = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.gbSimulateur = new System.Windows.Forms.GroupBox();
            this.btnSimuler = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbQuantite = new System.Windows.Forms.Label();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.lbPrix = new System.Windows.Forms.Label();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnPayer = new System.Windows.Forms.Button();
            this.dgvcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigne)).BeginInit();
            this.gbSimulateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // lbArticles
            // 
            this.lbArticles.AutoSize = true;
            this.lbArticles.Location = new System.Drawing.Point(26, 30);
            this.lbArticles.Name = "lbArticles";
            this.lbArticles.Size = new System.Drawing.Size(65, 20);
            this.lbArticles.TabIndex = 0;
            this.lbArticles.Text = "Articles :";
            // 
            // dgvLigne
            // 
            this.dgvLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLigne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDescription,
            this.dgvcQuantite,
            this.dgvcPrix,
            this.dgvcTotal});
            this.dgvLigne.Location = new System.Drawing.Point(28, 60);
            this.dgvLigne.Name = "dgvLigne";
            this.dgvLigne.RowHeadersWidth = 51;
            this.dgvLigne.RowTemplate.Height = 29;
            this.dgvLigne.Size = new System.Drawing.Size(733, 291);
            this.dgvLigne.TabIndex = 1;
            this.dgvLigne.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(510, 372);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(42, 20);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Location = new System.Drawing.Point(577, 369);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(184, 27);
            this.tbTotal.TabIndex = 3;
            this.tbTotal.Text = "0,00 $";
            // 
            // gbSimulateur
            // 
            this.gbSimulateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSimulateur.Controls.Add(this.btnSimuler);
            this.gbSimulateur.Controls.Add(this.tbDescription);
            this.gbSimulateur.Controls.Add(this.lbQuantite);
            this.gbSimulateur.Controls.Add(this.nudQuantite);
            this.gbSimulateur.Controls.Add(this.lbPrix);
            this.gbSimulateur.Controls.Add(this.nudPrix);
            this.gbSimulateur.Controls.Add(this.lbDescription);
            this.gbSimulateur.Location = new System.Drawing.Point(28, 453);
            this.gbSimulateur.Name = "gbSimulateur";
            this.gbSimulateur.Size = new System.Drawing.Size(733, 127);
            this.gbSimulateur.TabIndex = 5;
            this.gbSimulateur.TabStop = false;
            this.gbSimulateur.Text = "Simulateur scanner";
            // 
            // btnSimuler
            // 
            this.btnSimuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimuler.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSimuler.Location = new System.Drawing.Point(604, 74);
            this.btnSimuler.Name = "btnSimuler";
            this.btnSimuler.Size = new System.Drawing.Size(117, 41);
            this.btnSimuler.TabIndex = 6;
            this.btnSimuler.Text = "Simuler";
            this.btnSimuler.UseVisualStyleBackColor = false;
            this.btnSimuler.Click += new System.EventHandler(this.bSimuler_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(102, 40);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(298, 27);
            this.tbDescription.TabIndex = 5;
            // 
            // lbQuantite
            // 
            this.lbQuantite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantite.AutoSize = true;
            this.lbQuantite.Location = new System.Drawing.Point(406, 40);
            this.lbQuantite.Name = "lbQuantite";
            this.lbQuantite.Size = new System.Drawing.Size(66, 20);
            this.lbQuantite.TabIndex = 4;
            this.lbQuantite.Text = "Quantite";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantite.Location = new System.Drawing.Point(476, 38);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(89, 27);
            this.nudQuantite.TabIndex = 3;
            // 
            // lbPrix
            // 
            this.lbPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrix.AutoSize = true;
            this.lbPrix.Location = new System.Drawing.Point(571, 40);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(33, 20);
            this.lbPrix.TabIndex = 2;
            this.lbPrix.Text = "Prix";
            // 
            // nudPrix
            // 
            this.nudPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrix.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrix.Location = new System.Drawing.Point(610, 38);
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(107, 27);
            this.nudPrix.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(11, 40);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            // 
            // btnPayer
            // 
            this.btnPayer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPayer.Location = new System.Drawing.Point(638, 418);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(123, 29);
            this.btnPayer.TabIndex = 6;
            this.btnPayer.Text = "Payer";
            this.btnPayer.UseVisualStyleBackColor = false;
            this.btnPayer.Click += new System.EventHandler(this.bPayer_Click);
            // 
            // dgvcDescription
            // 
            this.dgvcDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDescription.HeaderText = "Description";
            this.dgvcDescription.MinimumWidth = 6;
            this.dgvcDescription.Name = "dgvcDescription";
            // 
            // dgvcQuantite
            // 
            this.dgvcQuantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcQuantite.HeaderText = "Quantite";
            this.dgvcQuantite.MinimumWidth = 6;
            this.dgvcQuantite.Name = "dgvcQuantite";
            // 
            // dgvcPrix
            // 
            this.dgvcPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcPrix.HeaderText = "Prix Unitaire";
            this.dgvcPrix.MinimumWidth = 6;
            this.dgvcPrix.Name = "dgvcPrix";
            // 
            // dgvcTotal
            // 
            this.dgvcTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcTotal.HeaderText = "Total";
            this.dgvcTotal.MinimumWidth = 6;
            this.dgvcTotal.Name = "dgvcTotal";
            // 
            // fPrincipale
            // 
            this.ClientSize = new System.Drawing.Size(789, 599);
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.gbSimulateur);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgvLigne);
            this.Controls.Add(this.lbArticles);
            this.MinimumSize = new System.Drawing.Size(576, 501);
            this.Name = "fPrincipale";
            this.Text = "Ecran principal";
            this.Load += new System.EventHandler(this.fPrincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigne)).EndInit();
            this.gbSimulateur.ResumeLayout(false);
            this.gbSimulateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbArticles;
        private DataGridView dgvLigne;
        private Label lbTotal;
        private TextBox tbTotal;
        private GroupBox gbSimulateur;
        private TextBox tbDescription;
        private Label lbQuantite;
        private NumericUpDown nudQuantite;
        private Label lbPrix;
        private NumericUpDown nudPrix;
        private Label lbDescription;
        private Button btnSimuler;
        private Button btnPayer;
        private DataGridViewTextBoxColumn dgvcDescription;
        private DataGridViewTextBoxColumn dgvcQuantite;
        private DataGridViewTextBoxColumn dgvcPrix;
        private DataGridViewTextBoxColumn dgvcTotal;
    }
}