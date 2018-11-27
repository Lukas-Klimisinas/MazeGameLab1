using System.Drawing;

namespace MazeGameLab1.Global
{
    public class UnitMaze
    {
        private int[][] Maze = new int[10][];
        private readonly int MazeWidth = 10;
        private readonly int MazeHeight = 10;

        public readonly int HealthTick = 10;

        private Point PlayerPosition = new Point(6, 9);
        private Point WinPlace = new Point(4, 5);

        public Player _player { get; set; }

        public UnitMaze()
        {
            for(int i = 0; i < 10; i++)
            {
                Maze[i] = new int[10];
            }

            HardcodeFTW FTW = new HardcodeFTW(ref Maze);

            this._player = new Player("knight", 100, true);
        }

        private Point CalculateMove(int Direction)
        {
            switch (Direction)
            {
                case 0: //Move UP
                    return new Point(this.PlayerPosition.X, this.PlayerPosition.Y - 1);

                case 1: //Move DOWN
                    return new Point(this.PlayerPosition.X, this.PlayerPosition.Y + 1);

                case 2: //Move LEFT
                    return new Point(this.PlayerPosition.X - 1, this.PlayerPosition.Y);

                case 3: //Move RIGHT
                    return new Point(this.PlayerPosition.X + 1, this.PlayerPosition.Y);

                default:
                    return new Point(-1, -1);
            }
        }

        private bool CheckWin()
        {
            if (this.PlayerPosition.X == this.WinPlace.X && this.PlayerPosition.Y == this.WinPlace.Y)
                return true;

            return false;
        }

        private bool ReduceHealth()
        {
            if(this.Maze[this.PlayerPosition.Y][this.PlayerPosition.X] == 4) 
                return true;
            
            return false;
        }

        /// <summary>
        /// Return: 1 if moved
        ///         -1 if cant move
        ///         2 if made move is winning one
        ///         3 moved and took the key
        /// </summary>
        public int Move(string Dir)
        {
            int DirId = -1;

            switch (Dir.ToLower())
            {
                case "up":
                    DirId = 0;
                    break;

                case "down":
                    DirId = 1;
                    break;

                case "left":
                    DirId = 2;
                    break;

                case "right":
                    DirId = 3;
                    break;

                default:
                    break;
            }

            Point NewPos = CalculateMove(DirId);

            if (NewPos.X == -1 && NewPos.Y == -1)
                return -1;

            if (NewPos.Y < 0 || NewPos.Y >= this.MazeHeight || NewPos.X < 0 || NewPos.X >= this.MazeWidth)
                return -1;

            if (this.Maze[NewPos.Y][NewPos.X] == 1) // If its a wall
                return -1;

            if (this.Maze[NewPos.Y][NewPos.X] == 6 && !this._player.HasDoorKey) // If it is door and player does not have a key
                return -1;

            this.PlayerPosition = NewPos;

            if (ReduceHealth())
                this._player.Health -= this.HealthTick;

            if (this.Maze[NewPos.Y][NewPos.X] == 5 && !this._player.HasDoorKey) // If player has found a key
            { 
                this._player.HasDoorKey = true;

                return 3;
            }

            if (CheckWin())
                return 2;

            return 1;
        }

    }
}
