namespace MyReal.AbstractFactory
{
    class Client
    {
        private readonly AbstractProductA _phanBon;
        private readonly AbstractProductB _thuoc;

        public Client(AbstractFactory factory)
        {
            _phanBon = factory.CreateProductA();
            _thuoc = factory.CreateProductB();
        }

        public void Run()
        {
            _thuoc.SuDungCungPhanBon(_phanBon);
        }
    }
}
