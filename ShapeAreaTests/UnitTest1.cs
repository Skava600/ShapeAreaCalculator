namespace AreaShapeTests
{
        public class TriangleTests
        {
            [Fact]
            public void TestIsTriangleExists()
            {
                Assert.True(Triangle.IsTriangleExists(3, 4, 5));
                Assert.True(Triangle.IsTriangleExists(2, 2, 2)); 
                Assert.False(Triangle.IsTriangleExists(1, 2, 4)); 
            }

            [Fact]
            public void TestConstructor()
            {
                var triangle = new Triangle(3, 4, 5, "Triangle1");
                Assert.Equal("Triangle1", triangle.Name);
                Assert.Equal(3, triangle.A);
                Assert.Equal(4, triangle.B);
                Assert.Equal(5, triangle.C);

                Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 4, "Triangle2"));
            }

            [Fact]
            public void TestSemiperimeter()
            {
                var triangle = new Triangle(3, 4, 5, "Triangle1");
                Assert.Equal(6, triangle.semiperimeter);
            }

            [Fact]
            public void TestIsRightTriangle()
            {
                var triangle1 = new Triangle(3, 4, 5, "Triangle1");
                var triangle2 = new Triangle(5, 12, 13, "Triangle2");
                var triangle3 = new Triangle(2, 2, 2, "Triangle3");
                Assert.True(triangle1.IsRightTriangle());
                Assert.True(triangle2.IsRightTriangle());
                Assert.False(triangle3.IsRightTriangle());
            }

            [Fact]
            public void TestGetArea()
            {
                var triangle1 = new Triangle(3, 4, 5, "Triangle1");
                var triangle2 = new Triangle(5, 12, 13, "Triangle2");
                var triangle3 = new Triangle(2, 2, 2, "Triangle3");
                Assert.Equal(6, triangle1.GetArea(), 0.001);
                Assert.Equal(30, triangle2.GetArea(), 0.001);
                Assert.Equal(Math.Sqrt(3), triangle3.GetArea(), 0.001);
            }
        }

    public class CircleTests
    {
        [Fact]
        public void TestValidCircle()
        {
            Circle c = new Circle(5, "TestCircle");
            Assert.Equal(Math.PI * 25, c.GetArea());
        }

        [Fact]
        public void TestNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-2, "TestCircle"));
        }
    }

}