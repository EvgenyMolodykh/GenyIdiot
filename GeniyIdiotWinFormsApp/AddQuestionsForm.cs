using GeniyIdiotCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionsForm : Form
    {
        private List<Question> questions;
        private Question question;
        public AddQuestionsForm()
        {
            InitializeComponent();
            
        }

        private void AdditionalQuestionButton_Click(object sender, EventArgs e)
        {
            if (addQuestionTextBox.Text == null || addAnswerTextBox.Text == null || addAnswerTextBox.Text == "" || addQuestionTextBox.Text == "")
            {
                MessageBox.Show("Проверьте поля заполнения",
                    "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int number;
            if (int.TryParse(addAnswerTextBox.Text, out number))
            {
                question = new Question();
                question.Text = addQuestionTextBox.Text;
                question.Answer = number;
               
                if (!QuestionsRepository.QuestionExist())
                {
                    QuestionsRepository.CreateNewFile();
                }

                questions = QuestionsRepository.LoadQuestionJson();
                questions.Add(question);
                QuestionsRepository.saveQuestionJson(questions);

                this.Refresh();
                addQuestionTextBox.Text = string.Empty;
                addAnswerTextBox.Text = string.Empty;
            }


        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
