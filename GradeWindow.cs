using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections;

namespace GradeASM
{
    public partial class gradeUserControl : UserControl
    {
        public gradeUserControl()
        {
            InitializeComponent();
        }
        private Dictionary<string, List<string>> criteriaDict = 
            new Dictionary<string, List<string>>();
        private Dictionary<string, Dictionary<string, List<string>>> gradeDict =
            new Dictionary<string, Dictionary<string, List<string>>>();
        private const string COMPLETED = "completed";
        private const string UNCOMPLETED = "uncompleted";
        // Event handler for checkbox CheckedChanged event
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string checkBoxName = checkBox.Name;
            string markTextBoxName = checkBoxName.Replace("criteriaCheckBox", "markTextBox");
            string commentTextBoxName = checkBoxName.Replace("criteriaCheckBox", "commentTextBox");
            TextBox markTextBox = (TextBox)Controls.Find(markTextBoxName, true).FirstOrDefault();
            TextBox commentTextBox = (TextBox)Controls.Find(commentTextBoxName, true).FirstOrDefault();
            if (checkBox.Checked)
            {
                //Udate in gradeDict
                string sessionName = criteriaDict[checkBoxName][2];
                gradeDict[sessionName][COMPLETED].Add(checkBoxName);
                gradeDict[sessionName][UNCOMPLETED].Remove(checkBoxName);
                // Update mark
                if (markTextBox != null)
                {
                    markTextBox.Text = criteriaDict[checkBoxName][0];         
                }
                // Update comment
                if (commentTextBox != null)
                {
                    commentTextBox.Text = "";
                }
            }
            else
            {
                //Udate in gradeDict
                string sessionName = criteriaDict[checkBoxName][2];
                gradeDict[sessionName][COMPLETED].Remove(checkBoxName);
                gradeDict[sessionName][UNCOMPLETED].Add(checkBoxName);
                // Update mark
                if (markTextBox != null)
                {
                    markTextBox.Text = "0";                    
                }
                // Update comment
                if (commentTextBox != null)
                {
                    commentTextBox.Text = criteriaDict[checkBoxName][1];
                }
            }
        }
        //Generate the Grading UI
        public void LoadDataGrid(DataGridView dataGridView)
        {
            //this.GenerateGradeDict(dataGridView);
            Controls.Clear();
            confirmGradeBtn = new Button();
            sectionHeadLable = new Label();
            criteriaHeadLabel = new Label();
            markHeaderLabel = new Label();
            commentHeaderLabel = new Label();
            // 
            // sectionHeadLable
            // 
            sectionHeadLable.AutoSize = true;
            sectionHeadLable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionHeadLable.Location = new Point(60, 40);
            sectionHeadLable.Name = "sectionHeadLable";
            sectionHeadLable.Size = new Size(57, 17);
            //sectionHeadLable.TabIndex = 0;
            sectionHeadLable.Text = "Section ";
            Controls.Add(sectionHeadLable);
            // 
            // criteriaHeadLabel
            // 
            criteriaHeadLabel.AutoSize = true;
            criteriaHeadLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criteriaHeadLabel.Location = new Point(120, 40);
            criteriaHeadLabel.Name = "criteriaHeadLabel";
            criteriaHeadLabel.Size = new Size(57, 17);
            //criteriaHeadLabel.TabIndex = 0;
            criteriaHeadLabel.Text = "Criteria";
            Controls.Add(criteriaHeadLabel);
            // 
            // markHeaderLabel
            // 
            markHeaderLabel.AutoSize = true;
            markHeaderLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            markHeaderLabel.Location = new Point(600, 40);
            markHeaderLabel.Name = "markHeaderLabel";
            markHeaderLabel.Size = new Size(57, 17);
            //markHeaderLabel.TabIndex = 0;
            markHeaderLabel.Text = "Mark";
            Controls.Add(markHeaderLabel);
            // 
            // commentHeaderLabel
            // 
            commentHeaderLabel.AutoSize = true;
            commentHeaderLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commentHeaderLabel.Location = new Point(660, 40);
            commentHeaderLabel.Name = "commentHeaderLabel";
            commentHeaderLabel.Size = new Size(57, 17);
            //commentHeaderLabel.TabIndex = 0;
            commentHeaderLabel.Text = "Comment";
            Controls.Add(commentHeaderLabel);

            // Generate based on criteriaDataGrid
            string currentSection = "";
            Point currentLocation = new Point(60, 40);
            //int criteriaIndentation = 60;
            int lineSpace = 40;
            int sectionCount = 0;
            int criteriaCount = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string section = row.Cells[0].Value?.ToString() ?? string.Empty;
                string criteria = row.Cells[1].Value?.ToString() ?? string.Empty;
                string mark = row.Cells[2].Value?.ToString() ?? string.Empty;
                string comment = row.Cells[3].Value?.ToString() ?? string.Empty;

                if (section == "") continue;
                if (section != currentSection)
                {
                    sectionCount++;
                    currentSection = section;
                    // Create the section label
                    Label sectionLable = new Label();
                    sectionLable.AutoSize = true;
                    currentLocation.Y += lineSpace;
                    sectionLable.Location = currentLocation;
                    sectionLable.Text = section;
                    sectionLable.Size = new Size(55, 15);
                    sectionLable.Name = "section" + sectionCount.ToString();
                    sectionLable.TabIndex = sectionCount + criteriaCount;
                    Controls.Add(sectionLable);
                }
                // Create criteria checkbox
                criteriaCount++;
                CheckBox criteriaCheckBox = new CheckBox();
                criteriaCheckBox.AutoSize = true;
                currentLocation.Y += lineSpace;
                criteriaCheckBox.Location = new Point(120, currentLocation.Y);
                criteriaCheckBox.Name = "criteriaCheckBox" + criteriaCount.ToString();
                criteriaCheckBox.Size = new Size(100, 20);
                criteriaCheckBox.TabIndex = sectionCount + criteriaCount;
                criteriaCheckBox.Text = criteria;
                criteriaCheckBox.UseVisualStyleBackColor = true;
                criteriaCheckBox.CheckedChanged += CheckBox_CheckedChanged;
                Controls.Add(criteriaCheckBox);
                // Create mark textbox
                TextBox markTextBox = new TextBox();
                markTextBox.AutoSize = true;
                markTextBox.Location = new Point(600, currentLocation.Y);
                markTextBox.Name = "markTextBox" + criteriaCount.ToString();
                markTextBox.Size = new Size(40, 20);
                //markTextBox.TabIndex = sectionCount + criteriaCount;
                markTextBox.Text = "0";
                Controls.Add(markTextBox);
                // Create comment textbox
                TextBox commentTextBox = new TextBox();
                commentTextBox.AutoSize = true;
                commentTextBox.Location = new Point(660, currentLocation.Y);
                commentTextBox.Name = "commentTextBox" + criteriaCount.ToString();
                commentTextBox.Size = new Size(400, 20);
                //commentTextBox.TabIndex = sectionCount + criteriaCount;
                commentTextBox.Text = comment;
                Controls.Add(commentTextBox);
                //Update criteriaDict
                //criteriaDict.Add(criteriaCheckBox.Name, new List<string> { mark, comment });
                criteriaDict[criteriaCheckBox.Name] = new List<string> { mark, comment, section, criteria };
                // Update gradeDict
                if (gradeDict.ContainsKey(section))
                {
                    gradeDict[section][UNCOMPLETED].Add(criteriaCheckBox.Name);
                }
                else
                {
                    gradeDict[section] = new Dictionary<string, List<string>>();
                    gradeDict[section].Add(COMPLETED, []);
                    gradeDict[section].Add(UNCOMPLETED, []);
                    gradeDict[section][UNCOMPLETED].Add(criteriaCheckBox.Name);
                }
            }
            // 
            // confirmGradeBtn
            // 
            confirmGradeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            confirmGradeBtn.BackColor = SystemColors.ActiveCaption;
            confirmGradeBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentLocation.Y += lineSpace;
            confirmGradeBtn.Location = new Point(120, currentLocation.Y);
            confirmGradeBtn.Name = "confirmGradeBtn";
            confirmGradeBtn.Size = new Size(133, 27);
            confirmGradeBtn.TabIndex = 0;
            confirmGradeBtn.Text = "Confirm Grade";
            confirmGradeBtn.UseVisualStyleBackColor = false;
            confirmGradeBtn.Click += confirmGradeBtn_Click;
            Controls.Add(confirmGradeBtn);
        }

        private (string, float) GenerateGradeResults()
        {
            string resultComment = "Comments: ";
            float totalMark = 0;
            foreach (string section in gradeDict.Keys) {
                resultComment += $"\n In section {section}: \n";
                // Update based on COMPLETED
                resultComment += "\t You have completed: \n";
                foreach (string criteriaName in gradeDict[section][COMPLETED])
                {
                    // Update the totalMark
                    float mark = float.Parse(criteriaDict[criteriaName][0]);
                    totalMark += mark;
                    // Update the resultComment
                    resultComment += $"\t\t - {criteriaDict[criteriaName][3]}: \n";
                }
                // Update based on UNCOMPLETED
                if (gradeDict[section][UNCOMPLETED].Count == 0) continue;
                resultComment += "\t You should: \n";
                foreach (string criteriaName in gradeDict[section][UNCOMPLETED])
                {
                    // Update the resultComment
                    resultComment += $"\t\t - {criteriaDict[criteriaName][3]}: \n";
                    if (criteriaDict[criteriaName][1].Trim() != "")
                    {
                        resultComment += $"\t\t For improving, you should: " +
                            $"{criteriaDict[criteriaName][1]}";
                    }
                }
            }
            return (resultComment, totalMark);
        }
        private void confirmGradeBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                (string comment, float totalMark) = GenerateGradeResults();
                string message = $"Total mark: {totalMark} \n Comment: {comment}";
                MessageBox.Show(message);
            }
            catch
            {
                MessageBox.Show("The mark in grade must be a float number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
