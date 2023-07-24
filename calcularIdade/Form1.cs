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
            DateTime d1 = DateTime.Now;
            DateTime datanasc = dateTimePicker1.Value;
            int retornoComaparaDatas = DateTime.Compare(d1, datanasc );
        }

        private void lb_resultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}