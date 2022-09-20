using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExerciceSomatif2.Models
{
    internal class Cercle : Forme
    {
        private Color couleur;
        public Cercle(Color couleur) : base(couleur)
        {
            couleur = Color.Orange;
            this.couleur = couleur;
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Pen pen = new Pen(this.couleur, 4);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(1, 1, 96, 96);
            graphics.DrawEllipse(pen, rect);
        }

        public override string ObtenirType()
        {
            return "Cercle";
        }
    }
}
