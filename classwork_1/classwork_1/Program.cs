using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高");
            float high = float.Parse(Console.ReadLine());
            Console.Write("請輸入體重");
            float weight = float.Parse(Console.ReadLine());
            float BMI= weight * weight / high * high;
            Console.WriteLine("BMI="+BMI);
            if (BMI > 31.5)
            {
                Console.WriteLine("太肥了,不能當兵");
            }
            else if (BMI<16.5)
            {
                Console.WriteLine("太輕了,不能當兵");
            }else
            {
                Console.WriteLine("正常,可以當兵了");
            }


            Console.Read();
        }
    }
}
