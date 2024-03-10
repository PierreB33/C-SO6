using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD3;

namespace TD5_6
{
    internal interface IMoyenne<T>
    {
        double Moyenne(T collection);
    }
}
