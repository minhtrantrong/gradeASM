namespace GradeASM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadGradeBtn = new Button();
            createGradeBtn = new Button();
            saveAndGradeBtn = new Button();
            mainPanel = new Panel();
            criteriaUserControl1 = new criteriaUserControl();
            gradeUserControl1 = new gradeUserControl(criteriaUserControl1.criteriaDataGrid);
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loadGradeBtn
            // 
            loadGradeBtn.BackColor = SystemColors.ActiveBorder;
            loadGradeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loadGradeBtn.Location = new Point(3, 55);
            loadGradeBtn.Name = "loadGradeBtn";
            loadGradeBtn.Size = new Size(141, 60);
            loadGradeBtn.TabIndex = 0;
            loadGradeBtn.Text = "Load Grade Template";
            loadGradeBtn.UseVisualStyleBackColor = false;
            loadGradeBtn.Click += loadGradeBtn_Click;
            // 
            // createGradeBtn
            // 
            createGradeBtn.BackColor = SystemColors.GradientActiveCaption;
            createGradeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            createGradeBtn.Location = new Point(3, 240);
            createGradeBtn.Name = "createGradeBtn";
            createGradeBtn.Size = new Size(141, 59);
            createGradeBtn.TabIndex = 0;
            createGradeBtn.Text = "Create New Template";
            createGradeBtn.UseVisualStyleBackColor = false;
            createGradeBtn.Click += createGradeBtn_Click;
            // 
            // saveAndGradeBtn
            // 
            saveAndGradeBtn.BackColor = SystemColors.ActiveCaption;
            saveAndGradeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            saveAndGradeBtn.ForeColor = Color.FromArgb(192, 0, 0);
            saveAndGradeBtn.Location = new Point(3, 417);
            saveAndGradeBtn.Name = "saveAndGradeBtn";
            saveAndGradeBtn.Size = new Size(141, 84);
            saveAndGradeBtn.TabIndex = 0;
            saveAndGradeBtn.Text = "Save  and Start Grading";
            saveAndGradeBtn.UseVisualStyleBackColor = false;
            saveAndGradeBtn.Click += saveAndGradeBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(loadGradeBtn);
            mainPanel.Controls.Add(createGradeBtn);
            mainPanel.Controls.Add(saveAndGradeBtn);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(236, 553);
            mainPanel.TabIndex = 2;
            // 
            // criteriaUserControl1
            // 
            criteriaUserControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            criteriaUserControl1.Location = new Point(254, 12);
            criteriaUserControl1.Name = "criteriaUserControl1";
            criteriaUserControl1.Size = new Size(781, 553);
            criteriaUserControl1.TabIndex = 3;
            // 
            // gradeUserControl1
            // 
            gradeUserControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradeUserControl1.Location = new Point(254, 12);
            gradeUserControl1.Name = "gradeUserControl1";
            gradeUserControl1.Size = new Size(789, 553);
            gradeUserControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 577);
            Controls.Add(gradeUserControl1);
            Controls.Add(criteriaUserControl1);
            Controls.Add(mainPanel);
            Name = "MainForm";
            Text = "Grade Assignment";
            Load += templateForm_Load;
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button loadGradeBtn;
        private Button createGradeBtn;
        private Button saveAndGradeBtn;
        private Panel mainPanel;
        internal criteriaUserControl criteriaUserControl1;
        private gradeUserControl gradeUserControl1;
    }
}
