﻿using EfCoreBookApp.DAL;
using System;
using System.Linq;

namespace EfCoreBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new BookAppDbContext();

            var category = _context.Categories
                .Where(c => c.CategoryId == 1)
                .SingleOrDefault();

            _context.Categories.Remove(category);
            _context.SaveChanges();

            Console.ReadKey();
        }
    }
}
