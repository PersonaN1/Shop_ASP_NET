using Shop_ASP_NET.Data.Interfaces;
using Shop_ASP_NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_ASP_NET.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                        new Car {Name="Tesla", ShortDesc="", LongDesc="", img="", price=40000, IsFavourite=true, Available=true, Category=_categoryCars.AllCategory.Last()}};
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
