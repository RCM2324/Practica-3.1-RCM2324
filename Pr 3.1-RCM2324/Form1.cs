namespace Pr_3._1_RCM2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //? Copio el codigo del ejercicio 2.3 y pruebo si compila 

        private void btn1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            //? Que tipo de telegrama es? RCM2324
            if (radioBtn1.Checked)
                tipoTelegrama = 'o';
            if (radioBtn2.Checked)
                tipoTelegrama = 'u';

            //Obtengo el número de palabras que forma el telegrama 
            numPalabras = textoTelegrama.Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else

            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }

    }
}
