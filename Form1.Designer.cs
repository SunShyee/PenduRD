namespace PenduRD
{
    partial class frmPendu
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
            flpalphabet = new FlowLayoutPanel();
            picPendu = new PictureBox();
            lblnberreur = new Label();
            lblMot = new Label();
            ((System.ComponentModel.ISupportInitialize)picPendu).BeginInit();
            SuspendLayout();
            // 
            // flpalphabet
            // 
            flpalphabet.Anchor = AnchorStyles.None;
            flpalphabet.Location = new Point(106, 319);
            flpalphabet.Margin = new Padding(3, 2, 3, 2);
            flpalphabet.Name = "flpalphabet";
            flpalphabet.Size = new Size(740, 120);
            flpalphabet.TabIndex = 0;
            // 
            // picPendu
            // 
            picPendu.Anchor = AnchorStyles.None;
            picPendu.Location = new Point(372, 39);
            picPendu.Margin = new Padding(3, 2, 3, 2);
            picPendu.Name = "picPendu";
            picPendu.Size = new Size(277, 226);
            picPendu.TabIndex = 1;
            picPendu.TabStop = false;
            // 
            // lblnberreur
            // 
            lblnberreur.Anchor = AnchorStyles.None;
            lblnberreur.AutoSize = true;
            lblnberreur.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblnberreur.Location = new Point(150, 222);
            lblnberreur.Name = "lblnberreur";
            lblnberreur.Size = new Size(182, 28);
            lblnberreur.TabIndex = 2;
            lblnberreur.Text = "Nombre d'erreur :";
            // 
            // lblMot
            // 
            lblMot.Anchor = AnchorStyles.None;
            lblMot.AutoSize = true;
            lblMot.Font = new Font("Segoe UI", 12F);
            lblMot.Location = new Point(444, 279);
            lblMot.Name = "lblMot";
            lblMot.Size = new Size(0, 21);
            lblMot.TabIndex = 3;
            // 
            // frmPendu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 543);
            Controls.Add(lblMot);
            Controls.Add(lblnberreur);
            Controls.Add(picPendu);
            Controls.Add(flpalphabet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPendu";
            Text = "Pendu";
            Load += frmPendu_Load;
            ((System.ComponentModel.ISupportInitialize)picPendu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpalphabet;
        private PictureBox picPendu;
        private Label lblnberreur;
        private Label lblMot;
    }
}
