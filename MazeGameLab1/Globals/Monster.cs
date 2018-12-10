using System;
using System.Collections.Generic;
using System.Globalization;
using MazeGameLab1.AbstractFactory;
using MazeGameLab1.Strategy;
using MazeGameLab1.State;

namespace MazeGameLab1.Globals
{
    public class Monster
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int DistanceToPlayer { get; set; }
        public int Damage { get; set; }
        public int DropAmount { get; set; }
        public bool IsDead { get; set; }

        private MovementAlgorithm MoveAlgo;

        readonly BasicAttackFactory BFa;
        readonly SpecialAttackFactory SFa;
        private readonly StateController _stateController;
        
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

            this._stateController = new StateController(this);
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
            switch (Type.ToLower(CultureInfo.CurrentCulture))
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

        public static void HitPlayer()
        {
            
        }

        public static void Die()
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
                if (att.Name.ToLower(CultureInfo.CurrentCulture).Equals(Type.ToLower(CultureInfo.CurrentCulture), StringComparison.CurrentCulture))
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
                if (att.Name.ToLower(CultureInfo.CurrentCulture).Equals(Type.ToLower(CultureInfo.CurrentCulture), StringComparison.CurrentCulture))
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
