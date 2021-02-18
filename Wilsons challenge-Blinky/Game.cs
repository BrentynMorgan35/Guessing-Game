using System;
using System.Collections.Generic;
using System.Text;

namespace Wilsons_challenge_Blinky
{
    class Game 
    {
        Student[] students;
        string guess1;
        string guess2;
        string guess3;

        public Game()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            students = new Student[3] { student1, student2, student3 };
        }
        public int randomNum = 0;


        private readonly Random ran = new Random();


        public void RandomNum(int _1, int _2)
        {
              randomNum = ran.Next(_1,_2);
        }

        public void Guess(int _1, int _2, int _3)
        {

            students[0].AddScore(_1);
            students[1].AddScore(_2);
            students[2].AddScore(_3);

        }
        public string[] GameEnd()
        {
            foreach(int x in students[0].scores)
            {
                guess1 += x + "\n";
            }
            foreach (int x in students[1].scores)
            {
                guess2 += x + "\n";
            }
            foreach (int x in students[2].scores)
            {
                guess3 += x + "\n";
            }



           

            string[] y = new string[] { guess1, guess2, guess3 };

            return y;
        }



        


    }
}