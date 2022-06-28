using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition3.entities.Enum
{
    enum OrderStatus : int
    {
        pending_payment = 0,
        processing=1,
        shiped =2,
        delivered  =3,
    }
}
