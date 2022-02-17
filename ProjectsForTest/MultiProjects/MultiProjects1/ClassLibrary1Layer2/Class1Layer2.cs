using ClassLibrary1Layer3;
using ClassLibrary2Layer3;

namespace ClassLibrary1Layer2
{
    public class Class1Layer2
    {
        public static void CallClass1Layer3()
        {
            Class1Layer3.Hello();
        }

        public static void CallClass2Layer3()
        {
            Class2Layer3.Hello();
        }
    }
}