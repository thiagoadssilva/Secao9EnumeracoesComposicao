using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTreino01.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPaymente = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    };
}
