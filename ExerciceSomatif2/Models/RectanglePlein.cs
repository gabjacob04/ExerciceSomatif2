using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class RectanglePlein : Forme
    {
        private Color couleur;
        public RectanglePlein(Color couleur) : base(couleur)
        {
            couleur = Color.Green;
            this.couleur = couleur;
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.couleur);
            System.Drawing.Rectangle rectangle = new(1, 1, 99, 49);
            graphics.FillRectangle(brush, rectangle);
        }

        public override string ObtenirType()
        {
            return "Rectangle Plein";
        }
    }
}
