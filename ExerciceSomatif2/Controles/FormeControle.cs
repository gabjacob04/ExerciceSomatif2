using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class FormeControle : UserControl
    {
        private Models.Forme forme;

        public Models.Forme Forme{
            get => forme;
            set
            {
                {
                    if (value is null)
                    {
                        lblAffichage.Text = "";
                    }
                    else
                    {
                        if (forme is not null)
                        {
                            forme.ChangerFormeCourantEvent -= Forme_ChangerFormeCourantEvent;                                  
                        }
                    }
                    forme = value;
                    if (forme is not null)
                    {
                        InitAffichage();
                        forme.ChangerFormeCourantEvent += Forme_ChangerFormeCourantEvent;
                    }
                }
            }
        }

        private void Forme_ChangerFormeCourantEvent(object? sender, Bitmap e)
        {
            picForme.Image = e;
        }

        public FormeControle()
        {
            InitializeComponent();
        }

        private void InitAffichage()
        {
            lblAffichage.Text = forme.ObtenirType();
            picForme.Image = forme.DessinerCustom();
        }

        private void FormeControle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
