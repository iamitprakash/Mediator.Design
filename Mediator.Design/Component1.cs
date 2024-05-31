using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Design
{
    class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Will write in Master Database");

            this._mediator.Notify(this, "A");
        }

       
    }
}
