namespace Flyweight
{
    public interface IShape
    {
        void Draw(Graphics g, int x, int y, int width, int height, Color color, TextBox outputTextBox);
    }
}
