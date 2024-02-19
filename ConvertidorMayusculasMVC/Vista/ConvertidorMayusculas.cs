namespace ConvertidorMayusculasMVC
{
    public partial class ConvertidorMayusculas : Form
    {

        private Controlador controlador;
        public ConvertidorMayusculas()
        {
            InitializeComponent();
            controlador = new Controlador(this);
        }

        public string ObtenerTexto()
        {
            return textBox1.Text;
        }

        public void EstablecerTexto(string texto)
        {
            textBox1.Text = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.ConvertirAMayusculas();
        }
    }
}