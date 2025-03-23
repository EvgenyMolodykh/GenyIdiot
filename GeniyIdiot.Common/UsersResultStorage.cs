using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace GeniyIdiotCommon
{
    public class UsersResultStorage
    {
        private static string desktopPathWin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string filePath = Path.Combine(desktopPathWin, "userResults.json");
        public static string GetDiagnosis(int countRightAnswers)
        {
            int percentageСorrectAnswers = (countRightAnswers * 100) / QuestionsRepository.GetQuestionsCount();

            if (percentageСorrectAnswers == 0)
            {
                return "Идиот";
            }
            if (percentageСorrectAnswers < 20)
            {
                return "Кретин";
            }
            if (percentageСorrectAnswers < 40)
            {
                return "Дурак";
            }
            if (percentageСorrectAnswers < 60)
            {
                return "Нормальный";
            }
            if (percentageСorrectAnswers < 80)
            {
                return "Талант";
            }
            return "Гений";
        }


        public static void Save(User user)
        {
            if (!FileProvider.Exists(filePath))
            {
                FileProvider.Create(filePath);
            }
            string value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnose}";
            FileProvider.Append(value, filePath);

        }

        public static string ReadResults()
        {
            string data = FileProvider.Read(filePath);
            return data;
        }

        public static void SaveJson(List<User> userResults)
        {
            if (!FileProvider.Exists(filePath))
            {
                FileProvider.Create(filePath);
            }

            var jsonData = JsonConvert.SerializeObject(userResults);
            FileProvider.OverWriting(filePath, jsonData);
        }


        public static void AddResultsJson(User user)
        {

            if (!FileProvider.Exists(filePath))
            {
                FileProvider.Create(filePath);
            }

            var userResults = FileProvider.Read(filePath);

            List<User> existingResults = JsonConvert.DeserializeObject<List<User>>(userResults);

            if (existingResults is null)
            {
                existingResults = new List<User>();
            }

            existingResults.Add(user);

            SaveJson(existingResults);

        }
        public static List<User> GetAll()
        {
            var fileData = FileProvider.Read(filePath);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }
    }
}
