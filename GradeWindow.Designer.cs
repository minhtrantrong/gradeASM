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
            confirmGradeBtn = new Button();
            SuspendLayout();
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
            // 
            // gradeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(confirmGradeBtn);
            Name = "gradeUserControl";
            Size = new Size(800, 400);
            ResumeLayout(false);
        }

        #endregion

        private Label sectionHeadLable;
        private Label criteriaHeadLabel;
        private Label markHeaderLabel;
        private Label commentHeaderLabel;
        private Button confirmGradeBtn;
    }
}
