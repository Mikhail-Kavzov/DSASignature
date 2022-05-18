using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TI4
{
    public static class DSASignature
    {
        private static readonly string pattern = @"(\d+)\s(\d+)";
        private static long FastExp(long a, long z, long n) //алгоритм быстрого возведения в степень
        {
            var a1 = a;
            var z1 = z;
            long x = 1;
            while (z1 != 0)
            {       
                while (z1 % 2 == 0)
                {
                    z1 >>= 1; 
                    a1 = (a1 * a1) % n;
                }
                --z1;
                x = (x * a1) % n;
            }
            return x;
        }

        private static bool MillerTest(long d, long n)
        {


            Random r = new Random();
            long a = r.Next(2, (int)n - 1);

            long x = FastExp(a, d, n);

            if (x == 1 || x == n - 1)
                return true;


            while (d != n - 1)
            {
                x = (x * x) % n;
                d <<= 1;

                if (x == 1)
                    return false;
                if (x == n - 1)
                    return true;
            }

            return false;
        }
        private static bool IsPrime(long n, long k = 10)
        {


            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            long d = n - 1;

            while (d % 2 == 0)
                d >>= 1;

            for (int i = 0; i < k; i++)
                if (MillerTest(d, n) == false)
                    return false;

            return true;
        }


        private static long CheckParameters(long q, long p, long h, long x, long k)
        {   
            if (q>int.MaxValue || p>int.MaxValue || h>int.MaxValue || x> int.MaxValue || k>int.MaxValue)
                throw new Exception($"Введенные параметры превышают максимальное значение {int.MaxValue}");
            if (!IsPrime(q))
                throw new Exception("Число Q не является простым");
            if (!(k > 0 && k < q))
                throw new Exception($"Число K не лежит в диапазоне: [1..{q - 1}]");
            if (!(x > 0 && x < q))
                throw new Exception($"Число X не лежит в диапазоне: [1..{q-1}]");
            if (!IsPrime(p))
                throw new Exception("Число P не является простым");
            if (!(h > 1 && h < p - 1))
                throw new Exception($"Число h не лежит в диапазоне: [2..{p - 2}]");
            if ((p-1) % q != 0)
                throw new Exception("Число Q не является делителем числа P-1");
          
            long g = FastExp(h, (p - 1) / q, p);
            if (g<=1)
                throw new Exception("Число g<=1");
            return g; 
         
        }

        private static long GetHash(string FileContent, long q)
        {

            long H = 100;

                for (int i=0; i < FileContent.Length; i++)
                {
                    H = FastExp((H + FileContent[i]), 2, q);

                }
            
                return H;
        }

        public static void SignSignature(long q, long p, long h, long x, long k,string FileName, out long r, out long s,out long H)

        {

            
            long g = CheckParameters(q,p,h,x,k);

            StreamReader readFile = new StreamReader(FileName);
            string allFile = readFile.ReadToEnd();
            readFile.Close();

           

            H = GetHash(allFile, q);

            r = (FastExp(g, k, p)) % q;

            s = (FastExp(k, q - 2, q) * ((H + x * r) % q)) % q;

            if (r == 0 || s == 0)
                throw new Exception($"Значения некорректны: r = {r}, s = {s}.Введите другое k");
           
            StreamWriter writeFile = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + Path.GetFileNameWithoutExtension(FileName) + ".DSA");
            allFile += "\r\n" + r + " " + s;
            writeFile.Write(allFile);
            writeFile.Close();

        }

        public static string CheckSignature(string FileName, long q, long p, long h,long x,long k, ref long H,ref long r, ref long s)
        {
           
            StreamReader readFile = new StreamReader(FileName);
            List<string> fileText = new List<string>();
            string allFile = "";
            while ((allFile= readFile.ReadLine())!=null)
            {
                fileText.Add(allFile);
            }
            readFile.Close();
            if (fileText.Count <= 1)
                return "Неверный формат файла";
            allFile = fileText.Last();
           if (!Regex.IsMatch(allFile,pattern))
                return "Неверный формат файла";
            fileText.RemoveAt(fileText.Count - 1);
            string FileContent = "";
            if (fileText.Count > 0)
            {
                foreach (string ftext in fileText)
                {
                    FileContent += ftext + "\r\n";
                }
                FileContent = FileContent.Substring(0, FileContent.Length - 2);
            }
            long g = CheckParameters(q, p, h, x, k);
            string[] content = allFile.Split(' ');
            
            long y = FastExp(g, x, p);
            s = long.Parse(content[1]);
            r = long.Parse(content[0]);
            long w = FastExp(s, q - 2, q);
            H = GetHash(FileContent, q);
            long u1 = H * w % q;
            long u2 = r * w % q;
            long v = ((FastExp(g, u1, p) * FastExp(y, u2, p)) % p) % q;
            if (v == r)
                return $"Подпись верна: v = {v} r = {r}";
            return $"Подпись недействительна: v = {v} r = {r}";
        }

    }
}
