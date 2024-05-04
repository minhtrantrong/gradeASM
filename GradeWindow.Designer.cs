namespace GradeASM
{
    partial class gradeUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(DataGridView dataGridView)
        {
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            string currentSection = "";
            Point currentLocation = new Point(60, 0);
            //int criteriaIndentation = 60;
            int lineSpace = 40;
            int sectionCount = 0;
            int criteriaCount = 0;
            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string section = row.Cells[0].Value?.ToString() ?? string.Empty;
                string criteria = row.Cells[1].Value?.ToString() ?? string.Empty;
                if (section != currentSection) 
                {
                    sectionCount ++;
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
                criteriaCount ++;
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

            }
            
            Name = "gradeUserControl";
            Size = new Size(519, 370);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}
