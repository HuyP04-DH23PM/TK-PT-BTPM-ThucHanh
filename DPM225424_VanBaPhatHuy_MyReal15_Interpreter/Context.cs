using System;
using System.Collections.Generic;

/// <summary>
/// Context – chứa dữ liệu nông nghiệp thực tế + stack đánh giá
/// </summary>
public class Context
{
    // Dữ liệu thực tế (ví dụ)
    public int DoAmPhanTram { get; set; } = 65;        // %
    public bool CoSauBenh { get; set; } = true;         // có sâu bệnh?
    public string MuaVu { get; set; } = "HETHU";        // VỤ MÙA: HETHU, DONGXUAN,...

    private readonly Stack<bool> _stack = new Stack<bool>();

    public void Push(bool value) => _stack.Push(value);
    public bool Pop() => _stack.Pop();

    // Đánh giá 1 token đơn lẻ của DSL (DOAM>60, SAU_BENH, MUA=HETHU)
    public bool EvaluateToken(string token)
    {
        token = token.Trim().ToUpperInvariant();

        if (token.StartsWith("DOAM>="))
        {
            if (int.TryParse(token.Substring("DOAM>=".Length), out var n))
                return DoAmPhanTram >= n;
        }
        else if (token.StartsWith("DOAM>"))
        {
            if (int.TryParse(token.Substring("DOAM>".Length), out var n))
                return DoAmPhanTram > n;
        }
        else if (token.StartsWith("DOAM<="))
        {
            if (int.TryParse(token.Substring("DOAM<=".Length), out var n))
                return DoAmPhanTram <= n;
        }
        else if (token.StartsWith("DOAM<"))
        {
            if (int.TryParse(token.Substring("DOAM<".Length), out var n))
                return DoAmPhanTram < n;
        }
        else if (token == "SAU_BENH")
        {
            return CoSauBenh;
        }
        else if (token.StartsWith("MUA="))
        {
            var vu = token.Substring("MUA=".Length);
            return string.Equals(MuaVu, vu, StringComparison.OrdinalIgnoreCase);
        }

        // Không khớp quy ước → coi như false
        return false;
    }
}
