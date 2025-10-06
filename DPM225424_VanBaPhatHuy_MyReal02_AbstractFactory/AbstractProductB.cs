namespace MyReal.AbstractFactory
{
    // Thuốc trừ sâu trừu tượng
    abstract class AbstractProductB
    {
        public abstract string TenThuoc { get; }

        public abstract void SuDungCungPhanBon(AbstractProductA phanBon);
    }
}
