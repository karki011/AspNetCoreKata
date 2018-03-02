﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AspNetCoreKata.Shared;
using Dapper;

namespace AspNetCoreKata.ProductRepository
{
    public class ProductRepo : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepo(IDbConnection conn)
        {
            _connection = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            using (var conn = _connection)
            {
                conn.Open();
                return conn.Query<Product>("SELECT Name, ProductId as Id FROM Product");
            }
        }

        public Product GetProductWithId(int id)
        {
            using (var conn = _connection)
            {
                conn.Open();
                return conn.Query<Product>("SELECT Name, ProductId as Id FROM Product where Id = @id", new {id}).FirstOrDefault();
            }
        }

    }
}
