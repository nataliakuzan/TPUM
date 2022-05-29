using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerPresentation
{
    interface EndPoint
    {
        string ListAll();

        string ListAllByFilter(string Filter);

        string Create();
    }
}
