using System;

namespace MyReal.AbstractFactory
{
    // Thuốc sinh học (dùng cho mô hình hữu cơ)
    class ProductB1 : AbstractProductB
    {
        public override string TenThuoc => "Thuốc sinh học AGU Bio";

        public override void SuDungCungPhanBon(AbstractProductA phanBon)
        {
            Console.WriteLine($"👉 {TenThuoc} được sử dụng kết hợp với {phanBon.TenPhanBon} (mô hình hữu cơ).");
        }
    }
}
