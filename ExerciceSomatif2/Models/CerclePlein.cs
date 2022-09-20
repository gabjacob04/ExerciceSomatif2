using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class CerclePlein : Forme
    {
        private Color couleur;
        public CerclePlein(Color couleur) : base(couleur)
        {
            couleur = Color.Orange;
            this.couleur = couleur;
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.couleur);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(1, 1, 99, 99);
            graphics.FillEllipse(brush, rect);
        }

        public override string ObtenirType()
        {
            return "Cercle Plein";
        }
    }
}
