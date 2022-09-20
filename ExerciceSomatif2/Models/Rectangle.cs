using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExerciceSomatif2.Models
{
    internal class Rectangle : Forme
    {
        private Color couleur;
        public Rectangle(Color couleur) : base(couleur)
        {
            couleur = Color.Green;
            this.couleur = couleur;
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Pen pen = new Pen(this.couleur, 4);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(1, 1, 96, 46);
            graphics.DrawRectangle(pen, rect);
        }

        public override string ObtenirType()
        {
            return "Rectangle";
        }
    }
}
