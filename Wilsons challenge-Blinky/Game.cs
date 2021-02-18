using System;
using System.Collections.Generic;
using System.Text;

namespace Wilsons_challenge_Blinky
{
    class Game
    {
        Student[] students;

        public Game()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            students = new Student[] { student1, student2, student3 };
        }

        int current = 0;
        int randomNum = 0;


        private readonly Random ran = new Random();


        public void RandomNum(int _1, int _2)
        {
              randomNum = ran.Next(_1,_2);
        }

        public void Guess()
        {

            students[current].AddScore();

        }



        


    }
}
