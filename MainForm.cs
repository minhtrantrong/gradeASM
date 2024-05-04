namespace GradeASM
{
    public partial class MainForm : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveAndGradeBtn_Click(object sender, EventArgs e)
        {
            gradeUserControl1.LoadDataGrid(criteriaUserControl1.criteriaDataGrid);
            gradeUserControl1.Show();
            gradeUserControl1.BringToFront();
        }

        private void createGradeBtn_Click(object sender, EventArgs e)
        {
            criteriaUserControl1.Show();
            criteriaUserControl1.BringToFront();
        }

        private void loadGradeBtn_Click(object sender, EventArgs e)
        {
            criteriaUserControl1.Show();
            criteriaUserControl1.BringToFront();
        }

        private void templateForm_Load(object sender, EventArgs e)
        {
            criteriaUserControl1.Hide();
            gradeUserControl1.Hide();
        }
    }
}
