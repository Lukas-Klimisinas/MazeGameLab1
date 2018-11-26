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
        public void MoveToWinPlace()
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

            Assert.AreEqual(2, FinalRes, 0, $"Should be at winning place");
        }
    }
}