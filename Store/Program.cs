using Store.Data.Models;
using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
