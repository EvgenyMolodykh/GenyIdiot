using GeniyIdiotCommon;
namespace GeniyIdiotWinFormsApp
{
    public partial class mainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int currentNumber = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            GetUserName();
            LoadQuestions();
            ShowNextQuestion();
        }

        private void LoadQuestions()
        {
            questions = QuestionsRepository.LoadQuestionJson();
            QuestionsRepository.saveQuestionJson(questions);
        }

        private void ShowNextQuestion()
        {
            Random random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questionTextLabel.AutoSize = false;
            questionTextLabel.MaximumSize = new System.Drawing.Size(600, 0);
            questionTextLabel.AutoSize = true;
            questionTextLabel.Text = currentQuestion.Text;
            currentNumber++;
            questionNumberLabel.Text = "Вопрос №" + currentNumber;


        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (!int.TryParse(userAnswerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Пожалуйста, введите целое число.", "Ошибка ввода ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.CountRightAnswers++;
            }

            questions.Remove(currentQuestion);

            var endGame = questions.Count == 0;
            if (endGame)
            {
                user.Diagnose = UsersResultStorage.GetDiagnosis(user.CountRightAnswers);

                UsersResultStorage.AddResultsJson(user);
                this.Hide();
                var resultsForm = new ResultsForm(user);
                resultsForm.ShowDialog();
                DialogResult result = MessageBox.Show("Вы уверены что хотите выйти из игры и не хотите повторить игру?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();

                }
                else { Application.Restart(); }
                return;
            }

            ShowNextQuestion();

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GetUserName()
        {
            Hide();
            var userNameForm = new UserNameForm();
            if (userNameForm.ShowDialog() == DialogResult.OK)
            {
                user = new User(userNameForm.userNameTextBox.Text);
            }
            Show();


        }

        private void lookResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите посмотреть результаты? Данные ответов не будут сохранены", "Просмотр результатов",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                var resultsForm = new ResultsForm(user);
                resultsForm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите добавить вопрос? Данные ответов не будут сохранены", "Просмотр результатов",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                this.Hide();
                var addQuestion = new AddQuestionsForm();
                addQuestion.Show();
            }
            else
            {
                return;
            }
        }

        private void remoteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти из игры и удалить вопросы? Результаты не сохранятся", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var deleteQuestion = new DeleteQuestionForm();
                deleteQuestion.ShowDialog();
            }
            else
            {
                return;
            }

        }
    }
}
