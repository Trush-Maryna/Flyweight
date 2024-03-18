namespace Flyweight
{
    public interface IShape
    {
        public void Draw(Graphics g, int x, int y, int width, int height, Color color, TextBox outputTextBox, IShape shape);
    }
}
