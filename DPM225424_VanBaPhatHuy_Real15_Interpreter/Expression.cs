
/// <summary>
/// Lớp trừu tượng Expression – khuôn mẫu chung cho từng bậc (nghìn/trăm/chục/đơn vị)
/// Mỗi bậc định nghĩa bộ ký hiệu One/Four/Five/Nine và hệ số nhân (Multiplier)
/// </summary>
public abstract class Expression
{
    // Thuật toán diễn giải cho một bậc:
    // - Ưu tiên nhận dạng 9x, 4x, 5x, rồi đến nhiều lần 1x ở đầu chuỗi Input
    public void Interpret(Context context)
    {
        if (context.Input.Length == 0)
            return;

        if (context.Input.StartsWith(Nine()))
        {
            context.Output += (9 * Multiplier());
            context.Input = context.Input.Substring(2);
        }
        else if (context.Input.StartsWith(Four()))
        {
            context.Output += (4 * Multiplier());
            context.Input = context.Input.Substring(2);
        }
        else if (context.Input.StartsWith(Five()))
        {
            context.Output += (5 * Multiplier());
            context.Input = context.Input.Substring(1);
        }

        // Ghép nhiều lần "One" (ví dụ: XXX, III)
        while (context.Input.StartsWith(One()))
        {
            context.Output += (1 * Multiplier());
            context.Input = context.Input.Substring(1);
        }
    }

    // Ký hiệu 1x (M/C/X/I)
    public abstract string One();

    // Ký hiệu 4x (—/CD/XL/IV)
    public abstract string Four();

    // Ký hiệu 5x (—/D/L/V)
    public abstract string Five();

    // Ký hiệu 9x (—/CM/XC/IX)
    public abstract string Nine();

    // Hệ số nhân cho bậc tương ứng (1000/100/10/1)
    public abstract int Multiplier();
}
