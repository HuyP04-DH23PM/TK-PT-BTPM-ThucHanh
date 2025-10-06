using System;
using System.Text;

/// <summary>
/// Interpreter Pattern – MyReal: diễn giải luật khuyến nghị xử lý ruộng
/// Luật ví dụ: (DOAM>60 AND SAU_BENH) OR (MUA=HETHU AND DOAM>50)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var context = new Context
        {
            DoAmPhanTram = 65,
            CoSauBenh = true,
            MuaVu = "HETHU"
        };

        // Xây cây biểu thức: (DOAM>60 AND SAU_BENH) OR (MUA=HETHU AND DOAM>50)
        AbstractExpression expr =
            new NonterminalExpression(
                new NonterminalExpression(
                    new TerminalExpression("DOAM>60"), "AND", new TerminalExpression("SAU_BENH")
                ),
                "OR",
                new NonterminalExpression(
                    new TerminalExpression("MUA=HETHU"), "AND", new TerminalExpression("DOAM>50")
                )
            );

        Console.WriteLine("🌿 DIỄN GIẢI LUẬT KHUYẾN NGHỊ:");
        expr.Interpret(context);

        bool ketQua = context.Pop();
        Console.WriteLine($"\nKẾT LUẬN: {(ketQua ? "✅ NÊN áp dụng gói hữu cơ + phun sinh học" : "⏸ CHƯA cần can thiệp")}");

        Console.ReadKey();
    }
}
