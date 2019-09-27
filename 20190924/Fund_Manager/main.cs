using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using System.Timers;
using System.Media;
/*
***************************************************                      
*                                                 *    
*    키움증권 api 를 사용한 자동매매 프로그램     *   
*                                                 *   
*                                                 *   
***************************************************/




namespace Fund_Manager

{

    public partial class main : MetroForm
    {
        private int cnt = 0;
        private int _ScrNum = 5000;
        List<condition> conditionList = new List<condition>();  // 조건식의 INDEX ,  NAME 저장
        List<tradingStrategy> tradingStrategyList = new List<tradingStrategy>();    // 매수 조건 저장
        List<realTimeFund> realTimeFundList = new List<realTimeFund>(); // 실시간 조건검색후 저장할 주식정보
        List<accountFund> accountFundList = new List<accountFund>(); // 실시간 잔고현황

        public main()
        {

            //FormBorderStyle = FormBorderStyle.None;

            //WindowState = FormWindowState.Maximized;

            //BackColor = Color.RoyalBlue;







            InitializeComponent();
            autoTimer();
            axKHOpenAPI1.Hide(); //로고 숨기기
            axKHOpenAPI1.CommConnect(); // login 
            Shown += Form1_Shown;// 폼로드후 실행되는 메서드
            axKHOpenAPI1.OnEventConnect += OnEventConnect; // 로그인시 발생하는 이벤트 
            axKHOpenAPI1.OnReceiveTrData += OnReceiveTrData;
            axKHOpenAPI1.OnReceiveConditionVer += get_OnReceiveConditionVer;
            axKHOpenAPI1.OnReceiveTrCondition += OnReceiveTrCondition;
            axKHOpenAPI1.OnReceiveRealCondition += OnReceiveRealCondition; // 실시간 조건검색
            Accountbutton.Click += User_balance; // 계좌조회
            //createStrategyButton.Click += createStrategy; //매수전략생성
            //metroButton1.Click += sendOrder;//임시 주문
            autoFundStartButton.Click += autoFundStart;
            findTighteningButton.Click += info_Tightening; //체결내역조회
            axKHOpenAPI1.OnReceiveChejanData += axKHOpenApi_OnReceiveChejanData; // 채결여부

            //autoSettingButton.Click += autoSetting;
            

        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            Delay(10000);
            autoSetting();

        }

        //그리드뷰 속도향상
        public class QuickDataGridView : DataGridView
        {
            public QuickDataGridView()
            {
                DoubleBuffered = true;
            }
        }


        // 그리드뷰 색깔 변화
        private void gridColor()
        {
            for (int i = 0; i < realTimeAccountGridView.Rows.Count; i++)
            {

                string s_수익률 = realTimeAccountGridView.Rows[i].Cells[5].Value.ToString();
                double 수익률 = double.Parse(s_수익률.TrimEnd('%'));

                if (수익률 > 0)
                {
                    realTimeAccountGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (수익률 < 0)
                {
                    realTimeAccountGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                }

            }
        }


        private void autoTimer()
        {
            System.Timers.Timer autoTimer = new System.Timers.Timer();
            autoTimer.Elapsed += new ElapsedEventHandler(autoFundStart);

            autoTimer.Interval = 1300;
            autoTimer.Enabled = false;

        }

        private void axKHOpenApi_OnReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e) //체결되면 반환
        {
            if (e.sGubun == "0")
            {
                kakaoMessage kakao = new kakaoMessage();
                string 종목명 = axKHOpenAPI1.GetChejanData(302); //종목명 
                string 체결시간 = axKHOpenAPI1.GetChejanData(908); //체결시간 
                string 체결가 = axKHOpenAPI1.GetChejanData(910); //체결가 
                int 체결량 = 0;
                if (axKHOpenAPI1.GetChejanData(911).Length > 0)
                    체결량 = Int32.Parse(axKHOpenAPI1.GetChejanData(911).Trim()); //체결량 
                kakao.SendKatalk("강헌", "종목명 : " + 종목명 + " 체결시간 : " + 체결시간 + " 체결가 : " + 체결가);
                if (체결량 > 0)
                {
                    string soundloc = "체결수신1.wav";
                    SoundPlayer sound = new SoundPlayer(soundloc);
                    sound.Play();
                    realTimeAccountGridView.Rows.Clear();
                    Account_yield();

                }
            }
        }

