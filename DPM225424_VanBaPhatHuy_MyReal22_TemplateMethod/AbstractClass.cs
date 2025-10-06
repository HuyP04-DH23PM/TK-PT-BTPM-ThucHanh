using System;

/// <summary>
/// 'AbstractClass' – MyReal:
/// Khuôn mẫu xử lý ĐƠN HÀNG nông dược. Lớp con cài đặt các bước cụ thể.
/// </summary>
public abstract class AbstractClass
{
    // Các bước nguyên thủy mà lớp con phải cài đặt
    public abstract void PrimitiveOperation1(); // Bước 1: xử lý nghiệp vụ đầu vào
    public abstract void PrimitiveOperation2(); // Bước 2: hoàn tất & thông báo

    // Khuôn mẫu cố định trình tự các bước
    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
        Console.WriteLine();
    }
}
