using System;

// 'RichCompound' là lớp Adapter
// Nó kế thừa từ Compound (Target) và sử dụng ChemicalDatabank (Adaptee)
// để cung cấp dữ liệu thật cho các thuộc tính hóa chất
public class RichCompound : Compound
{
    private string chemical;           // Tên hợp chất (ví dụ: Water, Benzene, Ethanol)
    private ChemicalDatabank bank;     // Adaptee: nguồn dữ liệu hóa chất

    // Constructor: nhận vào tên hợp chất
    public RichCompound(string chemical)
    {
        this.chemical = chemical;
    }

    // Ghi đè phương thức Display để hiển thị thông tin chi tiết
    public override void Display()
    {
        // Tạo đối tượng Adaptee
        bank = new ChemicalDatabank();

        // Lấy dữ liệu từ ChemicalDatabank
        boilingPoint = bank.GetCriticalPoint(chemical, "B");
        meltingPoint = bank.GetCriticalPoint(chemical, "M");
        molecularWeight = bank.GetMolecularWeight(chemical);
        molecularFormula = bank.GetMolecularStructure(chemical);

        // Hiển thị dữ liệu đã được "thích nghi"
        Console.WriteLine("\nCompound: {0} ------ ", chemical);
        Console.WriteLine(" Formula     : {0}", molecularFormula);
        Console.WriteLine(" Weight      : {0}", molecularWeight);
        Console.WriteLine(" Melting Pt  : {0}", meltingPoint);
        Console.WriteLine(" Boiling Pt  : {0}", boilingPoint);
    }
}
