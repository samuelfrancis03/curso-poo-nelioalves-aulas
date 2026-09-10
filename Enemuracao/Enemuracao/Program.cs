
using Enemuracao.Entities;
using Enemuracao.Entities.Enums;

Order order = new Order {Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };

Console.WriteLine(order);


//conversão de enum
string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);