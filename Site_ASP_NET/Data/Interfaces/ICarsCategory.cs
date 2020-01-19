using Shop_ASP_NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_ASP_NET.Data.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategory { get; }
    }
}
