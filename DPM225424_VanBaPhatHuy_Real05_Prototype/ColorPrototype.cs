// 'ColorPrototype' là lớp trừu tượng (Prototype)
// Nó định nghĩa giao diện chung cho việc clone (nhân bản) đối tượng
public abstract class ColorPrototype
{
    // Phương thức trừu tượng Clone
    // Các lớp con (ConcretePrototype như Color) sẽ override để hiện thực cách clone
    public abstract ColorPrototype Clone();
}
