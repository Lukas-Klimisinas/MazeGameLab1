using System;
using System.Collections.Generic;

namespace MazeGameLab1.Global
{
    public class Maze
    {
        int Size;
        int PlayerCount;
        List<Player> Players;
        List<Monster> Monsters;

        public Maze()
        {

        }

        public void StartGame()
        {

        }

        public void FinishGame()
        {

        }

        public void QuitGame()
        {

        }

        public void Draw()
        {

        }

        public void SetPlayers(List<Player> Players)
        {
            this.Players = Players;
        }

        public void SetMonsters(List<Monster> Monsters)
        {
            this.Monsters = Monsters;
        }

        public void SetSize(int Size)
        {
            this.Size = Size;
        }

        public void SetPlayerCount(int PlayerCount)
        {
            this.PlayerCount = PlayerCount;
        }

        public void Talk()
        {
            Console.WriteLine("Type: {0}\n" +
                "Size: {1}\n" +
                "Player Count: {2}\n" +
                "Players: {3}\n" +
                "Monsters: {4}\n", GetType(), Size, PlayerCount, Players.Count, Monsters.Count);
        }
    }
}
