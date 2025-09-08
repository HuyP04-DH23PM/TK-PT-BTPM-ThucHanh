    public class Singleton
    {
        // Biến static giữ thể hiện duy nhất của Singleton
        static Singleton instance;

        // Constructor để ở mức protected 
        // → ngăn không cho tạo đối tượng trực tiếp từ bên ngoài bằng từ khóa new
        protected Singleton()
        {
        }

        // Phương thức tĩnh để lấy ra thể hiện duy nhất của Singleton
        public static Singleton Instance()
        {
            // Sử dụng "lazy initialization" (khởi tạo khi cần dùng)
            // Lưu ý: cách này KHÔNG an toàn với đa luồng (multi-thread)
            if (instance == null) // Nếu chưa có instance
            {
                instance = new Singleton(); // Thì khởi tạo mới 1 lần
            }

            // Luôn trả về cùng một instance (dù gọi bao nhiêu lần)
            return instance;
        }
    }
