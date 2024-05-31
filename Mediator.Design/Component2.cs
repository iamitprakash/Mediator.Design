using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Design
{
    class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Will Read from Read Replica.");

            this._mediator.Notify(this, "C");
        }

       
    }
}
