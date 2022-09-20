namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        Controleur control;

        public FormAffichageForme()
        {
            control = new Controleur();
            InitializeComponent();
            Abonnement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.PasserALaProchaineForme();
        }

        private void Abonnement()
        {
            control.ChangerFormeCourantEvent += Control_ChangerFormeCourantEvent;
        }

        private void Control_ChangerFormeCourantEvent(object? sender, Models.Forme forme)
        {
            formeControle1.Forme = forme;
        }
    }
}