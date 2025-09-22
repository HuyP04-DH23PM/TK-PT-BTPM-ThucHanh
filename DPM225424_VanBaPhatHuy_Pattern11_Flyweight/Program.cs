
    /// <summary>
    /// Mẫu thiết kế Flyweight
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Trạng thái ngoại sinh tùy ý

            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Làm việc với các đối tượng Flyweight khác nhau

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);

            // Chờ người dùng nhấn phím

            Console.ReadKey();
        }
    }
