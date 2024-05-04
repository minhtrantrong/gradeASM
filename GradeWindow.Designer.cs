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
        private void InitializeComponent()
        {
            sectionHeadLable = new Label();
            criteriaHeadLabel = new Label();
            SuspendLayout();
            // 
            // sectionHeadLable
            // 
            sectionHeadLable.AutoSize = true;
            sectionHeadLable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionHeadLable.Location = new Point(60, 40);
            sectionHeadLable.Name = "sectionHeadLable";
            sectionHeadLable.Size = new Size(57, 17);
            sectionHeadLable.TabIndex = 0;
            sectionHeadLable.Text = "Section ";
            // 
            // criteriaHeadLabel
            // 
            criteriaHeadLabel.AutoSize = true;
            criteriaHeadLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criteriaHeadLabel.Location = new Point(120, 40);
            criteriaHeadLabel.Name = "criteriaHeadLabel";
            criteriaHeadLabel.Size = new Size(53, 17);
            criteriaHeadLabel.TabIndex = 0;
            criteriaHeadLabel.Text = "Criteria";
            // 
            // gradeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(criteriaHeadLabel);
            Controls.Add(sectionHeadLable);
            Name = "gradeUserControl";
            Size = new Size(519, 370);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        private Label sectionHeadLable;
        private Label criteriaHeadLabel;
    }
}
