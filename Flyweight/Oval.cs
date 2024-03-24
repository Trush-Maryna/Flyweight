namespace Flyweight
{
    internal class Oval : IShape
    {
        private readonly int x;
        private readonly int y;
        private readonly int width;
        private readonly int height;
        private readonly Color color;
        private readonly bool fill;

        public Oval(int x, int y, int width, int height, Color color, bool fill)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            this.fill = fill;
        }

        public void Draw(Graphics g)
        {
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ClearMessage()));
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ShowMessage("Creating Oval...")));
            if (fill)
                g.FillEllipse(new SolidBrush(color), x, y, width, height);
            else
                g.DrawEllipse(new Pen(color), x, y, width, height);
        }
    }
}
