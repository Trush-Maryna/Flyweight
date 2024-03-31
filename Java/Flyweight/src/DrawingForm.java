import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class DrawingForm extends JFrame {
    private final int WIDTH = 818;
    private final int HEIGHT = 395;
    private static final ShapeType[] shapes = {ShapeType.LINE, ShapeType.OVAL_FILL, ShapeType.OVAL_NOFILL};
    private static final Color[] colors = {Color.RED, Color.GREEN, Color.ORANGE};
    private final Random rand = new Random();
    private boolean stopRequested = false;
    private boolean isDrawing = false;
    private final List<IShape> shapeList = new ArrayList<>();
    public static DrawingForm Instance;

    private final JPanel pictrBox;
    private final JTextField textBoxOutput;
    private final Timer drawTimer;

    public DrawingForm() {
        setTitle("Drawing Form");
        setLayout(new BorderLayout());
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        pictrBox = new JPanel() {
            @Override
            protected void paintComponent(Graphics g) {
                super.paintComponent(g);
                if (stopRequested || shapeList.size() >= 20) {
                    clearMessage();
                    isDrawing = false;
                    return;
                }

                for (IShape shape : shapeList) {
                    shape.draw(g);
                }
            }
        };

        JButton btnStart = new JButton("Start");
        JButton btnStop = new JButton("Stop");
        btnStart.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (!isDrawing) {
                    stopRequested = false;
                    shapeList.clear();
                    isDrawing = true;
                    drawTimer.start();
                }
            }
        });
        btnStop.addActionListener(e -> stopRequested = true);

        textBoxOutput = new JTextField();
        drawTimer = new Timer(2000, e -> {
            if (!stopRequested && shapeList.size() < 20) {
                IShape shape = ShapeFactory.getShape(getRandomShape(), getRandomColor(), getRandomX(), getRandomY(), getRandomWidth(), getRandomHeight());
                shapeList.add(shape);
                pictrBox.repaint();
            }
        });

        JPanel controlsPanel = new JPanel();
        controlsPanel.add(btnStart);
        controlsPanel.add(btnStop);

        add(pictrBox, BorderLayout.CENTER);
        add(textBoxOutput, BorderLayout.SOUTH);
        add(controlsPanel, BorderLayout.NORTH);

        Instance = this;
    }

    public void clearMessage() {
        textBoxOutput.setText("");
    }

    public void showMessage(String message) {
        textBoxOutput.setText(textBoxOutput.getText() + message);
    }

    private ShapeType getRandomShape() {
        return shapes[rand.nextInt(shapes.length)];
    }

    private Color getRandomColor() {
        return colors[rand.nextInt(colors.length)];
    }

    private int getRandomX() {
        return rand.nextInt(WIDTH);
    }

    private int getRandomY() {
        return rand.nextInt(HEIGHT);
    }

    private int getRandomWidth() {
        return rand.nextInt(WIDTH / 10);
    }

    private int getRandomHeight() {
        return rand.nextInt(HEIGHT / 10);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new DrawingForm().setVisible(true));
    }
}