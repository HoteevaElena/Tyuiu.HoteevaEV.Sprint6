using Tyuiu.HoteevaEV.Sprint6.Task3.V10.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task3.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                         {-19, 3, 12, -11, 19 },
                                         {-20, 11, 9, 19, -19 },
                                         {-20, 10, -9, 17, 9 },
                                         {-4, 9, -8, 13, -8 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_HEV_Click(object sender, EventArgs e)
        {
            string s = "";
            int[,] res = ds.Calculate(mtrx);
            int i = 4;
            for (int j = 0; j < res.GetLength(0); j++)
            {
                s += Convert.ToString(res[i, j]) + "  ";
            }

            textBoxResult_HEV.Text = s;

        }

        private void buttonInfo_HEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task3 выполнил студент группы »»ѕб-24-2 ’отеева ≈лена ¬€чеславовна", "—ообщение");
        }

        private void textBoxResult_HEV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
