namespace MyLib
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public string CreateProductA()
        {
            return "Создан продукт а2";
        }

        public System.Drawing.Color CreateProductB()
        {
            return System.Drawing.Color.Orange;
        }
    }
}