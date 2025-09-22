
using System.Text;

/// <summary>
/// Lớp Invoker (User) – lưu trữ lệnh, quản lý Undo/Redo
/// </summary>
public class User
{
    // Máy tính thực hiện tính toán
    Calculator calculator = new Calculator();

    // Danh sách lệnh đã thực hiện
    List<Command> commands = new List<Command>();

    // Con trỏ vị trí hiện tại trong danh sách lệnh (để undo/redo)
    int current = 0;

    // Thực hiện Redo n cấp
    public void Redo(int levels)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("\n---- Làm lại (Redo) {0} bước ", levels);
        // Thực hiện lại các lệnh
        for (int i = 0; i < levels; i++)
        {
            if (current < commands.Count - 1)
            {
                Command command = commands[current++];
                command.Execute();
            }
        }
    }

    // Thực hiện Undo n cấp
    public void Undo(int levels)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("\n---- Hoàn tác (Undo) {0} bước ", levels);
        // Hoàn tác các lệnh
        for (int i = 0; i < levels; i++)
        {
            if (current > 0)
            {
                Command command = commands[--current] as Command;
                command.UnExecute();
            }
        }
    }

    // Thực hiện một lệnh tính toán mới
    public void Compute(char @operator, int operand)
    {
        // Tạo lệnh và thực thi nó
        Command command = new CalculatorCommand(calculator, @operator, operand);
        command.Execute();

        // Thêm lệnh vào danh sách để có thể Undo/Redo
        commands.Add(command);
        current++;
    }
}
