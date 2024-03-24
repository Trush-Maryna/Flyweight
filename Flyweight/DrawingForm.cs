namespace Flyweight
{
    public partial class DrawingForm : Form
    {
        private readonly int WIDTH = 818;
        private readonly int HEIGHT = 395;
        private static readonly ShapeType[] shapes = { ShapeType.LINE, ShapeType.OVAL_FILL, ShapeType.OVAL_NOFILL };
        private static readonly Color[] colors = { Color.Red, Color.Green, Color.Orange };
        private readonly Random rand = new Random();
        private bool stopRequested = false;
        private bool isDrawing = false;
        private List<IShape> shapeList = new List<IShape>();
        public static DrawingForm? Instance;

        public DrawingForm()
        {
            InitializeComponent();
            Instance = this;
            drawTimer.Interval = 2000;
        }

        public void ClearMessage()
        {
            textBoxOutput.Clear();
        }

        public void ShowMessage(string message)
        {
            textBoxOutput.AppendText(message);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!isDrawing)
            {
                stopRequested = false;
                shapeList.Clear();
                isDrawing = true;
                drawTimer.Start();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            stopRequested = true;
        }

        private ShapeType GetRandomShape()
        {
            return shapes[rand.Next(0, shapes.Length)];
        }

        private Color GetRandomColor()
        {
            return colors[rand.Next(0, colors.Length)];
        }

        private void pictrBox_Paint(object sender, PaintEventArgs e)
        {
            if (stopRequested || shapeList.Count >= 20)
            {
                ClearMessage();
                isDrawing = false;
                return;
            }

            Graphics g = e.Graphics;
            foreach (IShape shape in shapeList)
            {
                shape.Draw(g);
            }
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            if (!stopRequested && shapeList.Count < 20)
            {
                IShape shape = ShapeFactory.GetShape(GetRandomShape(), GetRandomColor(), GetRandomX(), GetRandomY(), GetRandomWidth(), GetRandomHeight());
                shapeList.Add(shape);
                pictrBox.Invalidate();
            }
        }

        private int GetRandomX()
        {
            return rand.Next(0, WIDTH);
        }

        private int GetRandomY()
        {
            return rand.Next(0, HEIGHT);
        }

        private int GetRandomWidth()
        {
            return rand.Next(0, WIDTH / 10);
        }

        private int GetRandomHeight()
        {
            return rand.Next(0, HEIGHT / 10);
        }
    }
}
