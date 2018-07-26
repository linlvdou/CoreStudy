using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.Interface
{
    interface IOrderBusinessCalculator
    {
        /// <summary>
        /// 获取业务名称
        /// </summary>
        /// <returns></returns>
        string GetBusinessName();

        /// <summary>
        /// 获取结算金额
        /// </summary>
        /// <param name="totalCommission"></param>
        /// <returns></returns>
        decimal GetSettlement(decimal totalCommission);
    }
}
