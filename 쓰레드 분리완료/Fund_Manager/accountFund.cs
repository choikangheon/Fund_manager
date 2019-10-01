using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund_Manager
{
    public class accountFund
    {
        public string 종목코드;
        public string 종목명;
        public int 현재가;
        public int 매입금;
        public int 보유수량;
        public float 수익률;

        public accountFund(string 종목코드, string 종목명, int 현재가, int 매입금, int 보유수량, float 수익률)
        {
            this.종목코드 = 종목코드;
            this.종목명 = 종목명;
            this.현재가 = 현재가;
            this.매입금 = 매입금;
            this.보유수량 = 보유수량;
            this.수익률 = 수익률;
        }
    }

}
