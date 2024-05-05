using System.Windows.Forms;

namespace GradeASM
{
    partial class criteriaUserControl
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
            criteriaDataGrid = new DataGridView();
            exportTemplateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)criteriaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // criteriaDataGrid
            // 
            criteriaDataGrid.AllowUserToOrderColumns = true;
            criteriaDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            criteriaDataGrid.Location = new Point(11, 13);
            criteriaDataGrid.Name = "criteriaDataGrid";
            criteriaDataGrid.Size = new Size(605, 370);
            criteriaDataGrid.TabIndex = 0;
            criteriaDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // exportTemplateBtn
            // 
            exportTemplateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exportTemplateBtn.BackColor = SystemColors.Highlight;
            exportTemplateBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportTemplateBtn.Location = new Point(459, 389);
            exportTemplateBtn.Name = "exportTemplateBtn";
            exportTemplateBtn.Size = new Size(157, 38);
            exportTemplateBtn.TabIndex = 3;
            exportTemplateBtn.Text = "Export Template";
            exportTemplateBtn.UseVisualStyleBackColor = false;
            exportTemplateBtn.Click += saveTemplateBtn_Click;
            // 
            // criteriaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exportTemplateBtn);
            Controls.Add(criteriaDataGrid);
            Name = "criteriaUserControl";
            Size = new Size(630, 430);
            ((System.ComponentModel.ISupportInitialize)criteriaDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView criteriaDataGrid;
        private Button exportTemplateBtn;
    }
}
