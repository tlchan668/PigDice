using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice {

    public class PigDiceGame {

        private Random rnd = new Random(DateTime.Now.Millisecond);

        public int RollTheDie() {
            //use random number generator
            //seed the random number generator

            return rnd.Next(1, 7);
        }     
    

        public int PigDice() {//do one game of pig dice and return score
            var score = 0;
            //similuate rolling one dice and be between 1-6
            var roll = RollTheDie();
            //first roll of the game if 1 game over if not continue
            while(roll != 1) {
                //keep rolling add roll to total
                score += roll;
                //roll again
                roll = RollTheDie();
            }
            return score;
        }
        //method to run and start the game
        public void Play() {
            var worldRecordScore = 300;
            var highScore = 0;
            var gamesToPlay = 1000;
            while (gamesToPlay > 0||highScore<worldRecordScore) {
                
                var score = PigDice();
                if (score > highScore) {
                    highScore = score;
                 
                }
                gamesToPlay--;
            }

            Console.WriteLine($"New ww score is {highScore}");
        }
        
    }
}
