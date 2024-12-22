using Tyuiu.HoteevaEV.Sprint6.Task5.V9.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V9.txt";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "ќсь X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "ќсь Y";

            chartDiag.Series[0].Points.Clear();

            double[] nummass = new double[ds.len];

            nummass = ds.LoadFromDataFile(path);

            for (int i = 0; i < nummass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(nummass[i]));
                chartDiag.Series[0].Points.AddXY(i, nummass[i]);
            }
        }

        private void dataGridViewNums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task5 выполнил студент группы »»ѕб-24-2 ’отеева ≈лена ¬€чеславовна", "—ообщение");
        }
    }
}
