using System.Windows.Forms;
using System;
using System.Data;
using System.IO;
using System.Text.Json;

namespace GradeASM
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        private DataTable CSVtoDataTable(string csvFilePath)
        {
            DataTable dataTable = new DataTable();

            // Read the CSV file
            string[] csvLines = File.ReadAllLines(csvFilePath);

            // Assume the first line contains the column headers
            string[] headers = csvLines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

            // Read the remaining lines and add them as rows to the DataTable
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] values = csvLines[i].Split(',');
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        private void saveAndGradeBtn_Click(object sender, EventArgs e)
        {
            gradeUserControl1.LoadDataGrid(criteriaUserControl1.criteriaDataGrid);
            gradeUserControl1.Show();
            gradeUserControl1.BringToFront();
            //criteriaUserControl1.SaveToCSV(criteriaUserControl1.criteriaDataGrid, true);
        }

        private void createGradeBtn_Click(object sender, EventArgs e)
        {
            string csvfilePath = Path.Combine(Directory.GetCurrentDirectory(), "startupLoad.csv");
            DataTable criteriaDataTable = CSVtoDataTable(csvfilePath);
            criteriaUserControl1.criteriaDataGrid.DataSource = criteriaDataTable;
            criteriaUserControl1.Show();
            criteriaUserControl1.BringToFront();
        }

        private void loadGradeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvfilePath = openFileDialog.FileName;
                // Process the selected CSV file
                DataTable criteriaDataTable = CSVtoDataTable(csvfilePath);
                criteriaUserControl1.criteriaDataGrid.DataSource = criteriaDataTable;
            }
            criteriaUserControl1.Show();
            criteriaUserControl1.BringToFront();
        }

        private void templateForm_Load(object sender, EventArgs e)
        {
            criteriaUserControl1.Hide();
            gradeUserControl1.Hide();
        }

        private void EditTemplateBtn_Click(object sender, EventArgs e)
        {
            criteriaUserControl1.Show();
            criteriaUserControl1.BringToFront();
        }
    }
}
