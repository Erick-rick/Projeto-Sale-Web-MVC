using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context; //readonly não permitir alteração

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //forma sincrona
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); //converte a tabela vendedor em lista e mostrar todos

        }

        public void Insert(Seller obj) {

            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
