using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public abstract class Forme
    {
        private Color couleur;

        protected Forme(Color couleur)
        {
            this.couleur = couleur;
        }

        public event EventHandler<Bitmap> ChangerFormeCourantEvent;

        public void Dessiner()
        {
            DessinerCustom();
        }

        protected abstract void DessinerCustom(Graphics graphics);

        public Bitmap DessinerCustom()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                DessinerCustom(graphics);
            }
            ChangerFormeCourantEvent?.Invoke(this, bitmap);
            return bitmap;
        }

        public abstract string ObtenirType();
    }
}
