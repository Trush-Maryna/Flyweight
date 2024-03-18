namespace Flyweight
{
    internal class Oval : IShape
    {
        private readonly bool fill;

        public Oval(bool f)
        {
            fill = f;
        }

        public void Draw(Graphics g, int x, int y, int width, int height, Color color, TextBox outputTextBox, IShape shape)
        {
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ClearMessage())); 
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ShowMessage("Creating " + shape.GetType().Name + "..."))); 
            Thread.Sleep(2000);

            if (fill)
                g.FillEllipse(new SolidBrush(color), x, y, width, height);
            else
                g.DrawEllipse(new Pen(color), x, y, width, height);
        }
    }
}
