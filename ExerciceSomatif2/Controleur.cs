using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = ExerciceSomatif2.Models.Rectangle;

namespace ExerciceSomatif2
{
    internal class Controleur
    {
        private List<Forme> listedeForme = new List<Forme>();
        private int index;
        private Forme formeCourant;

        public event EventHandler<Forme> ChangerFormeCourantEvent;
        public Controleur()
        {
            Rectangle rectangle = new Rectangle(Color.Green);
            RectanglePlein rectanglePlein = new RectanglePlein(Color.Green);
            Cercle cercle = new Cercle(Color.Orange);
            CerclePlein cerclePlein = new CerclePlein(Color.Orange);
            listedeForme.Add(rectangle);
            listedeForme.Add(rectanglePlein);
            listedeForme.Add(cercle);
            listedeForme.Add(cerclePlein);
            index = 0;
        }

        public void PasserALaProchaineForme()
        {
            formeCourant = listedeForme[index];
            index = (index + 1) % listedeForme.Count;
            formeCourant.DessinerCustom();
            ChangerFormeCourantEvent?.Invoke(this, formeCourant);
        }
    }
}
