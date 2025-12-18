using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task5.V1.Lib
{
    public class DataService : ISprint6Task5V1
    {
        public double[] LoadFromDataFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу пустой.", nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            var positives = new List<double>();

            foreach (string rawLine in File.ReadAllLines(path))
            {
                string line = (rawLine ?? "").Trim();
                if (line.Length == 0) continue;

                line = line.Replace(',', '.');

                if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                {
                    if (value > 0)
                        positives.Add(Math.Round(value, 3));
                }
            }

            return positives.ToArray();
        }
    }
}