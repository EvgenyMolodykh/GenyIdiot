using GeniyIdiotCommon;

namespace GeniyIdiotWinFormsApp
{

    public partial class ResultsForm : Form
    {
        private User user;
        public ResultsForm(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<User> fileContent = UsersResultStorage.GetAll();
                foreach (var user in fileContent)
                {
                    resultsDataGridView.Rows.Add(user.Name,user.CountRightAnswers, user.Diagnose);
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var mainForm = new mainForm();
                mainForm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
