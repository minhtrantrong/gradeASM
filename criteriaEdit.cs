using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeASM
{
    public partial class criteriaUserControl : UserControl
    {
        public criteriaUserControl()
        {
            InitializeComponent();
        }
        public void SaveToCSV(DataGridView dataGridView, bool startupLoad=false)
        {
            StringBuilder sb = new StringBuilder();

            // Get the column headers
            IEnumerable<string> columnHeaders = dataGridView.Columns
                .OfType<DataGridViewColumn>()
                .Select(column => column.HeaderText);
            sb.AppendLine(string.Join(",", columnHeaders));

            // Get the data rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                IEnumerable<string> rowData = row.Cells
                    .OfType<DataGridViewCell>()
                    .Select(cell => cell.Value?.ToString() ?? string.Empty);
                sb.AppendLine(string.Join(",", rowData));
            }
            if (startupLoad)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "startupLoad.csv");
                File.WriteAllText(filePath, sb.ToString());
                MessageBox.Show($"Template file has been saved successfully at {filePath}!");
            } 
            else
            {
                // Save to CSV file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save CSV File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, sb.ToString());
                    MessageBox.Show("CSV file has been saved successfully!");
                }
            }
            
        }
        private void saveTemplateBtn_Click(object sender, EventArgs e)
        {
            SaveToCSV(criteriaDataGrid);
        }
    }
}
