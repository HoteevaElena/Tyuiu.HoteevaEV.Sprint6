using Tyuiu.HoteevaEV.Sprint6.Task0.V23.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task0 выполнил студент группы »»ѕб-24-2 ’отеева ≈лена ¬€чеславовна", "—ообщение");
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValueX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTextRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
