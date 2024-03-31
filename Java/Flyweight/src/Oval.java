import java.awt.*;

class Oval implements IShape {
    private final int x;
    private final int y;
    private final int width;
    private final int height;
    private final Color color;
    private final boolean fill;

    public Oval(int x, int y, int width, int height, Color color, boolean fill) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.color = color;
        this.fill = fill;
    }

    @Override
    public void draw(Graphics g) {
        DrawingForm.Instance.clearMessage();
        DrawingForm.Instance.showMessage("Creating Oval...");
        g.setColor(color);
        if (fill)
            g.fillOval(x, y, width, height);
        else
            g.drawOval(x, y, width, height);
    }
}