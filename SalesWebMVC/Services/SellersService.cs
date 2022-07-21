using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Controllers;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellersService
    {
        private readonly SalesWebMVCContext _Context;
        public SellersService(SalesWebMVCContext context)
        {
            _Context = context;
        }
        public List<Seller> FindAll()
        {
            return _Context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _Context.Add(obj);
            _Context.SaveChanges();
        }

        
    }
}
