using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_MVVM.Models.Mappers
{
    internal interface IBaseMapper<Ta, Tb>
    {
        Ta BtoA(Tb b);
        Tb AtoB(Ta a);
    }
}
