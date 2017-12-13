using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Mẫu hạng ruồi
/// </summary>
namespace Flyweight
{
    public class Student
    {
        private int score;
        private int id;
        private string name;
        private double averageScore;
        public Student(double averageScore)
        {
            this.averageScore = averageScore;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }
        public void setScore(int score)
        {
            this.score = score;
        }

        public int getScore()
        {
            return this.score;
        }

        public double getStanding()
        {
            return (((double)this.score) / this.averageScore - 1.0) * 100.00;
        }
    }


    /// <summary>
    /// multi thread
    /// </summary>
    public class StudentThread
    {
        private int score;
        private int id;
        private string name;
        private double averageScore;
        private static StudentThread studentThread = new StudentThread();
        public StudentThread()
        {

        }
        public void setAverageScore(double averageScore)
        {
            this.averageScore = averageScore;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }
        public void setScore(int score)
        {
            this.score = score;
        }

        public int getScore()
        {
            return this.score;
        }

        public double getStanding()
        {
            return (((double)this.score) / this.averageScore - 1.0) * 100.00;
        }

        public static StudentThread getInstance()
        {
            return studentThread;
        }
        public static StudentThread getInstance(double average)
        {
            studentThread.setAverageScore(average);
            return studentThread;
        }
    }
}
