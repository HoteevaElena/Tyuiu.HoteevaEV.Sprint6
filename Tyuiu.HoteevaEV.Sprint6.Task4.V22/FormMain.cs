using Tyuiu.HoteevaEV.Sprint6.Task4.V22.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task4.V22
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

        private void groupBoxOutPut_HEV_Enter(object sender, EventArgs e)
        {

        }

        private void chartFunc_HEV_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_HEV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_HEV.Text);
                int end = Convert.ToInt32(textBoxEnd_HEV.Text);
                int len = end - start + 1;
                double[] arr = new double[len];
                arr = ds.GetMassFunction(start, end);

                this.chartFunc_HEV.Titles.Add("������ �������� �������");

                this.chartFunc_HEV.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunc_HEV.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxOutPut_HEV.Text = "";

                chartFunc_HEV.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunc_HEV.Series[0].Points.AddXY(start, arr[i]);
                    textBoxOutPut_HEV.AppendText(arr[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_HEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 �������� ������� ������ ����-24-2 ������� ����� ������������", "���������");
        }

        private void buttonSave_HEV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V22.txt");
                File.WriteAllText(path, textBoxOutPut_HEV.Text);
                DialogResult dialogres = MessageBox.Show("���� " + path + " �������� �������! \n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dialogres == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.txt";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
