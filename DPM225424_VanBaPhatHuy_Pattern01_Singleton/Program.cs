   public class Program
    {
        public static void Main(string[] args)
        {
            // Constructor là protected nên không thể tạo đối tượng bằng từ khóa new
            Singleton s1 = Singleton.Instance(); // Gọi phương thức Instance() để lấy thể hiện (instance) duy nhất của Singleton
            Singleton s2 = Singleton.Instance(); // Lấy lại cùng một thể hiện (không tạo mới)

            // Kiểm tra xem 2 biến có trỏ tới cùng một đối tượng hay không
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
                // In ra thông báo xác nhận: cả s1 và s2 đều là cùng một instance Singleton
            }

            // Dừng màn hình console lại để chờ người dùng nhấn phím bất kỳ
            Console.ReadKey();
        }
    }

