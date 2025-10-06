using System;

namespace MyReal.AbstractFactory
{
    // Thuốc trừ sâu tổng hợp (dùng cho mô hình hóa học)
    class ProductB2 : AbstractProductB
    {
        public override string TenThuoc => "Thuốc trừ sâu tổng hợp AGU Synth";

        public override void SuDungCungPhanBon(AbstractProductA phanBon)
        {
            Console.WriteLine($"👉 {TenThuoc} được sử dụng kết hợp với {phanBon.TenPhanBon} (mô hình hóa học).");
        }
    }
}
