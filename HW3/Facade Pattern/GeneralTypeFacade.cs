using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class GeneralTypeFacade
    {
        private SpecificTypeA instanceA;
        private SpecificTypeB instanceB;
        private SpecificTypeC instanceC;

        public GeneralTypeFacade()
        {
            instanceA = new SpecificTypeA();
            instanceB = new SpecificTypeB();
            instanceC = new SpecificTypeC();
        }

        public void FunctionA()
        {
            instanceA.FunctionA();
            instanceB.FunctionA();
            instanceC.FunctionA();
        }

        public void FunctionB()
        {

            instanceA.FunctionB();
            instanceB.FunctionB();
            instanceC.FunctionB();
        }
    }
}
