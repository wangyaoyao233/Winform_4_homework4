using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary
{
    /// <summary>
    /// 支出记录
    /// </summary>
    public class ExpendRecord: BaseRecord
    {
        //数量
        public int Num { get; set; }
        //单价
        public decimal Price { get; set; }
    }
}
