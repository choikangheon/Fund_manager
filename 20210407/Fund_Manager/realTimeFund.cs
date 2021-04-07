using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund_Manager
{
    public class realTimeFund
    {
        public String 종목코드;
        public String 종목명;
        public String 현재가;
        public String 전일대비;
        public String 등락율;
        public String 거래량;
        public String 시가;
        public String 고가;
        public String 저가;


        public realTimeFund(String 종목코드,String 종목명, String 현재가, String 전일대비, String 등락율, String 거래량, String 시가, String 고가, String 저가)
        {
            this.종목코드 = 종목코드;
            this.종목명 = 종목명;
            this.현재가 = 현재가;
            this.전일대비 = 전일대비;
            this.등락율 = 등락율;
            this.거래량 = 거래량;
            this.시가 = 시가;
            this.고가 = 고가;
            this.저가 = 저가;
        }

    }
}