namespace MazeGameLab1.Globals
{
    public class HardcodeFTW
    {
        public HardcodeFTW(ref int[][] Maze)
        {
            /*
             * 1 => Wall, can't walk there
             * 0 => Walkable space
             * 2 => Players current position
             * 3 => Win place
             * 4 => Takes damage there
             * 5 => Key for unlocking the door
             * 6 => Door
            */

            #region First row
            Maze[0][0] = 1;
            Maze[0][1] = 1;
            Maze[0][2] = 1;
            Maze[0][3] = 1;
            Maze[0][4] = 1;
            Maze[0][5] = 1;
            Maze[0][6] = 1;
            Maze[0][7] = 1;
            Maze[0][8] = 1;
            Maze[0][9] = 1;
            #endregion

            #region Second row
            Maze[1][0] = 1;
            Maze[1][1] = 5;
            Maze[1][2] = 0;
            Maze[1][3] = 0;
            Maze[1][4] = 0;
            Maze[1][5] = 0;
            Maze[1][6] = 0;
            Maze[1][7] = 0;
            Maze[1][8] = 0;
            Maze[1][9] = 1;
            #endregion

            #region Third row
            Maze[2][0] = 1;
            Maze[2][1] = 1;
            Maze[2][2] = 1;
            Maze[2][3] = 1;
            Maze[2][4] = 1;
            Maze[2][5] = 1;
            Maze[2][6] = 0;
            Maze[2][7] = 1;
            Maze[2][8] = 0;
            Maze[2][9] = 1;
            #endregion

            #region Forth row
            Maze[3][0] = 1;
            Maze[3][1] = 0;
            Maze[3][2] = 0;
            Maze[3][3] = 1;
            Maze[3][4] = 6;
            Maze[3][5] = 0;
            Maze[3][6] = 0;
            Maze[3][7] = 1;
            Maze[3][8] = 0;
            Maze[3][9] = 1;
            #endregion

            #region Fith row
            Maze[4][0] = 1;
            Maze[4][1] = 0;
            Maze[4][2] = 1;
            Maze[4][3] = 1;
            Maze[4][4] = 0;
            Maze[4][5] = 1;
            Maze[4][6] = 0;
            Maze[4][7] = 1;
            Maze[4][8] = 0;
            Maze[4][9] = 1;
            #endregion

            #region Sixth row
            Maze[5][0] = 1;
            Maze[5][1] = 0;
            Maze[5][2] = 1;
            Maze[5][3] = 1;
            Maze[5][4] = 3;
            Maze[5][5] = 1;
            Maze[5][6] = 0;
            Maze[5][7] = 1;
            Maze[5][8] = 0;
            Maze[5][9] = 1;
            #endregion

            #region Seventh row
            Maze[6][0] = 1;
            Maze[6][1] = 0;
            Maze[6][2] = 0;
            Maze[6][3] = 1;
            Maze[6][4] = 1;
            Maze[6][5] = 1;
            Maze[6][6] = 0;
            Maze[6][7] = 1;
            Maze[6][8] = 0;
            Maze[6][9] = 1;
            #endregion

            #region Eigth row
            Maze[7][0] = 1;
            Maze[7][1] = 0;
            Maze[7][2] = 1;
            Maze[7][3] = 1;
            Maze[7][4] = 1;
            Maze[7][5] = 1;
            Maze[7][6] = 0;
            Maze[7][7] = 0;
            Maze[7][8] = 0;
            Maze[7][9] = 1;
            #endregion

            #region Ninth row
            Maze[8][0] = 1;
            Maze[8][1] = 0;
            Maze[8][2] = 0;
            Maze[8][3] = 0;
            Maze[8][4] = 0;
            Maze[8][5] = 0;
            Maze[8][6] = 4;
            Maze[8][7] = 1;
            Maze[8][8] = 1;
            Maze[8][9] = 1;
            #endregion

            #region Tenth row
            Maze[9][0] = 1;
            Maze[9][1] = 1;
            Maze[9][2] = 1;
            Maze[9][3] = 1;
            Maze[9][4] = 1;
            Maze[9][5] = 1;
            Maze[9][6] = 2;
            Maze[9][7] = 1;
            Maze[9][8] = 1;
            Maze[9][9] = 1;
            #endregion
        }
    }
}
