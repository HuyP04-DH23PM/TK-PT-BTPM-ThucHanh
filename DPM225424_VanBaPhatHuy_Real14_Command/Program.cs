using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Command (Mệnh lệnh) – ví dụ thực tế với máy tính bỏ túi (có Undo/Redo)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo người dùng (User) và để người dùng thực hiện tính toán
        User user = new User();

        // Người dùng nhấn các phím máy tính
        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);

        // Hoàn tác (Undo) 4 lệnh
        user.Undo(4);

        // Làm lại (Redo) 3 lệnh
        user.Redo(3);

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
