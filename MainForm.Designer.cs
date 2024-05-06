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
            EditTemplateBtn = new Button();
            criteriaUserControl1 = new criteriaUserControl();
            gradeUserControl1 = new gradeUserControl();
            button1 = new Button();
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
            createGradeBtn.Location = new Point(3, 165);
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
            saveAndGradeBtn.Text = "Save and Start Grading";
            saveAndGradeBtn.UseVisualStyleBackColor = false;
            saveAndGradeBtn.Click += saveAndGradeBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mainPanel.Controls.Add(EditTemplateBtn);
            mainPanel.Controls.Add(loadGradeBtn);
            mainPanel.Controls.Add(createGradeBtn);
            mainPanel.Controls.Add(saveAndGradeBtn);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(179, 629);
            mainPanel.TabIndex = 2;
            // 
            // EditTemplateBtn
            // 
            EditTemplateBtn.BackColor = SystemColors.GradientInactiveCaption;
            EditTemplateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditTemplateBtn.Location = new Point(3, 275);
            EditTemplateBtn.Name = "EditTemplateBtn";
            EditTemplateBtn.Size = new Size(141, 59);
            EditTemplateBtn.TabIndex = 1;
            EditTemplateBtn.Text = "Edit Current Template";
            EditTemplateBtn.UseVisualStyleBackColor = false;
            EditTemplateBtn.Click += EditTemplateBtn_Click;
            // 
            // criteriaUserControl1
            // 
            criteriaUserControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            criteriaUserControl1.Location = new Point(197, 12);
            criteriaUserControl1.Name = "criteriaUserControl1";
            criteriaUserControl1.Size = new Size(838, 629);
            criteriaUserControl1.TabIndex = 3;
            // 
            // gradeUserControl1
            // 
            gradeUserControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradeUserControl1.AutoSize = true;
            gradeUserControl1.Location = new Point(197, 12);
            gradeUserControl1.Name = "gradeUserControl1";
            gradeUserControl1.Size = new Size(846, 629);
            gradeUserControl1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(691, 314);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 653);
            Controls.Add(gradeUserControl1);
            Controls.Add(button1);
            Controls.Add(mainPanel);
            Controls.Add(criteriaUserControl1);
            Name = "MainForm";
            Text = "Grade Assignment";
            WindowState = FormWindowState.Maximized;
            Load += templateForm_Load;
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadGradeBtn;
        private Button createGradeBtn;
        private Button saveAndGradeBtn;
        private Panel mainPanel;
        private criteriaUserControl criteriaUserControl1;
        private gradeUserControl gradeUserControl1;
        private Button button1;
        private Button EditTemplateBtn;
    }
}
