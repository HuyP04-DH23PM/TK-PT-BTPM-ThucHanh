using System;

namespace MyReal.Singleton
{
    /// <summary>
    /// Singleton lưu cấu hình ứng dụng thực tế (ví dụ: cấu hình cửa hàng nông dược).
    /// </summary>
    public sealed class AppConfig
    {
        // Thể hiện duy nhất (thread-safe, lazy)
        private static readonly Lazy<AppConfig> _instance =
            new Lazy<AppConfig>(() => new AppConfig());

        // Thuộc tính truy cập Singleton
        public static AppConfig Instance => _instance.Value;

        // Constructor để private → ngăn tạo từ bên ngoài
        private AppConfig()
        {
            // Trong thực tế, phần này có thể đọc từ file .json hoặc DB
            StoreName = "Cửa hàng Nông Dược AGU";
            Address = "Khu A, Đại học An Giang";
            TaxRate = 0.08m;
            ConnectionString = "Server=.;Database=AgroStore;Trusted_Connection=True;";
        }

        // Các thuộc tính cấu hình dùng chung toàn hệ thống
        public string StoreName { get; }
        public string Address { get; }
        public decimal TaxRate { get; }
        public string ConnectionString { get; }
    }
}
