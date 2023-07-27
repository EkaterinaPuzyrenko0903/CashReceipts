using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OutPut
    {
        public string? Name { get; set; }//Филиал Название
        public int payCondition { get; set; }//Условие платежа, дней

        public int DayPay { get; set; }//Кол-во дней до оплаты
        public double dolya { get; set; }


    }
}
