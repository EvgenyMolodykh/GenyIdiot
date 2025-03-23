using GeniyIdiotCommon;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {

        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            List<string> questions = questionDeleteList();

            questionListBox.Items.AddRange(questions.ToArray());
        }
        private List<string> questionDeleteList()
        {
            var currentQuestionsInFile = QuestionsRepository.LoadQuestionJson();

            List<string> questionsString = new List<string>();

            foreach (Question q in currentQuestionsInFile)
            {
                questionsString.Add(q.Text);
            }
            return questionsString;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem != null)
            {
                string selectedQuestion = questionListBox.SelectedItem.ToString();
                questionListBox.Items.Remove(selectedQuestion);

                var currentQuestionsInFile = QuestionsRepository.LoadQuestionJson();
                List<Question> updatedQuestionList = new List<Question>();

                foreach (var q in currentQuestionsInFile)
                {
                    if (q.Text != selectedQuestion)
                    {
                        updatedQuestionList.Add(q);
                    }
                }

                QuestionsRepository.saveQuestionJson(updatedQuestionList);

                MessageBox.Show("Вопрос успешно удален.");
            }
            else
            {
                MessageBox.Show("Выделите вопрос");
                return;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var addQuestionForm = new AddQuestionsForm();
            addQuestionForm.ShowDialog();
        }
    }
}
