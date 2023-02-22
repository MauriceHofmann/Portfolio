namespace Schnittstellen__Interfaces_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Kreis kreis1 = new Kreis("Rot", 20);
            Kreis kreis2 = (Kreis)kreis1.Clone();

            kreis1.Faerben("Geld");
            kreis1.Vergroessern(1.5);

            lblAnzeige.Text = "Kreis1: " + kreis1.ToString() + "\nKreis2: " + kreis2.ToString();
        }
    }
}