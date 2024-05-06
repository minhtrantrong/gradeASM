using System.Collections;

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
            SuspendLayout();
            // 
            // gradeUserControl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
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
        //private Button newGradeBtn;
    }
}
