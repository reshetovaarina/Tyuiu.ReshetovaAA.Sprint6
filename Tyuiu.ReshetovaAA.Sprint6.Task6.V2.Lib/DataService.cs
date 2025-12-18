using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return "";

            if (!File.Exists(path))
                return "";

            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 2)
                    {
                        if (sb.Length > 0) sb.Append(" ");
                        sb.Append(parts[1]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}