using System;

namespace WcfServiceLibraryTP1
{
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int WebAdd(int x, int y)
        {
            return x + y;
        }
        public int WebSoustraction(int x, int y)
        {
            return x - y;
        }
        public int WebMultiply(int x, int y)
        {
            return x * y;
        }
        public int WebDivision(int x, int y)
        {
            return x / y;
        }
    }
}
