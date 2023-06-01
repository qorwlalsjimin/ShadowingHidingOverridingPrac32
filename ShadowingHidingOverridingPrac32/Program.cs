using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingOverridingPrac32
{
    internal class Program
    {
        //Hiding 예제
        class Parent
        {
            public int Variable = 273;
            public void Method()
            {
                Console.WriteLine("어흥");
            }
            public virtual void Method2() //오버라이딩
            {
                Console.WriteLine("어흥흥");
            }
        }

        class Child : Parent 
        {
            public new string Variable = "이칠삼"; //하이딩 명시 키워드 new
            public new void Method()
            {
                Console.WriteLine("야옹");
            }

            public override void Method2() //오버라이딩
            {
                Console.WriteLine("야옹야옹");
            }
        }




        //Shadowing 예제
        public static int number = 7; //같은 이름의 지역변수에 의해 가려짐(클래스 변수)
        public int number2 = 2; //같은 이름의 지역변수에 의해 가려짐(인스턴스 변수)

        static void Main(string[] args) //클래스 메서드가 아니라면 전역변수에 접근 가능
        {
            /*섀도잉*/
            int number = 10;
            Console.WriteLine(number); //지역변수 number 출력
            Console.WriteLine(Program.number); //전역변수

            /*하이딩*/
            Child child = new Child();
            Console.WriteLine(child.Variable); //이칠삼

            Parent p = child;
            Console.WriteLine(p.Variable); //273

            child.Method(); //야옹
            p.Method(); //어흥

            child.Method2(); //야옹
            p.Method2(); //어흥

            
        }

        void doSomething()
        {
            int number2 = 3;
            Console.WriteLine(number2); //지역변수
            Console.WriteLine(this.number2); //전역변수

        }
    }
}
