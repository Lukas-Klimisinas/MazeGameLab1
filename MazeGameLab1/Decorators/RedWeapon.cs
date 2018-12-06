namespace MazeGameLab1.Decorators
{
    public class RedWeapon : Decorator
    {
        private readonly ISkin _skin;
        public RedWeapon(ISkin skin) : base(skin)
        {
            this._skin = skin;
        }
        public string Draw() => "red weapon " + this._skin.draw();
    }
}
