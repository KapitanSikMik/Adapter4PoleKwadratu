using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_1_obszar
{
    class Adapter : ITarget
    {
        private readonly Square _adaptee;

        public Adapter(Square adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetArea()
        {
            return $"This is square pole '{this._adaptee.SquareLenght * this._adaptee.SquareLenght}'";
        }
    }
}
