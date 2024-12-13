using Tyuiu.HoteevaEV.Sprint6.Task1.V12.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUslovie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task1 выполнил студент группы »»ѕб-24-2 ’отеева ≈лена ¬€чеславовна", "—ообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                string sLine;
                int len = end - start + 1;
                double[] valAr = new double[len];

                valAr = ds.GetMassFunction(start, end);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|       x       |      f(x)     |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    sLine = String.Format("|{0, 10:d}      | {1, 10:f2}        | ", start, valAr[i]);
                    textBoxResult.AppendText(sLine + Environment.NewLine);
                    start++;
                }
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxEndText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
