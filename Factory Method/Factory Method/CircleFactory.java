public class CircleFactory extends ShapeFactory {
    @Override
    public Shape createShape() {
        // Có thể thêm các bước xử lý phức tạp tại đây
        return new Circle();
    }
}