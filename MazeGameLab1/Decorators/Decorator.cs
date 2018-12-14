namespace MazeGameLab1.Decorators
{
    public abstract class Decorator : ISkin
    {
        ISkin skin = null;

        public string draw() => "super view " + skin.draw();
        public Decorator(ISkin skin) => this.skin = skin;
    }

}
