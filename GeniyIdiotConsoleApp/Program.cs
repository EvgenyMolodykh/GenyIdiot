using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using GeniyIdiotCommon;
namespace GenyIdionConsoleApp
{
    class Program
    {
        static void Main()
        {
            bool replay = true;

            while (replay)
            {
                Console.WriteLine("Введите ваше имя: ");
                var userName = Console.ReadLine();
                var user = new User(userName);

                QuestionsRepository.CheckQuestionFile();

                var questions = QuestionsRepository.LoadQuestionJson;

                int questionNumber = 1;
                Random random = new Random();


                List<Question> remainderQuestions = new List<Question>();

                while (remainderQuestions.Count > 0)
                {
                    int randomIndex = random.Next(remainderQuestions.Count);
                    var currentQuestion = remainderQuestions[randomIndex];

                    Console.WriteLine("Вопрос № " + questionNumber);
                    Console.WriteLine(currentQuestion.Text);

                    var userAnswer = Console.ReadLine();
                    bool isValidInput = true;
                    int userAnswerInt;

                    while (isValidInput)
                    {
                        if (int.TryParse(userAnswer, out userAnswerInt))
                        {
                            isValidInput = false;
                            if (userAnswerInt == currentQuestion.Answer)
                            {
                                user.CountRightAnswers++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите целое число");
                            userAnswer = Console.ReadLine();
                        }
                    }

                    remainderQuestions.RemoveAt(randomIndex);
                    questionNumber++;
                }


                user.Diagnose = UsersResultStorage.GetDiagnosis(user.CountRightAnswers);


                UsersResultStorage.Save(user);

                Console.WriteLine($"{user.Name} показать результаты попыток? Да/Нет");

                var showResult = Console.ReadLine().ToLower();
                while (showResult != "да" && showResult != "нет")
                {
                    Console.WriteLine("Пожалуйста введите да или нет");
                    showResult = Console.ReadLine();
                }

                if (showResult == "да")
                {
                    var resultAll = UsersResultStorage.ReadResults();
                    QuestionsRepository.ShowResults(resultAll);
                }

                Console.WriteLine($"{user.Name} хотите добавить вопрос? Да/Нет");
                var addQuestion = Console.ReadLine().ToLower();

                while (addQuestion != "да" && addQuestion != "нет")
                {
                    Console.WriteLine("Пожалуйста введите да или нет");
                    addQuestion = Console.ReadLine().ToLower();
                }

                if (addQuestion == "да")
                {
                    AddQuestions();

                    var replayAddQuetion = true;
                    while (replayAddQuetion)
                    {
                        Console.WriteLine($"{user.Name} хотите добавить ещё вопрос? Да/Нет");
                        var addQuetions = Console.ReadLine().ToLower();
                        while (addQuetions != "да" && addQuetions != "нет")
                        {
                            Console.WriteLine("Пожалуйста введите да или нет");
                            addQuetions = Console.ReadLine().ToLower();
                        }
                        if (addQuetions == "да")
                        {
                            AddQuestions();
                            replayAddQuetion = true;
                        }
                        else
                        {
                            replayAddQuetion = false;
                        }

                    }

                }

                Console.WriteLine($"{user.Name} хотите удалить вопрос? Да/Нет");
                var deleteQuestion = Console.ReadLine().ToLower();
                while (deleteQuestion != "да" && deleteQuestion != "нет")
                {
                    Console.WriteLine("Пожалуйста введите да или нет");
                    deleteQuestion = Console.ReadLine().ToLower();
                }
                if (deleteQuestion == "да")
                {
                    QuestionsRepository.DisplayingList();
                }

                replay = RepeatTest(user);

            }

        }
        static bool RepeatTest(User user)
        {
            while (true)
            {
                Console.WriteLine($"{user.Name}, хотите повторить тест? Да/Нет");
                string repeatInput = Console.ReadLine().ToLower();
                if (repeatInput == "да")
                {

                    return true;
                }
                else if (repeatInput == "нет")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите да или нет");
                }
            }
        }

        public static void AddQuestions()
        {
            Console.WriteLine("Введите вопрос");    /*спрятать в метод*/
            var newQuestion = Console.ReadLine().ToLower();
            Console.WriteLine("Введите ответ");
            var newAnswer = Console.ReadLine().ToLower();
            int number;
            if (int.TryParse(newAnswer, out number))
            {
                var newValue = newQuestion + '#' + number;
                if (!QuestionsRepository.QuestionExist())
                {
                    QuestionsRepository.CreateNewFile();
                }
                QuestionsRepository.SaveQuestions(newValue);
            }
            else
            {
                Console.WriteLine("Введите целое число");
                newAnswer = Console.ReadLine().ToLower();
            }
        }
    }
}