        private void info_Tightening(object sender, EventArgs e) //체결정보확인
        {

            axKHOpenAPI1.SetInputValue("계좌번호", accountComboBox.Text);

            //체결구분 = 0:체결 + 미체결조회, 1:미체결조회, 2:체결조회

            axKHOpenAPI1.SetInputValue("체결구분", "0");

            //          매매구분 = 0:전체, 1:매도, 2:매수

            axKHOpenAPI1.SetInputValue("매매구분", "0");
            axKHOpenAPI1.CommRqData("체결정보", "opt10075", 0, GetScrNum());

        }



        private void autoFundStart(object sender, EventArgs e)  // 자동구매
        {
            /*   System.Timers.Timer autoTimer = new System.Timers.Timer();
               autoTimer.Elapsed += new ElapsedEventHandler(autoFundStart);

               autoTimer.Interval = 1000;
               autoTimer.Enabled = false;
               */


            if (tradingStrategyList.Count == 0)
            {
                MessageBox.Show("매수전략을 설정하세요");
                return;
            }
            else
            {
                //   autoTimer.Enabled = true;


                for (int j = 0; j < realTimeFundList.Count; j++) //실시간후 저장 
                {
                    int flag = 0;
                    for (int i = 0; i < realTimeAccountGridView.Rows.Count; i++)
                    {
                        if ((realTimeAccountGridView.Rows[i].Cells[1].Value.ToString()).Trim() == realTimeFundList[j].종목명)
                            flag = 1;
                        //  Console.WriteLine(realTimeAccountGridView.Rows[i].Cells[1].Value.ToString());
                        // Console.WriteLine(realTimeFundList[j].종목명);

                    }
                    if (flag == 1)
                    {
                        Console.WriteLine("동일한 주식보유");
                        Delay(500);
                        continue;
                    }
                    else
                    {
                        //int index =  r.Next(0, realTimeFundList.Count);
                        int price = tradingStrategyList[0].itemInvestment;
                        string now_price = realTimeFundList[j].현재가.Remove(0, 1);
                        int fundCount = price / int.Parse(now_price);

                        if (0 < tradingStrategyList[0].buyingItemCount)
                        {
                            buyOrder(realTimeFundList[j].종목코드, fundCount);
                            tradingStrategyList[0].buyingItemCount += -1;
                            Console.WriteLine(tradingStrategyList[0].buyingItemCount);

                            Delay(500);
                        }

                    }

                }




            }

        }

        // 주식 주문
        private void buyOrder(String 종목코드, int 수량)
        {

            //계좌 선택 여부 확인 
            if (this.accountComboBox.Text.Length != 10)
            {
                System.Windows.Forms.MessageBox.Show("계좌를 선택해주세요.");
                return;
            }
            else
            {
                //주문하기 
                int lRet = axKHOpenAPI1.SendOrder("주식주문", GetScrNum(), this.accountComboBox.Text.Trim(), 1, 종목코드, 수량, 0, "03", "");

                if (lRet == 0)
                {
                    Console.WriteLine("주문이 전송 되었습니다");
                    Console.WriteLine(종목코드 + "," + 수량);
                }
                else
                {
                    Console.WriteLine("주문이 전송 실패 하였습니다.");
                    Console.WriteLine(종목코드 + "," + 수량);
                }
            }

        }

        /* 주식 판매 */
        private void sellOrder(String 종목코드, int 보유수량)
        {
            string newCode = (종목코드.Remove(0, 1)).Trim();
            Console.WriteLine(newCode);
            if (accountComboBox.Text.Length != 10)
            {
                MessageBox.Show("계좌번호를 입력해주세요");
                return;
            }
            else
            {
                int IRet = axKHOpenAPI1.SendOrder("주식주문", GetScrNum(), accountComboBox.Text.Trim(), 2, newCode, 보유수량, 0, "03", "");
                if (IRet == 0)
                {
                    Console.WriteLine("주문이 전송 되었습니다");
                }
                else
                {
                    Console.WriteLine("주문이 전송 실패 하였습니다.");
                }

            }

        }

