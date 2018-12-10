using MazeGameLab1.Globals;

namespace MazeGameLab1.State
{
    public class StateController
    {
        private MonsterState current;
        private readonly Monster _monster;

        public StateController(Monster m)
        {
            this._monster = m;
        }

        public void SetState(MonsterState state)
        {
            this.current = state;
        }

        public void ChangeState()
        {
            this.current.GoNext(this._monster);
        }
    }
}
