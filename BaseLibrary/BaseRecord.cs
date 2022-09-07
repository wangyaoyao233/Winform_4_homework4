using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary
{
    /// <summary>
    /// 记账基类
    /// </summary>
    public class BaseRecord
    {
        //名目
        public string Name { get; set; }
        //描述
        public string Description { get; set; }
        //金额
        public decimal Amount { get; set; }
    }
}
