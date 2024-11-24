using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    internal class Program
    {
        //1. Quyidagi ishni bajaruvchi metod yozing:
        //Metodga uzatilgan matn(string)dagi katta harflarni kichik harflarga o'girsin,
        //illo u harfning oldida bo'sh joy(space) bo'lsa, u harfni katta harfga o'girmasin.
        //Matndagi alohida so'zlarning birinchi harflarini katta harfga o'girsin.
        //Matn nuqta bilan tugasin, agar oxirida nuqta bo'lmasa.
        //Natijani konsolga chiqarsin.

        //2. Shunday metod yozingki, u bitta string (matn) turidagi stringWithNumbers deb nomlangan argument qabul qilsin.
        //Metodda shunday kod yozingki, stringWithNumbers matnidagi sonlarni yig'indisini
        //hisoblab topsin va natijani konsolga chiqarsin.
        //Masalan, agar stringWithNumbers ning qiymati "th15 !5 a 6ad p@55w07d" bo'lsa, metodning natijasi 34 bo'ladi.

        //3. Shunday metod yozingki, u ikkita string (matn) turidagi mainString va
        //valueToFind deb nomlangan argumentlarni qabul qilsin. 
        //Metod shunday ishni bajarsinki, mainString ichida valueToFind o'zgaruvchisining
        //qiymati necha marotaba mavjudligini qaytarib bersin.
        //Masalan, agar mainString'ning qiymati "ding-dong! oh, you must be kidding me."
        //ga tenb bo'lsa va valueToFind ning qiymati "ding" bo'lsa,
        //metodning natijasi 2 bo'ladi.

        static void Main()
        {
            string text = "jasjsjn AJSNJnaA asnsa SJNS Masjx axnjsSANA aasmkAS";
            string input = "th15 !5 a 6ad p@55w07d";
            string mainString = "ding-dong! oh, you must be kidding me.";
            string valueToFind = "ding";
           Console.WriteLine(Text(text)+".");
           Console.WriteLine(CalculateSumOfNumbers(input));
            Console.WriteLine(ValueToFind(mainString,valueToFind));
        }

        static int CalculateSumOfNumbers(string stringWithNumbers)
        {
            int result=0;
            for (int i = 0; i < stringWithNumbers.Length; i++)
            {
                if (Char.IsDigit(stringWithNumbers[i]))
                {
                    result +=stringWithNumbers[i]-'0';
                }
            }
            return result;
        }
        static string Text(string text)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join(" ", words);
        }
        static int ValueToFind(string mainString, String valueToFind)
        {
            int count = 0;
            int startIndex = 0;
            while ((startIndex = mainString.IndexOf(valueToFind, startIndex)) != -1)
            {
                count++; 
                startIndex += valueToFind.Length; 
            }

            return count;
        }
    }
}
