using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingOverridingPrac32
{
    /// <summary>
    /// Shadowing 예제
    /// </summary>
    internal class Program
    {

        //전역변수
        public static int number = 7; //같은 이름의 지역변수에 의해 가려짐(클래스 변수)
        public int number2 = 2; //같은 이름의 지역변수에 의해 가려짐(인스턴스 변수)

        static void Main(string[] args) //클래스 메서드가 아니라면 전역변수에 접근 가능
        {
            int number = 10;
            Console.WriteLine(number); //지역변수 number 출력
            Console.WriteLine(Program.number); //전역변수
}

        void doSomething()
        {
            int number2 = 3;
            Console.WriteLine(number2); //지역변수
            Console.WriteLine(this.number2); //전역변수

        }
    }
}
