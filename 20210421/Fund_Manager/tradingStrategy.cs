namespace Fund_Manager
{
    public class tradingStrategy
    {
        public string account; // 매매계좌
        condition buyingcondition; //매수 조건식
        public string buyingOrderOption; // 현재가 or 시장가
        public int totalInvestment; // 총 투자금
        public int buyingItemCount; // 매수 종목수
        public int itemInvestment; // 종목별 투자금액

        public tradingStrategy(string account, condition condition, string buyingOrderOption, int totalInvestment, int buyingItemCount)
        {
            this.account = account;
            this.buyingcondition = condition;
            this.buyingOrderOption = buyingOrderOption;
            this.totalInvestment = totalInvestment;
            this.buyingItemCount = buyingItemCount;

            if (buyingItemCount != 0)
                this.itemInvestment = totalInvestment / buyingItemCount;
        }

    }
}
