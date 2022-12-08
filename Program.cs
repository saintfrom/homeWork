using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.fullName = Console.ReadLine();
            person.age = Convert.ToInt32(Console.ReadLine());
            person.email = Console.ReadLine();
            person.codePoint = Convert.ToDouble(Console.ReadLine());
            person.mathPoint = Convert.ToDouble(Console.ReadLine());
            person.phisPoint = Convert.ToDouble(Console.ReadLine());

            double score = person.codePoint + person.mathPoint + person.phisPoint;
            double averege = (person.codePoint + person.mathPoint + person.phisPoint) / 3;

            Console.WriteLine($"ФИО: {person.fullName}\n Возраст: {person.age}\n Балл по программированию: {person.codePoint}\n Балл по математике: {person.mathPoint}\n Балл по физике: {person.phisPoint}");
            Console.ReadKey();
            Console.WriteLine($"Сумма баллов: {score}\nСреднее арифмитическое: {averege}");

        }
    }
    class Person 
    {
        public string fullName;
        public int age;
        public string email;
        public double codePoint;
        public double mathPoint;
        public double phisPoint;
    }
}
