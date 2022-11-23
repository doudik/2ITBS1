namespace Zoo_2ITBS1
{
    public partial class Form1 : Form
    {
        Zoo ustecka = new Zoo("ustecka", 12313.2f, 99.9f, 2000, true);
        public Form1()
        {
            InitializeComponent();
            
            VypisZviratka(ustecka);
            NaplnData();
        }
        void NaplnData() {
            NaplnComboBox();
        }
        void NaplnComboBox() {
            foreach(Chovatel chov in ustecka.dostupniChovatele){
                comboBox_osetrovatel.Items.Add(chov.jmeno);
                foreach (Vybeh vybeh in chov.listVybehuOkteresestara) {
                    comboBox_vybeh.Items.Add(vybeh.pojmenovani);
                }
            }
        }
        void VypisZviratka(Zoo zoo)
        {
            foreach (Zviratko z in zoo.dostupnaZviratkaVZoo)
            {
                label_checkPotravina_text.Text += z.jmeno + ", ";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_nakrmZviratko_Click(object sender, EventArgs e)
        {

        }
    }
}