﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


    }
}
