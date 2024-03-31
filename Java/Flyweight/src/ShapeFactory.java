import java.awt.*;

class ShapeFactory {
    public static IShape getShape(ShapeType type, Color color, int x, int y, int width, int height) {
        switch (type) {
            case LINE:
                return new Line(x, y, x + width, y + height, color);
            case OVAL_FILL:
                return new Oval(x, y, width, height, color, true);
            case OVAL_NOFILL:
                return new Oval(x, y, width, height, color, false);
            default:
                throw new IllegalArgumentException("Invalid shape type");
        }
    }
}