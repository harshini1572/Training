using RetailShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.MsTest

{
    public class RetailShopModel
    {

        public ModelProduct GetByName(string name)
        {
            List<ModelProduct> Product = new List<ModelProduct>
            {
                new ModelProduct
                {
                    Name = "OnePlus",
                    Price=20000

                },
                new ModelProduct
                {
                    Name = "Apple",
                    Price=40000
                }


            };
            ModelProduct Product1 = Product.FirstOrDefault(x => x.Name == name);
            return Product1;

        }




    }
}


