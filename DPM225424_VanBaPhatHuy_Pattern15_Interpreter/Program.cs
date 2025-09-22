using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Interpreter (Trình thông dịch) – minh họa cấu trúc cơ bản
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo ngữ cảnh (Context) cho quá trình diễn giải
        Context context = new Context();

        // Thông thường, các biểu thức được tổ chức thành một cây cú pháp (syntax tree)
        List<AbstractExpression> list = new List<AbstractExpression>();

        // Tạo "cây cú pháp trừu tượng" (abstract syntax tree) bằng cách thêm các biểu thức
        list.Add(new TerminalExpression());
        list.Add(new NonterminalExpression());
        list.Add(new TerminalExpression());
        list.Add(new TerminalExpression());

        // Thực hiện diễn giải (Interpret) từng biểu thức trong cây
        foreach (AbstractExpression exp in list)
        {
            exp.Interpret(context);
        }

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