        /* 조건검색을 통한 실시간 주식들 정보가져오기
           서버를 통해 조건검색 ( 실시간 주식정보) 요청*/

        private void findStrategyFund() // SendCondition
        {
            string nameOfCondition = realTimeConditionCombo.Text;
            condition tmp = null;
            if (nameOfCondition.Length > 0)
            {
                tmp = conditionList.Find(o => o.name.Equals(nameOfCondition));

                long lRet = axKHOpenAPI1.SendCondition(GetScrNum(), tmp.name, tmp.index, 1);
                Console.WriteLine(lRet); // 1 
            }
            else
            {
                MessageBox.Show("조건이름을 설정하세요");
                return;

            }

        }

        /* 실시간 조건검색 정지 매서드*/

        private void stopStrategyFund()
        {
            string nameOfCondition = realTimeConditionCombo.Text;
            condition tmp = null;
            if (nameOfCondition.Length > 0)
            {
                tmp = conditionList.Find(o => o.name.Equals(nameOfCondition));

            }


            axKHOpenAPI1.SendConditionStop(GetScrNum(), tmp.name, tmp.index);

        }

        /* 조건검색을 통한 종목코드가져온후 해당 주식 정보 가져오기*/

        private void OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {

            String strCodeList = e.strCodeList.Trim();

            if (strCodeList.Length > 0)
                strCodeList = strCodeList.Remove(strCodeList.Length - 1);

            int nCodeCount = strCodeList.Trim().Split(';').Length;

            if (e.nNext == 2)
            {
                axKHOpenAPI1.SendCondition(
                    e.sScrNo,
                    e.strConditionName,
                    e.nIndex,
                    2
                    );
            }

            axKHOpenAPI1.CommKwRqData(strCodeList, 0, nCodeCount, 0, "관심종목정보", GetScrNum());

        }

        private void OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {
            string code = e.sTrCode;
            string condition_name = e.strConditionName;
            string condition_index = e.strConditionIndex;

            if (e.strType == "I") // 조건검색 편입
            {
                int flag = 0;
                realTimeAccountOfflabel.Checked = true;
                Delay(700);
                itemInsertListBox.Items.Insert(0, "[" + condition_index + ":" + condition_name + "]" + " " + code);

                for (int i = 0; i < realTimeFundList.Count; i++)
                {
                    if (code.Trim() == (realTimeFundList[i].종목코드).Trim())
                        flag = 1;
                }
                for(int i = 0; i< realTimeAccountGridView.Rows.Count; i++)
                {
                    string checkCode = (realTimeAccountGridView.Rows[i].Cells[0].Value.ToString()).Trim();
                    if (code.Trim() == checkCode.Substring(1))
                        flag = 1;
                }
                if (flag == 0)
                {
                    axKHOpenAPI1.SetInputValue("종목코드", code);
                    axKHOpenAPI1.CommRqData("주식기본정보요청", "opt10001", 0, GetScrNum());
                    Console.WriteLine("요청성공");
                    Delay(500);
                }
                else
                {
                    Console.WriteLine("이미존재해서 리턴");
                    realTimeAccountOnlabel.Checked = true;
                    Delay(500);
                    return;
  

                }
            }
            if (e.strType == "D")   //조건검색 이탈
            {
                itemDeleteListBox.Items.Insert(0, "[" + condition_index + ":" + condition_name + "]" + " " + code);
            }

        }

        /*매수전략 생성*/
        private void createStrategy()
        {

          //  if (sender.Equals(createStrategyButton))
           // {
                string account = accountComboBox.Text;
                if (account.Length == 0)
                {
                    MessageBox.Show("투자 계좌번호를 선택해주세요");
                    return;
                }
                string conditionName = buycondition_combo.Text;
                condition buyingCondition = null;   //매수조건식

                if (conditionName.Length > 0)
                {

                    buyingCondition = conditionList.Find(o => o.name.Equals(conditionName));

                }
                else // 매수조건식 선택 x 
                {
                    MessageBox.Show("매수 조건식을 선택하세요.");
                }

                if (buyingCondition == null)
                    return;

                string buyingOrderOption; // 호가옵션

                if (marketPriceRadio.Checked)
                    buyingOrderOption = "시장가";
                else
                    buyingOrderOption = buyingOrderComboBox.Text;

                int totablInvestMent;

                if (investmentnumeric1.Value == 0)
                {
                    MessageBox.Show("투자금액을 설정해주세요");
                    return;
                }
                totablInvestMent = (int)investmentnumeric1.Value; // 총투자금액

                int itemCount = (int)itemcountnumeric2.Value; // 매수조건수

                tradingStrategy ts = new tradingStrategy(account, buyingCondition, buyingOrderOption, totablInvestMent, itemCount);
                tradingStrategyList.Add(ts);

                //MessageBox.Show("전략이 생성되었습니다.");
                AddStrategyToDataGridView(ts);

            }
        //}

