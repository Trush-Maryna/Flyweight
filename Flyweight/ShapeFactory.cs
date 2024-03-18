namespace Flyweight
{
    public static class ShapeFactory
    {
        private static readonly Dictionary<ShapeType, IShape> shapes = new Dictionary<ShapeType, IShape>();

        public static IShape GetShape(ShapeType type)
        {
            if (!shapes.ContainsKey(type))
            {
                if (type == ShapeType.OVAL_FILL)
                    shapes.Add(type, new Oval(true));
                else if (type == ShapeType.OVAL_NOFILL)
                    shapes.Add(type, new Oval(false));
                else if (type == ShapeType.LINE)
                    shapes.Add(type, new Line());
            }
            return shapes[type];
        }
    }
}
