using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        public string Name {get;}

        public float WinRate
        {
            get
            {
                if( playedGames > 0)
                {
                    return wonGames % playedGames;
                } 
                else
                {
                    Erro1();
                }
                 
            }
        }

        private string Erro1()
        {
            return "Nenhum jogo ainda jogado";
        }

        public void PlayGame(bool win)
        {
            if (win == true)
            {
                wonGames++;
            }
        }


        public Player(string name)
        {
            Name = name;
        }

        public float HighScore
        {
            get
            {
                return highScore;
            }

            set
            {
                if (highScore < value)
                {
                    highScore = value;
                }
            }
        }
    }
}