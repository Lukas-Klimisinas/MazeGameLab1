using System;
using System.Collections.Generic;
using MazeGameLab1.AbstractFactory;
using MazeGameLab1.Decorator;
using MazeGameLab1.Strategy;

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

        private MovementAlgorithm MoveAlgo;

        readonly BasicAttackFactory BFa;
        readonly SpecialAttackFactory SFa;
        
        List<BasicAttack> BasicAtt;
        List<SpecialAttack> SpecialAtt;

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

            BasicAtt = new List<BasicAttack>();
            SpecialAtt = new List<SpecialAttack>();
            BFa = new BasicAttackFactory();
            SFa = new SpecialAttackFactory();
            MoveAlgo = new RandDef();
        }

        public void Move()
        {
            if(MoveAlgo != null)
            {
                MoveAlgo.Move();
            }
        }

        public void ChangeAlgorithm(string Type)
        {
            switch (Type.ToLower())
            {
                case "fast":
                    MoveAlgo = new Fast();
                    break;

                case "chasing":
                    MoveAlgo = new Chasing();
                    break;

                case "slow":
                    MoveAlgo = new Slow();
                    break;

                case "default":
                    MoveAlgo = new RandDef();
                    break;
                
                default:
                    MoveAlgo = new RandDef();
                    break;
            }
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

        public void AddBasicAttack(string Type)
        {
            //Check to allow only one type of unique basic attack to be added
            foreach (BasicAttack att in BasicAtt)
            {
                if (att.Name.ToLower().Equals(Type.ToLower()))
                    return;
            }
            
            var newAtt = BFa.CreateBasicAttack(Type);

            if(newAtt != null)
                BasicAtt.Add(newAtt);
        }

        public void AddSpecialAttack(string Type)
        {
            //Check to allow only one type of unique special attack to be added
            foreach (SpecialAttack att in SpecialAtt)
            {
                if (att.Name.ToLower().Equals(Type.ToLower()))
                    return;
            }

            var newAtt = SFa.CreateSpecialAttack(Type);

            if (newAtt != null)
                SpecialAtt.Add(newAtt);
        }

        public void Talk()
        {
            Console.WriteLine("Type: {0} ({9})\n" +
                "PosX: {1}\n" +
                "PosY: {2}\n" +
                "Health: {3}\n" +
                "Speed: {4}\n" +
                "Distance To Player: {5}\n" +
                "Damage: {6}\n" +
                "Drop Amount: {7}\n" +
                "Is Dead: {8}\n", GetType(), PositionX, PositionY, Health, Speed, DistanceToPlayer, Damage, DropAmount, IsDead, GetType().GetHashCode());

            if(BasicAtt.Count > 0)
            {
                Console.WriteLine("I have these basic attacks:");

                foreach(BasicAttack att in BasicAtt)
                {   
                    Console.Write(att.ToString() + $" ({att.GetHashCode()}) ");
                }

                Console.WriteLine();
            }

            if (SpecialAtt.Count > 0)
            {
                Console.WriteLine("I have these special attacks:");

                foreach (SpecialAttack att in SpecialAtt)
                {
                    Console.Write(att.ToString() + $" ({att.GetHashCode()}) ");
                }

                Console.WriteLine();
            }
        }
    }
}
