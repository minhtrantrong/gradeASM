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
            section = new DataGridViewTextBoxColumn();
            criteria = new DataGridViewTextBoxColumn();
            mark = new DataGridViewTextBoxColumn();
            comment = new DataGridViewTextBoxColumn();
            saveTemplateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)criteriaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // criteriaDataGrid
            // 
            criteriaDataGrid.AllowUserToOrderColumns = true;
            criteriaDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            criteriaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            criteriaDataGrid.Columns.AddRange(new DataGridViewColumn[] { section, criteria, mark, comment });
            criteriaDataGrid.Location = new Point(11, 13);
            criteriaDataGrid.Name = "criteriaDataGrid";
            criteriaDataGrid.Size = new Size(605, 370);
            criteriaDataGrid.TabIndex = 0;
            // 
            // section
            // 
            section.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            section.HeaderText = "Section";
            section.Name = "section";
            section.Width = 71;
            // 
            // criteria
            // 
            criteria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            criteria.HeaderText = "Criteria";
            criteria.Name = "criteria";
            // 
            // mark
            // 
            mark.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            mark.HeaderText = "Mark";
            mark.Name = "mark";
            mark.Width = 59;
            // 
            // comment
            // 
            comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            comment.HeaderText = "Comment";
            comment.Name = "comment";
            // 
            // saveTemplateBtn
            // 
            saveTemplateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveTemplateBtn.BackColor = SystemColors.Highlight;
            saveTemplateBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveTemplateBtn.Location = new Point(459, 389);
            saveTemplateBtn.Name = "saveTemplateBtn";
            saveTemplateBtn.Size = new Size(157, 38);
            saveTemplateBtn.TabIndex = 3;
            saveTemplateBtn.Text = "Save Template";
            saveTemplateBtn.UseVisualStyleBackColor = false;
            saveTemplateBtn.Click += saveTemplateBtn_Click;
            // 
            // criteriaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveTemplateBtn);
            Controls.Add(criteriaDataGrid);
            Name = "criteriaUserControl";
            Size = new Size(630, 430);
            ((System.ComponentModel.ISupportInitialize)criteriaDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView criteriaDataGrid;
        private DataGridViewTextBoxColumn section;
        private DataGridViewTextBoxColumn criteria;
        private DataGridViewTextBoxColumn mark;
        private DataGridViewTextBoxColumn comment;
        private Button saveTemplateBtn;
    }
}
