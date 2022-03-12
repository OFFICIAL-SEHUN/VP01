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
            Console.WriteLine("BMI : {0}",BMI);

            if (BMI < 20) Console.WriteLine("저체중 입니다.");
            else if (BMI <= 25) Console.WriteLine("정상체중 입니다.");
            else if (BMI <= 30) Console.WriteLine("경도비만 입니다.");
            else if (BMI <= 40) Console.WriteLine("비만 입니다.");
            else Console.WriteLine("고도비만 입니다.");

        }
    }
}
