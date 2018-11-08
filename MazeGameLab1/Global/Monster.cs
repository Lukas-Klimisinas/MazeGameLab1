using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGameLab1.Global
{
    class Monster
    {
        int PositionX;
        int PositionY;
        int Health;
        int Speed;
        int DistanceToPlayer;
        int Damage;
        int DropAmount;
        bool IsDead;

        public Monster(int posx, int posy, int h, int s, int dist, int dam, int dr, bool isd)
        {
            PositionX = posx;
            PositionY = posy;
            Health = h;
            Speed = s;
            DistanceToPlayer = dist;
            Damage = dam;
            DropAmount = dr;
            IsDead = isd;
        }

        public void Move()
        {

        }

        public void ChangeAlgorithm()
        {

        }

        public void HitPlayer()
        {
            
        }

        public void Die()
        {

        }

        public void ReduceHealth(int Dmg)
        {
            Health -= Dmg;
        }

        public void Talk()
        {
            Console.WriteLine("Type: {0}\n" +
                "PosX: {1}\n" +
                "PosY: {2}\n" +
                "Health: {3}\n" +
                "Speed: {4}\n" +
                "Distance To Player: {5}\n" +
                "Damage: {6}\n" +
                "Drop Amount: {7}\n" +
                "Is Dead: {8}\n", GetType(), PositionX, PositionY, Health, Speed, DistanceToPlayer, Damage, DropAmount, IsDead);
        }
    }
}
