using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    abstract class AbstractClassForVariousFunction : AbstractBaseClassObject, IClassFunctions
    {
        public override void Func1()
        {
            throw new NotImplementedException();
        }

        public override void Func1(string text, int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Func1(int a)
        {
            throw new NotImplementedException();
        }

        public void Func1(string text, int a, int b, int c)
        {
            throw new NotImplementedException();
        }
    }
}
