namespace ExerciceSomatif2
{
    partial class FormAffichageForme
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnChangerForme = new System.Windows.Forms.Button();
            this.formeControle1 = new ExerciceSomatif2.Controles.FormeControle();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnChangerForme
            // 
            this.btnChangerForme.Location = new System.Drawing.Point(12, 230);
            this.btnChangerForme.Name = "btnChangerForme";
            this.btnChangerForme.Size = new System.Drawing.Size(216, 55);
            this.btnChangerForme.TabIndex = 0;
            this.btnChangerForme.Text = "Changer de forme";
            this.btnChangerForme.UseVisualStyleBackColor = true;
            this.btnChangerForme.Click += new System.EventHandler(this.button1_Click);
            // 
            // formeControle1
            // 
            this.formeControle1.Forme = null;
            this.formeControle1.Location = new System.Drawing.Point(12, 12);
            this.formeControle1.Name = "formeControle1";
            this.formeControle1.Size = new System.Drawing.Size(216, 212);
            this.formeControle1.TabIndex = 1;
            // 
            // FormAffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 296);
            this.Controls.Add(this.formeControle1);
            this.Controls.Add(this.btnChangerForme);
            this.Name = "FormAffichageForme";
            this.Text = "Forme";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button btnChangerForme;
        private Controles.FormeControle formeControle1;
    }
}