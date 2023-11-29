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
            int numPalabras;
            double coste = 0;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            //Obtengo el número de palabras que forma el telegrama 
            numPalabras = textoTelegrama.Split(' ' , '.' , ',' , ':' , ';').Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == ' ')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
            ?        coste = 2.5 + 0.5 * (numPalabras - 10);

            txtPrecio.Text=coste.ToString() + "euros";

            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            txtPrecio.Text = coste.ToString() + " euros";
        }//ya esta el codigo modificado RCM2324otHer

    }
}
