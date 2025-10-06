using System;
using System.Collections.Generic;

/// <summary>
/// 'FlyweightFactory' (MyReal):
/// Quản lý và tái sử dụng các mẫu nhãn/gói sản phẩm dùng chung.
/// </summary>
public class FlyweightFactory
{
    private readonly Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

    public FlyweightFactory()
    {
        // Khởi tạo sẵn một số mẫu chia sẻ
        flyweights.Add("HUUCO", new ConcreteFlyweight("Phân bón hữu cơ AGU", "bao 25kg"));
        flyweights.Add("HOAHOC", new ConcreteFlyweight("Phân bón hoá học AGU", "bao 25kg"));
        flyweights.Add("SINHHOC", new ConcreteFlyweight("Thuốc sinh học AGU Bio", "chai 1L"));
    }

    public Flyweight GetFlyweight(string key)
    {
        if (!flyweights.TryGetValue(key, out var fw))
        {
            // Nếu chưa có, tạo tạm mẫu mặc định rồi cache lại (vẫn là shared)
            fw = new ConcreteFlyweight($"Mẫu mặc định ({key})", "đơn vị");
            flyweights[key] = fw;
        }
        return fw;
    }
}
