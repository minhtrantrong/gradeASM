using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeASM
{
    public partial class gradeUserControl : UserControl
    {
        public gradeUserControl()
        {
            InitializeComponent();
        }
        public void LoadDataGrid(DataGridView dataGridView)
        {
            Controls.Clear();
            confirmGradeBtn = new Button();
            sectionHeadLable = new Label();
            criteriaHeadLabel = new Label();
            markHeaderLabel = new Label();
            commentHeaderLabel = new Label();

            // 
            // confirmGradeBtn
            // 
            confirmGradeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            confirmGradeBtn.BackColor = SystemColors.ActiveCaption;
            confirmGradeBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmGradeBtn.Location = new Point(653, 364);
            confirmGradeBtn.Name = "confirmGradeBtn";
            confirmGradeBtn.Size = new Size(133, 27);
            confirmGradeBtn.TabIndex = 0;
            confirmGradeBtn.Text = "Confirm Grade";
            confirmGradeBtn.UseVisualStyleBackColor = false;
            Controls.Add(confirmGradeBtn);
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
                commentTextBox.Text = "";
                Controls.Add(commentTextBox);
            }
        }
    }
}
