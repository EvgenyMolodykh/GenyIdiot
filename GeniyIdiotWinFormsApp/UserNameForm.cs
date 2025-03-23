using GeniyIdiotCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class UserNameForm : Form
    {

        bool isStartGameNuttonCliked = false;

        public UserNameForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            isStartGameNuttonCliked = true;
            Close();
        }

        private void UserNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!isStartGameNuttonCliked)
            {
                var isExit = MessageBox.Show("Закрыть приложение?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isExit == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                e.Cancel = true;
                return;
            }

            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Имя не может быть пустым, введите имя", "Ошибка ввода имени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isStartGameNuttonCliked = false;
                e.Cancel = true;
                return;
            }

        }
    }
}
