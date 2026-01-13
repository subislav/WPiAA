namespace Flyweight
{
    public class GameUnit
    {
        private int _x;
        private int _y;
        private string _name;
        private SharedTexture _texture;
        public GameUnit(string name, int x, int y, SharedTexture texture)
        {
            _name = name;
            _x = x;
            _y = y;
            _texture = texture;
        }
        public void Draw()
        {
            Console.Write($"Obiekt '{_name}': ");
            _texture.Render(_x, _y);
        }
    }
}