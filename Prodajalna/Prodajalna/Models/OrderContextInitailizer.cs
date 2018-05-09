using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Prodajalna.Models
{
    public class OrderContextInitailizer:DropCreateDatabaseIfModelChanges<OrderContext>
    {
        protected override void Seed(OrderContext context)
        {
            var produkti = new List<Product>()
            {
                new Product(){ Name="Paradižnikova juha", Price=1.3m,ActualCost=0.99m},
                new Product(){ Name="Kladivo", Price=16.99m,ActualCost=10m},
                new Product(){ Name="Yo yo", Price=6.99m,ActualCost=2.05m}
            };
            foreach (var p in produkti)
                context.Products.Add(p);
            context.SaveChanges();

            var naročilo = new Order() { Customer = "Bob" };
            var vrstice = new List<OrderDetail>()
            {
                new OrderDetail(){ Product=produkti[0],Quantity=2,Order=naročilo},
                new OrderDetail(){ Product=produkti[1],Quantity=4,Order=naročilo}
            };
            context.Orders.Add(naročilo);
            vrstice.ForEach(x => context.OrderDetails.Add(x));
            context.SaveChanges();
        }
    }
}