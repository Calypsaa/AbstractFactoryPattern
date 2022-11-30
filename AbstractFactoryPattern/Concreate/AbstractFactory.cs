using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class AbstractFactory : IAbstractFactory
    {
        public InterFace CreateClassA()
        {
            return new ClassA();
        }

        public InterFace CreateClassB()
        {
            return new ClassB();
        }

        public InterFace CreateClassC()
        {
            return new ClassC();
        }
    }
}
