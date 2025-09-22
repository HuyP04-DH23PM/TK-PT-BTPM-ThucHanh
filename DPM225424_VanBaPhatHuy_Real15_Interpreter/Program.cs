using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Interpreter (Trình thông dịch) – ví dụ thực tế: chuyển số La Mã thành số thập phân
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        string roman = "MCMXXVIII";            // Chuỗi số La Mã cần dịch
        Context context = new Context(roman);   // Ngữ cảnh: giữ Input/Output trong quá trình dịch

        // Xây dựng "cây phân tích cú pháp" (parse tree)
        List<Expression> tree = new List<Expression>();
        tree.Add(new ThousandExpression());     // Hàng nghìn: M
        tree.Add(new HundredExpression());      // Hàng trăm: C, CD, D, CM
        tree.Add(new TenExpression());          // Hàng chục: X, XL, L, XC
        tree.Add(new OneExpression());          // Hàng đơn vị: I, IV, V, IX

        // Diễn giải theo từng mức (nghìn → trăm → chục → đơn vị)
        foreach (Expression exp in tree)
        {
            exp.Interpret(context);
        }

        Console.WriteLine("{0} = {1}", roman, context.Output);

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
