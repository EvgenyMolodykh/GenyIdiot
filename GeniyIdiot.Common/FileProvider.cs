using System.Text;

namespace GeniyIdiotCommon
{
    public class FileProvider
    {
        public static string Read(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            return fileContent;
        }

        public static void Append(string value, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                writer.WriteLine(value);
            }
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void Create(string filePath)
        {
            using (FileStream fs = File.Create(filePath))
            {

            }
        }

        public static void OverWriting(string filePath, string value)
        {
            File.WriteAllText(filePath, value);

        }
    }
}
