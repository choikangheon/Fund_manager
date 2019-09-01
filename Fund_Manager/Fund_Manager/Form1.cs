using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fund_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axKHOpenAPI1.CommConnect(); // login 
            axKHOpenAPI1.OnEventConnect += OnEventConnect; // 로그인시 발생하는 이벤트 
            
        }

        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                string Account_list = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim(); // 계좌리스트 받아옴
                string[] 계좌목록 = Account_list.Split(';');

                for (int i = 0; i < 계좌목록.Length; i++)
                {
                    comboBox1.Items.Add(계좌목록[i]);
                }
            }
            lb아이디.Text = axKHOpenAPI1.GetLoginInfo("USER_ID");
            lb이름.Text = axKHOpenAPI1.GetLoginInfo("USER_NAME");
        }
       
        public void User_balance()
        {
            string acc_number = comboBox1.Text; 
           axKHOpenAPI1.SetInputValue("계좌번호", acc_number);
            axKHOpenAPI1.SetInputValue("비밀번호", "0614");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");

            axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, "화면번호");

        }

    }


}
