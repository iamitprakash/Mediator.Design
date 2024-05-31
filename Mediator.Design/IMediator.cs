using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Design
{
    public interface IMediator
    {
        void Notify(Object sender, string ev);
    }
}
