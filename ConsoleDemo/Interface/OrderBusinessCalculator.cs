using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.Interface
{
    public static class CommissionRate
    {
        public const decimal ORDER_BUSINESS_FOR_NORETURN = 0m;
        public const decimal ORDER_BUSINESS_FOR_NORMAL = 0.36m;
        public const decimal ORDER_BUSINESS_FOR_FULLRETURN = 0.9m;
    }

    public class NoReturn : IOrderBusinessCalculator
    {
        public string GetBusinessName()
        {
            return "无返还";
        }
        public decimal GetSettlement(decimal totalCommsission)
        {
            return totalCommsission * CommissionRate.ORDER_BUSINESS_FOR_NORETURN;
        }
    }

    public class Normal : IOrderBusinessCalculator
    {
        public string GetBusinessName()
        {
            return "普通返";
        }

        public decimal GetSettlement(decimal totalCommission)
        {
            return totalCommission * CommissionRate.ORDER_BUSINESS_FOR_NORMAL;
        }
    }

    public class FullReturn : IOrderBusinessCalculator
    {
        public string GetBusinessName()
        {
            return "全额返";
        }

        public decimal GetSettlement(decimal totalCommission)
        {
            return totalCommission * CommissionRate.ORDER_BUSINESS_FOR_FULLRETURN;
        }
    }
}
