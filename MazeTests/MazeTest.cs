using NUnit.Framework;
using MazeGameLab1.Global;

namespace Tests
{
    //https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
    public class MazeTest
    {
        private UnitMaze _unitMaze;

        public MazeTest() { }

        [Test]
        [TestCase("down")]
        [TestCase("left")]
        [TestCase("right")]
        public void MoveFromStartPointFails(string Dir)
        {
            this._unitMaze = new UnitMaze();

            int Result = this._unitMaze.Move(Dir);

            Assert.AreEqual(-1, Result, 0, $"Direction {Dir} should fail");
        }

        [Test]
        public void MoveToWinPlaceFail()
        {
            this._unitMaze = new UnitMaze();

            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("down");

            int FinalRes = this._unitMaze.Move("down");

            Assert.AreEqual(-1, FinalRes, 0, "Should not be able to win because door is locked and player doesn't have a key");
        }

        [Test]
        public void PlayerTakesDamage()
        {
            this._unitMaze = new UnitMaze();

            int Tick = this._unitMaze.HealthTick;
            double Expected = this._unitMaze._player.Health - Tick;

            this._unitMaze.Move("up");

            Assert.AreEqual(Expected, this._unitMaze._player.Health, 0, $"Health should be reduced by {Tick}");
        }

        [Test]
        public void DieInPit()
        {
            this._unitMaze = new UnitMaze();

            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");


            int FinalRes = this._unitMaze.Move("right");

            Assert.AreEqual(6, FinalRes, 0, "Player should have died in a pit");
        }



        [Test]
        public void GetTheKey()
        {
            this._unitMaze = new UnitMaze();

            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");

            int FinalRes = this._unitMaze.Move("left");

            Assert.AreEqual(3, FinalRes, 0, "Player should have picked up the key");
        }

        [Test]
        public void CompleteMaze()
        {
            this._unitMaze = new UnitMaze();

            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("up");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("right");
            this._unitMaze.Move("right");
            this._unitMaze.Move("right");
            this._unitMaze.Move("right");
            this._unitMaze.Move("right");
            this._unitMaze.Move("down");
            this._unitMaze.Move("down");
            this._unitMaze.Move("left");
            this._unitMaze.Move("left");
            this._unitMaze.Move("down");

            int FinalRes = this._unitMaze.Move("down");

            Assert.AreEqual(2, FinalRes, 0, "Player should have completed the maze");
        }
    }
}