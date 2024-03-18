namespace Flyweight
{
    public partial class DrawingForm : Form
    {
        private readonly int WIDTH = 818;
        private readonly int HEIGHT = 395;
        private static readonly ShapeType[] shapes = { ShapeType.LINE, ShapeType.OVAL_FILL, ShapeType.OVAL_NOFILL };
        private static readonly Color[] colors = { Color.Red, Color.Green, Color.Orange };
        private readonly List<IShape> shapeList = new List<IShape>();
        private readonly Random rand = new Random();
        public static DrawingForm Instance { get; private set; }

        public DrawingForm()
        {
            InitializeComponent();
            Instance = this;
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
            Graphics g = CreateGraphics();

            for (int i = 0; i < 20; ++i)
            {
                IShape shape = ShapeFactory.GetShape(GetRandomShape());
                shapeList.Add(shape);
                shape.Draw(g, GetRandomX(), GetRandomY(), GetRandomWidth(), GetRandomHeight(), GetRandomColor(), textBoxOutput);
            }
        }

        private ShapeType GetRandomShape()
        {
            return shapes[rand.Next(0, shapes.Length)];
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

        private Color GetRandomColor()
        {
            return colors[rand.Next(0, colors.Length)];
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (IShape shape in shapeList)
            {
                shape.Draw(e.Graphics, GetRandomX(), GetRandomY(), GetRandomWidth(), GetRandomHeight(), GetRandomColor(), textBoxOutput);
            }
        }
    }
}