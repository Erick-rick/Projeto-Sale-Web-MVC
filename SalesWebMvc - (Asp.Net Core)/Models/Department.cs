using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc____Asp.Net_Core_.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); // 1 departamento tem varios vendedores 1:*

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final) {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

    }
}

