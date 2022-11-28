namespace TypeRacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TypeRacer.Start(this);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}