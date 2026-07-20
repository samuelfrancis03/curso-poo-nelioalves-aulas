using System;
using System.Collections.Generic;
using System.Text;

namespace Enemuracao.Entities.Enums
{
    enum OrderStatus : int
    {
        /*Não é necessário informar o o numero, pois com apenas o nome o compilador já reconhece o 'id'*/
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
