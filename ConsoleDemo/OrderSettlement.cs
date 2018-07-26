using ConsoleDemo.Enum;
using ConsoleDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    public class OrderSettlement
    {
        public static void DoSettlement()
        {
            IOrderBusinessCalculator _OrderBusinessCalculator;
            var dic = new Dictionary<OrderBusiness, decimal>();
            dic.Add(OrderBusiness.NoReturn, 5.6m);
            dic.Add(OrderBusiness.Normal, 10.10m);
            dic.Add(OrderBusiness.FullReturn, 8.88m);
            //dic.Add(0, 0.11m);

            Console.WriteLine();
            foreach (var item in dic)
            {
                switch (item.Key)
                {
                    case OrderBusiness.NoReturn:
                        _OrderBusinessCalculator = new NoReturn();
                        break;
                    case OrderBusiness.Normal:
                        _OrderBusinessCalculator = new Normal();
                        break;
                    case OrderBusiness.FullReturn:
                        _OrderBusinessCalculator = new FullReturn();
                        break;
                    default:
                        throw new NotImplementedException();
                }

                Console.WriteLine($"{_OrderBusinessCalculator.GetBusinessName()} : {_OrderBusinessCalculator.GetSettlement(item.Value).ToString("N2")} [{item.Value}]");
            }
            Console.WriteLine();
        }
    }
}
