public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo ra một file cấu trúc

            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Tạo và xoá nút lá

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Hiển thị cây đệ quy

            root.Display(1);

            // Chờ đợi người dùng

            Console.ReadKey();
        }
    }
