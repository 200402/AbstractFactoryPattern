using MyLib;

namespace AbstractProductB
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private AbstractFactory myClass;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myClass = new ConcreteFactory1();
            doWork();
        }

        void doWork()
        {
            label1.Text = myClass.CreateProductA();
            label1.BackColor = myClass.CreateProductB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myClass = new ConcreteFactory2();
            doWork();
        }
    }
}