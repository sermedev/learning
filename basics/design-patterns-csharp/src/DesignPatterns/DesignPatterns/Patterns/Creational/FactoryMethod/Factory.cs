﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Creational.FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    public interface ISale
    {
        public void Sell(decimal total);
    }

    /// <summary>
    /// Concrete Product Store
    /// </summary>
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de {total + _extra}");
        }
    }

    /// <summary>
    /// Concrete Product Internet
    /// </summary>
    public class InternetSale : ISale
    {
        private decimal _discount;


        public InternetSale(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en INTERNET tiene un total de {total - _discount}");
        }
    }




    /// <summary>
    /// Creator
    /// </summary>
    /// <returns></returns>
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    /// <summary>
    /// Croncrete Creator Store
    /// </summary>
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    /// <summary>
    /// Concrete Creator Interner
    /// </summary>
    internal class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount=discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

}
