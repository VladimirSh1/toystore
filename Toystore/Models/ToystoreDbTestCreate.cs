using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Toystore.Models
{
    public class ToystoreDbTestCreate:DropCreateDatabaseAlways<ToystoreDBContext>
    {
        protected override void Seed(ToystoreDBContext db)
        {
            db.Toys.Add(new Toy() { Name = "Конструктор LEGO", Price = 10 });
            db.Toys.Add(new Toy() { Name = "Кукла Барби", Price = 10 });
            db.Toys.Add(new Toy() { Name = "Набор \"Юный химик\" ", Price = 10 });
            db.Toys.Add(new Toy() { Name = "Лошадка деревянная", Price = 10 });
            db.Toys.Add(new Toy() { Name = "Головоломка Kribly Boo", Price = 10 });
        }
    }
}