using System;

// 'ChemicalDatabank' là lớp Adaptee (API cũ/legacy)
// Nó cung cấp dữ liệu hóa chất nhưng với giao diện không khớp trực tiếp với Client
public class ChemicalDatabank
{
    // Lấy điểm tới hạn (Critical Point) của chất (nhiệt độ nóng chảy hoặc sôi)
    public float GetCriticalPoint(string compound, string point)
    {
        // "M" = Melting Point (nhiệt độ nóng chảy)
        if (point == "M")
        {
            switch (compound.ToLower())
            {
                case "water": return 0.0f;
                case "benzene": return 5.5f;
                case "ethanol": return -114.1f;
                default: return 0f;
            }
        }
        // Nếu không phải "M" → Boiling Point (nhiệt độ sôi)
        else
        {
            switch (compound.ToLower())
            {
                case "water": return 100.0f;
                case "benzene": return 80.1f;
                case "ethanol": return 78.3f;
                default: return 0f;
            }
        }
    }

    // Lấy công thức phân tử
    public string GetMolecularStructure(string compound)
    {
        switch (compound.ToLower())
        {
            case "water": return "H2O";
            case "benzene": return "C6H6";
            case "ethanol": return "C2H5OH";
            default: return "";
        }
    }

    // Lấy khối lượng phân tử
    public double GetMolecularWeight(string compound)
    {
        switch (compound.ToLower())
        {
            case "water": return 18.015;
            case "benzene": return 78.1134;
            case "ethanol": return 46.0688;
            default: return 0d;
        }
    }
}
