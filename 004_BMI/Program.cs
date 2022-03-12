using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            Console.Write("키(cm)를 입력하세요 : ");
            height = double.Parse(Console.ReadLine());

            Console.Write("몸무게(kg)를 입력하세요 : ");
            weight = double.Parse(Console.ReadLine());

            double BMI; // [몸무게(kg)/키(m)^2]
            BMI = weight / ((height / 100) * (height / 100));
            Console.Write(BMI);
        }
    }
}
