namespace calcularIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dt_data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNasc = dateTimePicker1.Value;
            int idade = dataAtual.Year - dataNasc.Year;

            if (dataNasc.AddYears(idade) > dataAtual)
            {
                idade--;
            }                 
            lb_resultado.Text = $"A sua Idade é: {idade}";

        }

    

        private void lb_resultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}