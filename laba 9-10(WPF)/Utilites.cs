using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input.StylusPlugIns;
using Microsoft.VisualBasic;
namespace контрольная_2
{
    internal class Utilites
    { 
        public int[] completeMass(int lenght)//заполнение массива длиной lenght 
        {
            int[] str = new int[lenght];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Convert.ToInt32( Interaction.InputBox("Введите символ")); 
            }
            return str;
        }
        public string RepeatingChar(string[] chars)//находит самый используемый символ в строке
        {
            
            var count = 0;//количесвто повторов
            var index = -1;//индекс в массиве
            for (var i = 0; i < chars.Length; ++i)
            {
                var k = 1;
                for (var j = i + 1; j < chars.Length; ++j)
                    if (chars[i] == chars[j]) k++;
                if (k <= count) continue;
                count = k;
                index = i;
            }
         
            return chars[index]; //возвращает самое повторяющиеся число 
        }
        public string[] DeleteChar( string[] Mass, string charDel)// удаляет символ с шагом через два
        {
            int k = 0;
            for (int i = 0; i < Mass.Length; i++)
            {
                if (charDel == Mass[i])
                {
                    k++;
                    if (k % 2 == 0)
                    {
                        Mass[i] = "";
                    }
                }

            }
            return Mass;
        }
        public string CharackterInTextBox(string[] str)//метод для вывода символов с массива в TextBox
        {
            string textBox = "";
            foreach (string item in str)
            {
                textBox += item+";";
            }
            return textBox;
        }
        public string[] ConvertToStr(int[] mass)
        {
            string[] str = new string[mass.Length];
            for(int i = 0; i < mass.Length; i++)
            {
                str[i] = Convert.ToString(mass[i]);
            }
            return str;
        }
       
    }
}
