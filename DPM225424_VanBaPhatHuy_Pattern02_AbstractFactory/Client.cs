class Client
{
    // Biến thành viên để lưu sản phẩm loại A và B
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;

    // Constructor nhận vào một "Factory" (nhà máy trừu tượng)
    // Từ factory này, client sẽ lấy ra sản phẩm A và B tương ứng
    public Client(AbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB(); // Tạo ProductB từ factory
        _abstractProductA = factory.CreateProductA(); // Tạo ProductA từ factory
    }

    // Hàm thực thi
    public void Run()
    {
        // Gọi phương thức Interact của ProductB, 
        // truyền vào ProductA để 2 sản phẩm "tương tác" với nhau
        _abstractProductB.Interact(_abstractProductA);
    }
}
