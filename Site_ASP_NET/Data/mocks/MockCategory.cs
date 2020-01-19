using Shop_ASP_NET.Data.Interfaces;
using Shop_ASP_NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_ASP_NET.Data.mocks
{
    public class MockCategory:ICarsCategory
    {       
        
            public IEnumerable<Category> AllCategory
            {
                get
                {
                    return new List<Category> {
                        new Category{CategoryName="ElectroCars", Desc="NowDays Tech" },
                        new Category{CategoryName="ClassicCars", Desc="OldDays Tech" }
                       };

                }   
            }
        
    }
}
