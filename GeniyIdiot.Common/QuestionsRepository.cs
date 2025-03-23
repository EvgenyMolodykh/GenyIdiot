using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace GeniyIdiotCommon
{
    public class QuestionsRepository
    {
        private static string desktopPathWin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string filePathQuestion = Path.Combine(desktopPathWin, "userQuestions.json");
        private int numberOfQuestions;

        public static void ShowResults(string resultAll)//переделать
        {
            Console.WriteLine("{0,-20} {1,-25} {2,-15}", "Имя", "Кол-во правильных ответов", "Диагноз");
            string[] lines = resultAll.Split('\n');
            foreach (var line in lines)
            {
                var values = line.Split('#');
                if (values.Length >= 3)
                {
                    string name = values[0].Trim();
                    int countRightAnswers;
                    if (int.TryParse(values[1], out countRightAnswers))
                    {
                        string diagnose = values[2].Trim();
                        Console.WriteLine("{0,-20} {1,-25} {2,-15}", name, countRightAnswers, diagnose);
                    }
                }
            }
        }
        public static List<Question> GetDefaultQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question("Сколько будет два плюс два и умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько нужно распилов?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
            return questions;
        }

        public static int GetQuestionsCount()
        {
            int numberQuestion = LoadQuestionJson().Count;
            return numberQuestion;
        }

        public static bool QuestionExist()
        {
            return FileProvider.Exists(filePathQuestion);
        }

        public static void SaveQuestions(string value)
        {
            FileProvider.Append(value, filePathQuestion);
        }

        public static void CreateNewFile()
        {
            FileProvider.Create(filePathQuestion);
        }


        public static List<Question> LoadQuestionJson()
        {
            if (!FileProvider.Exists(filePathQuestion))
            {
                FileProvider.Create(filePathQuestion);
            }

            var dataQuestions = FileProvider.Read(filePathQuestion);

            List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(dataQuestions);
            if (questions == null)
            {
                questions = GetDefaultQuestions();
            }
            return questions;
        }

        public static void CheckQuestionFile()
        {
            if (!QuestionExist())
            {
                CreateNewFile();

                var quesionList = GetDefaultQuestions();
                foreach (var question in quesionList)
                {
                    SaveQuestions(question.Text + "#" + question.Answer);
                }
            }

        }

        public static void DisplayingList()
        {
            var currentQuestionsInFile = FileProvider.Read(filePathQuestion);
            var questions = currentQuestionsInFile.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine("Список вопросов:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i]}");
            }

            Console.WriteLine("Введите номер вопроса, который вы хотите удалить:");
            if (int.TryParse(Console.ReadLine(), out int questionNumber) && questionNumber >= 1 && questionNumber <= questions.Count)
            {
                questions.RemoveAt(questionNumber - 1);
                string updatedQuestions = string.Join(Environment.NewLine, questions);

                FileProvider.OverWriting(filePathQuestion, updatedQuestions);
                Console.WriteLine("Вопрос успешно удален.");
            }
            else
            {
                Console.WriteLine("Некорректный номер вопроса.");
            }

        }


        public static void WriteQuestions(List<Question> updatedQuestions)
        {

            var existingQuestions = LoadQuestionJson();
            existingQuestions.AddRange(updatedQuestions);

            var jsonOutput = JsonConvert.SerializeObject(existingQuestions, Formatting.Indented);
            FileProvider.OverWriting(filePathQuestion, jsonOutput);
        }


        public static void saveQuestionJson(List<Question> questions)
        {
            if (!FileProvider.Exists(filePathQuestion))
            {
                FileProvider.Create(filePathQuestion);
            }

            var jsonDataQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.OverWriting(filePathQuestion, jsonDataQuestions);
        }

    }
}