        /*매매전략 DataGridView 바인딩*/
        private void AddStrategyToDataGridView(tradingStrategy ts)
        {
            if (ts != null)
            {
                int rowIndex = tradingStrategyGridView.Rows.Add();
                tradingStrategyGridView["매매전략_계좌번호", rowIndex].Value = ts.account;
                tradingStrategyGridView["매매전략_매수가격", rowIndex].Value = ts.buyingOrderOption;
                tradingStrategyGridView["매매전략_총투자금", rowIndex].Value = ts.totalInvestment;
                tradingStrategyGridView["매매전략_매수종목수", rowIndex].Value = ts.buyingItemCount;
                tradingStrategyGridView["매매전략_종목당투자금", rowIndex].Value = ts.itemInvestment;

            }
        }


        /* 서버로 부터 반환된 정보들을 출력하는 매서드*/
        public void OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

            if (e.sRQName == ("예수금상세현황"))
            {
                
                
                int 예수금 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금"));
                Console.WriteLine(예수금);
                investmentnumeric1.Value = 예수금;
            }

            if (e.sRQName == ("체결정보"))

            {
                Tightening_ok_datagrid.Rows.Clear();
                Tightening_no_datagrid.Rows.Clear();

                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < nCnt; i++)
                {
                    String 주문번호 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호").Trim();
                    String 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    String 주문상태 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문상태").Trim();
                    String 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    int 주문수량 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량"));
                    int 체결누계금액 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "체결누계금액"));
                    String 주문구분 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                    int 체결가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "체결가"));
                    int 체결수량 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "체결량"));

                    if (주문상태 == "체결")
                        Tightening_ok_datagrid.Rows.Add(주문번호, 종목코드, 주문상태, 종목명, 주문수량, 체결누계금액, 주문구분, 체결가, 체결수량);
                    else
                        Tightening_no_datagrid.Rows.Add(주문번호, 종목코드, 주문상태, 종목명, 주문수량, 체결누계금액, 주문구분, 체결가, 체결수량);
                }


            }



            if (e.sRQName == "주식기본정보요청")
            {

                Delay(500);
                Console.WriteLine("추가정보 반환");
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                int price = tradingStrategyList[0].itemInvestment;
                int flag = 0;

                String 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                String 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                String 현재가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim();
                String 전일대비 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim();
                String 등락율 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();
                String 거래량 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim();
                String 시가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가").Trim();
                String 고가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가").Trim();
                String 저가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가").Trim();

                realTimeFund rtf = new realTimeFund(종목코드, 종목명, 현재가, 전일대비, 등락율, 거래량, 시가, 고가, 저가);
                realTimeFundList.Add(rtf);

                Console.WriteLine(tradingStrategyList[0].buyingItemCount);
                if (0 <= tradingStrategyList[0].buyingItemCount)
                {
                    for (int i = 0; i < realTimeAccountGridView.Rows.Count; i++)
                    {

                        if (rtf.종목코드.Trim() == (realTimeAccountGridView.Rows[i].Cells[0].Value.ToString()).Trim())
                        {
                            flag = 1;
                        }
                        Console.WriteLine(rtf.종목코드.Trim());
                        Console.WriteLine("그리드뷰" + realTimeAccountGridView.Rows[i].Cells[0]);
                    }
                    if (flag != 1)
                    {
                        int count = price / int.Parse(rtf.현재가.Remove(0, 1));
                        buyOrder(rtf.종목코드, count);
                        realTimeAccountOnlabel.Checked = true;
                        tradingStrategyList[0].buyingItemCount += -1;
                    }
                    else
                    {
                        realTimeAccountOnlabel.Checked = true;
                        MessageBox.Show("동일종목보유");
                    }
                }


                realTimeConditionGridView.Rows.Add(rtf.종목코드, rtf.종목명, rtf.현재가, rtf.전일대비, rtf.등락율, rtf.거래량, rtf.시가, rtf.고가, rtf.저가);
                manualTradingDataGridView.Rows.Add(rtf.종목코드, rtf.종목명, rtf.현재가, rtf.전일대비, rtf.등락율, rtf.거래량, rtf.시가, rtf.고가, rtf.저가);

            }
            if (e.sRQName == "관심종목정보")
            {
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < nCnt; i++)
                {


                    String 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    String 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    String 현재가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim();
                    String 전일대비 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "전일대비").Trim();
                    String 등락율 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "등락율").Trim();
                    String 거래량 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "거래량").Trim();
                    String 시가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시가").Trim();
                    String 고가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "고가").Trim();
                    String 저가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "저가").Trim();

                    realTimeFund rtf = new realTimeFund(종목코드, 종목명, 현재가, 전일대비, 등락율, 거래량, 시가, 고가, 저가);
                    realTimeFundList.Add(rtf);


                    realTimeConditionGridView.Rows.Add(rtf.종목코드, rtf.종목명, rtf.현재가, rtf.전일대비, rtf.등락율, rtf.거래량, rtf.시가, rtf.고가, rtf.저가);
                    manualTradingDataGridView.Rows.Add(rtf.종목코드, rtf.종목명, rtf.현재가, rtf.전일대비, rtf.등락율, rtf.거래량, rtf.시가, rtf.고가, rtf.저가);


                }


            }

            if (e.sRQName == "계좌잔고평가내역")
            {

                //  API를 통해 받아온 데이터 ( 계좌잔고 ) 출력
                int 총금액 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산"));
                int 매입금액 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액"));
                int 손익 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가손익금액"));
                float 수익률 = float.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총수익률(%)"));

                수익률 += -1;
                /*  if (Single.TryParse(수익률, out f수익률))
                      수익률 = String.Format("{0:0.00%}", f수익률);
                 */
                lb총금액.Text = 총금액.ToString();
                lb매입금액.Text = 매입금액.ToString();
                lb손익금액.Text = 손익.ToString();
                lb수익률.Text = 수익률.ToString() + "%";

            }



            if (e.sRQName == "계좌잔고개별")
            {
                // API를 통해 주식별 정보출력

                int idex = -1;

                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, "계좌잔고개별");

                try
                {
                    for (int i = 0; i < nCnt; i++)
                    {

                        string 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목번호");
                        string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명");
                        int 현재가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                        int 매입금 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입가"));
                        int 보유수량 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                        float 수익률 = float.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "수익률(%)"));

                        accountFund af = new accountFund(종목코드, 종목명, 현재가, 매입금, 보유수량, 수익률);

                        for (int j = 0; j < realTimeAccountGridView.Rows.Count; j++)
                        {

                            if ((realTimeAccountGridView.Rows[j].Cells[0].Value.ToString()).Trim() == af.종목코드.Trim())
                            {

                                idex = j;
                                break;
                            }
                        }

                        if (idex > -1)
                        {
                            int index = -1;
                            realTimeAccountGridView.Rows[idex].Cells[2].Value = af.현재가;
                            realTimeAccountGridView.Rows[idex].Cells[4].Value = af.보유수량 + "주";
                            realTimeAccountGridView.Rows[idex].Cells[5].Value = af.수익률 + "%";

                            for (int j = 0; j < realTimeFundList.Count; j++)
                            {
                                // Console.WriteLine(af.종목코드+","+realTimeFundList[j].종목코드);
                                if (af.종목코드.Trim() == (realTimeFundList[j].종목코드).Trim())
                                {
                                    index = j;
                                    break;
                                }
                            }
                            if (index > -1)
                            {
                                accountFundList[index].현재가 = af.현재가;
                                accountFundList[index].보유수량 = af.보유수량;
                                accountFundList[index].수익률 = af.수익률;
                            }
                        }
                        else
                        {
                            accountFundList.Add(af);
                            realTimeAccountGridView.Rows.Add(af.종목코드, af.종목명, af.현재가, af.매입금, af.보유수량 + "주", af.수익률 + "%");

                        }
                        if (af.수익률 >= 1.5 || af.수익률 <= -3)
                        {
                            sellOrder(af.종목코드, af.보유수량);
                        }
                        gridColor();

                      
                    }
                    
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("예외발생");
                    realTimeAccountGridView.Rows.Clear();
                    cnt++;
                    return;
                }
            }

            cnt++;
            Console.WriteLine(cnt);
            if (cnt >= 998)
            {
                cnt = 0;
                axKHOpenAPI1.CommTerminate(); //로그아웃후
                                              // axKHOpenAPI1.CommConnect();     // 재 로그인
                System.Windows.Forms.Application.Restart();

            }

        }

        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {   //게좌 리스트 출력
            if (e.nErrCode == 0)
            {
                string Account_list = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim(); // 계좌리스트 받아옴
                string[] 계좌목록 = Account_list.Split(';');

                for (int i = 0; i < 계좌목록.Length; i++)
                {
                    accountComboBox.Items.Add(계좌목록[i]);
                }
            }
            lb아이디.Text = axKHOpenAPI1.GetLoginInfo("USER_ID");
            lb이름.Text = axKHOpenAPI1.GetLoginInfo("USER_NAME");

            //조건식 불러오기
            axKHOpenAPI1.GetConditionLoad();
        }

        private void get_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            string conditions = axKHOpenAPI1.GetConditionNameList(); // 조건식 이름 GET

            //000^안전;
            string[] conditionArray = conditions.Split(';');
            foreach (string condition in conditionArray)
            {
                if (condition.Length > 0)
                {
                    string[] conditionInfo = condition.Split('^');
                    string index = conditionInfo[0];
                    string name = conditionInfo[1];

                    condition cd = new condition(int.Parse(index), name);
                    conditionList.Add(cd);
                }

            }
            foreach (condition condition in conditionList)
            {
                buycondition_combo.Items.Add(condition.name);
                realTimeConditionCombo.Items.Add(condition.name);
            }
        }

        private void Account_yield()
        {   // 계좌 주식별 정보 요청
            string acc_number = accountComboBox.Text;

            axKHOpenAPI1.SetInputValue("계좌번호", acc_number);
            axKHOpenAPI1.SetInputValue("비밀번호", "");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");
            axKHOpenAPI1.CommRqData("계좌잔고개별", "opw00018", 0, GetScrNum());
        }

        public void User_balance(object sender, EventArgs e)
        {   //계좌 전체합산 정보요청
            string acc_number = accountComboBox.Text;

            axKHOpenAPI1.SetInputValue("계좌번호", acc_number);
            axKHOpenAPI1.SetInputValue("비밀번호", "");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "1");

            axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, GetScrNum());


        }

        /*화면번호 자동생성 매서드*/
        private string GetScrNum()
        {
            if (_ScrNum < 9999) _ScrNum++;
            _ScrNum++;
            return _ScrNum.ToString();
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }



        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void RealTimeStrategyOnLabel_CheckedChanged(object sender, EventArgs e)
        {
            findStrategyFund();
        }

        private void realTimeConditionOffLabel_CheckedChanged(object sender, EventArgs e)
        {
            stopStrategyFund();

            realTimeConditionGridView.Rows.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Account_yield();
        }

        private void autoSetting()
        {      
            accountComboBox.Text = accountComboBox.Items[0].ToString();
            axKHOpenAPI1.SetInputValue("계좌번호", accountComboBox.Text);
            axKHOpenAPI1.SetInputValue("비밀번호", "");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");
            axKHOpenAPI1.CommRqData("예수금상세현황", "opw00001", 0, GetScrNum());
            buycondition_combo.Text = buycondition_combo.Items[0].ToString();
            realTimeConditionCombo.Text = realTimeConditionCombo.Items[0].ToString();
            itemcountnumeric2.Value = 5;
            Delay(300);
            createStrategy();
            realTimeAccountOnlabel.Checked = true;
            realTimeConditionOnLabel.Checked = true;
        
            
        }

      
        private void CreateStrategyButton_Click(object sender, EventArgs e)
        {
            createStrategy();
        }

        private void AutoSettingButton_Click(object sender, EventArgs e)
        {
            autoSetting();
        }
    }
}
