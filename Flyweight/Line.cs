namespace Flyweight
{
    internal class Line : IShape
    {
        public void Draw(Graphics g, int x1, int y1, int x2, int y2, Color color, TextBox outputTextBox)
        {
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ClearMessage()));
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ShowMessage("Creating Line...")));
            Thread.Sleep(2000);
            g.DrawLine(new Pen(color), x1, y1, x2, y2);
        }
    }
}
