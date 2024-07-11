using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class student
    {
        public int ssn;
        public string name= "mohamed";
        public int age=25;
        public string phone="012365987";
        public student(int ssn1,string name1,int age1,string phone1)
        {
            ssn=ssn1;
            name = name1;
            phone=phone1;
            age = age1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //Console.WriteLine("enter the number");
            //int x=int.Parse(Console.ReadLine());
            //for(int i = 0; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i} * {x}= {i*x}");
            //}
            //Console.ReadKey();
            #endregion

            #region task2
            //Console.WriteLine("please enter your data\n");
            //Console.Write("enter your name :");
            //string name=Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("enter your Id:");
            //int id=int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int age;
            //do
            //{
            //    Console.Write("enter your id :");
            //    age = int.Parse(Console.ReadLine());
            //} while (age < 0);
            //Console.WriteLine();

            //Console.WriteLine("data confirmation");
            //Console.WriteLine($"name: { name}");
            //Console.WriteLine($"id: { id}");
            //Console.WriteLine($"age: { age}");


            #endregion


            student student1=new student(12536, "mohamed",25,"0125369");
          
            Console.WriteLine($"student data\n" +
                $"name:{student1.name}\n" +
                $"student ssn:{student1.ssn}\n" +
                $"student age:{student1.age}\n"+
                $"student phone:{student1.phone}");
            Console.ReadKey();


        }
    }
}
