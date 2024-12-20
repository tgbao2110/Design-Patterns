public class MainDirect {
    public static void main(String[] args) {

        Shape shape;
        var shapeType = args[0];
        if (shapeType.equals("Circle")) {
            shape = new Circle();
        } else {
            shape = new Square();
        }

        shape.draw();
    }
}
