using myapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapp
{
    public class DemoClass
    {
        public static IEnumerable<Product> products;
        public DemoClass()
        {
            products = new List<Product>();
            SetProducts();
        }



        public void SetProducts()
        {
            var list = products as List<Product>;
            Product pr1 = new Product();
            pr1.id = 1;
            pr1.name = "Name1";
            pr1.categoryId = 1;
            list.Add(pr1);

            Product pr2 = new Product();
            pr2.id = 2;
            pr2.name = "Name2";
            pr2.categoryId = 1;
            list.Add(pr2);

            Product pr3 = new Product();
            pr3.id = 3;
            pr3.name = "Name3";
            pr3.categoryId = 1;
            list.Add(pr3);

            
        }

        public IEnumerable<Product> GetProducts() 
        {
            return products;
        }

        public int NewID()
        {
            int cnt = (products as List<Product>).Count;
            return cnt; 
        }


    }
}
