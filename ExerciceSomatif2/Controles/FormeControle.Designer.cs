namespace ExerciceSomatif2.Controles
{
    partial class FormeControle
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picForme = new System.Windows.Forms.PictureBox();
            this.lblAffichage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picForme)).BeginInit();
            this.SuspendLayout();
            // 
            // picForme
            // 
            this.picForme.Location = new System.Drawing.Point(15, 3);
            this.picForme.Name = "picForme";
            this.picForme.Size = new System.Drawing.Size(193, 156);
            this.picForme.TabIndex = 0;
            this.picForme.TabStop = false;
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Location = new System.Drawing.Point(15, 174);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(108, 20);
            this.lblAffichage.TabIndex = 1;
            this.lblAffichage.Text = "Affichage Type";
            // 
            // FormeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.picForme);
            this.Name = "FormeControle";
            this.Size = new System.Drawing.Size(225, 212);
            this.Load += new System.EventHandler(this.FormeControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picForme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picForme;
        private Label lblAffichage;
    }
}
