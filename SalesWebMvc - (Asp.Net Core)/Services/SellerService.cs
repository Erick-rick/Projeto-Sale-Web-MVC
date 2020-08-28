﻿using SalesWebMvc.Data;
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

        public SellerService(SalesWebMvcContext context) {
            _context = context;
        }

        //forma sincrona
        public List<Seller> FindAll() {
            return _context.Seller.ToList(); //converte a tabela vendedor em lista e mostrar todos

    }
}