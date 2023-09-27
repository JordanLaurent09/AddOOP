using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2709
{
    internal class ExtensionMethods
    {
        // Метод с самым высоким баллом
        public static string GetMeanMark(List<(string, int, double)> students)
        {
            double max = 0;
            string name = "";

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Item3 > max)
                {
                    max = students[i].Item3;
                    name = students[i].Item1;
                }
            }

            return name;
        }

        // Средний возраст 

        public static int GetMeanAge(List<(string, int, double)> students)
        {
            int age = 0;
            for (int i = 0; i < students.Count; i++)
            {
                age += students[i].Item2;
            }
            return age / students.Count;
        }
    }
}

