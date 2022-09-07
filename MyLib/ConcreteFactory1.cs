namespace MyLib
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public string CreateProductA(string context)
        {
            return "Создан продукт а1";
        }

        public System.Drawing.Color CreateProductB()
        {
            return System.Drawing.Color.Green;
        }
    }
}