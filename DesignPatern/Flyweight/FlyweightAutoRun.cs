using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            string[] names = new string[] { "Facker", "Marin", "Bengi" };
            int[] ids = new int[] { 1, 2, 3 };
            int[] scores = new int[] {45, 55, 65 };
            int total = 0;
            foreach (var item in scores)
            {
                total += item;
            }
            double average = total / scores.Length;
            Student student = new Student(average);
            for (int i = 0; i < scores.Length; i++)
            {
                student.setId(ids[i]);
                student.setName(names[i]);
                student.setScore(scores[i]);
                System.Console.WriteLine("Name: " + student.getName());
                System.Console.WriteLine("Standing: " + Math.Round(student.getStanding()));
                System.Console.WriteLine("");
            }
            Console.ReadLine();

            ////multi thread
            StudentThread studentThread = StudentThread.getInstance(average);
            for (int i = 0; i < scores.Length; i++)
            {
                student.setId(ids[i]);
                student.setName(names[i]);
                student.setScore(scores[i]);
                System.Console.WriteLine("Name: " + student.getName());
                System.Console.WriteLine("Standing: " + Math.Round(student.getStanding()));
                System.Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
