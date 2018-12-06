namespace MazeGameLab1.Decorators
{
    public class BlueWeapon : Decorator
    {
        private readonly ISkin _skin;

        public BlueWeapon(ISkin skin) : base(skin)
        {
            this._skin = skin;
        }

        public string Draw()
        {
            return "blue weapon " + this._skin.draw();
        }
    }
}
