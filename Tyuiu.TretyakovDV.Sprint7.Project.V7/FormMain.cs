using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.TretyakovDV.Sprint7.Project.V7.Lib;

namespace Tyuiu.TretyakovDV.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }
        public void buttonOpenBase_TDV_Click_1(object sender, EventArgs e)
        {
            openFileDialogMain_TDV.ShowDialog();
            openFilePath = openFileDialogMain_TDV.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);


            arrayValues = ds.GetBase(openFilePath);

            buttonViewBase_TDV.Enabled = true;
        }
        public void buttonSave_TDV_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_TDV.FileName = "Home_Base.csv";
            saveFileDialogMain_TDV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_TDV.ShowDialog();

            string path = saveFileDialogMain_TDV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewBase_TDV.RowCount;
            int columns = dataGridViewBase_TDV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_TDV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_TDV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        public void buttonDelete_TDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBase_TDV.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewBase_TDV.CurrentRow.Index;
                    dataGridViewBase_TDV.Rows.Remove(dataGridViewBase_TDV.Rows[a]);
                    if (dataGridViewBase_TDV.Rows.Count == 1)
                    {
                        dataGridViewBase_TDV.Rows.Clear();
                    }
                }
                if (dataGridViewBase_TDV.Rows.Count <= 1)
                {
                    buttonDelete_TDV.Enabled = false;
                    buttonFind_TDV.Enabled = false;
                }
                if (dataGridViewBase_TDV.Rows.Count > 1)
                {
                    buttonDelete_TDV.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void buttonAdd_TDV_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }       
        public void buttonViewBase_TDV_Click(object sender, EventArgs e)
        {
            dataGridViewBase_TDV.ColumnCount = columns;
            dataGridViewBase_TDV.RowCount = rows;


            dataGridViewBase_TDV.Rows[0].ReadOnly = true;
            dataGridViewBase_TDV.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewBase_TDV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);

            buttonFind_TDV.Enabled = true;
            buttonDelete_TDV.Enabled = true;
            buttonSave_TDV.Enabled = true;
            buttonArea_TDV.Enabled = true;
            buttonKids_TDV.Enabled = true;
            buttonEdit_TDV.Enabled = true;
            buttonAdd_TDV.Enabled = true;
            buttonAreaGr_TDV.Enabled = true;
            buttonMin_TDV.Enabled = true;
            buttonAverage_TDV.Enabled = true;
            buttonMax_TDV.Enabled = true;
            buttonFilterCansel_TDV.Enabled = true;
            buttonFilter_TDV.Enabled = true;
            textBoxFind_TDV.Enabled = true;
            textBoxMax_TDV.Enabled = true;
            textBoxMin_TDV.Enabled = true;
            textBoxAverage_TDV.Enabled = true;
            comboBoxFilter_TDV.Enabled = true;


        }
        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
        private void buttonFind_TDV_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_TDV.RowCount; i++)
                {
                    dataGridViewBase_TDV.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_TDV.ColumnCount; j++)
                        if (dataGridViewBase_TDV.Rows[i].Cells[j].Value != null)
                            if (dataGridViewBase_TDV.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_TDV.Text))
                            {
                                dataGridViewBase_TDV.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonArea_TDV_Click(object sender, EventArgs e)
        {
            dataGridViewBase_TDV.Sort(dataGridViewBase_TDV.Columns[3], ListSortDirection.Descending);
        }
        private void buttonKids_TDV_Click(object sender, EventArgs e)
        {
            dataGridViewBase_TDV.Sort(dataGridViewBase_TDV.Columns[4], ListSortDirection.Descending);
        }
        private void buttonAreaGr_TDV_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;


            foreach (DataGridViewRow row in dataGridViewBase_TDV.Rows)
            {

                double area = Convert.ToDouble(row.Cells[2].Value);
                int roomCount = Convert.ToInt32(row.Cells[3].Value);
                series.Points.AddXY(roomCount, area);
            }
            chart1.Series.Add(series);
            chart1.Show();
        }
        public void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void buttonEdit_TDV_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewBase_TDV.CurrentRow.Index;
                FormEdit fed = new FormEdit(this);
                fed.textBoxPadik_TDV.Text = dataGridViewBase_TDV.Rows[a].Cells[0].Value.ToString();
                fed.textBoxAppartament_TDV.Text = dataGridViewBase_TDV.Rows[a].Cells[1].Value.ToString();
                fed.textBoxRooms_TDV.Text = dataGridViewBase_TDV.Rows[a].Cells[2].Value.ToString();
                fed.textBoxTotalArea_TDV.Text = dataGridViewBase_TDV.Rows[a].Cells[3].Value.ToString();
                fed.comboBoxKids_TDV.Text = dataGridViewBase_TDV.Rows[a].Cells[4].Value.ToString();
                fed.comboBoxDebt_TDV.Text = dataGridViewBase_TDV.Rows[a].Cells[5].Value.ToString();
   
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonMin_TDV_Click(object sender, EventArgs e)
        {
            double minValue = double.MaxValue;
            foreach (DataGridViewRow row in dataGridViewBase_TDV.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    if (cellValue < minValue)
                    {
                        minValue = cellValue;
                    }
                }
            }
            textBoxMin_TDV.Text = minValue.ToString();
        }
        private void buttonAverage_TDV_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewBase_TDV.Rows)
            {
                // Проверка, что значение в ячейке не является пустым или нулевым
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    sum += cellValue;
                    count++;
                }
            }

            double average = sum / count;
            textBoxAverage_TDV.Text = Convert.ToString(Math.Round(average, 2));
        }
        private void buttonMax_TDV_Click(object sender, EventArgs e)
        {
            double maxValue = double.MinValue;
            foreach (DataGridViewRow row in dataGridViewBase_TDV.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    if (cellValue > maxValue)
                    {
                        maxValue = cellValue;
                    }
                }
            }
            textBoxMax_TDV.Text = maxValue.ToString();
        }
        private void buttonFilter_TDV_Click(object sender, EventArgs e)
        { 
            string filterValue = comboBoxFilter_TDV.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_TDV.Rows)
            {
                string cellValue = row.Cells[5].Value.ToString();
                if (cellValue == filterValue)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            
        }

        private void buttonFilterCansel_TDV_Click(object sender, EventArgs e)
        {
            string filterValue = comboBoxFilter_TDV.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_TDV.Rows)
            {
                string cellValue = row.Cells[5].Value.ToString();
                if (cellValue == filterValue)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }
    }
}
