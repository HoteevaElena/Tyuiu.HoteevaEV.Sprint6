using Tyuiu.HoteevaEV.Sprint6.Task2.V29.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void textBoxUslovie_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                int len = end - start + 1;

                double[] valarr = new double[len];
                valarr = ds.GetMassFunction(start, end);

                this.chartFunction.Titles.Add("√рафик заданной функции");

                this.chartFunction.ChartAreas[0].AxisX.Title = "ќсь X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "ќсь Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(start), Convert.ToString(valarr[i]));
                    this.chartFunction.Series[0].Points.AddXY(start, valarr[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы »»ѕб-24-2 ’отеева ≈лена ¬€чеславовна", "—ообщение");
        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartGraph_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }
        private void buttonDone_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonEnter_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }
    }
}
