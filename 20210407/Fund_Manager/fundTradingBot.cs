using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///텔레그램 dll using
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;




namespace Fund_Manager
{
    public class fundTradingBot 
    {
        private static readonly string _token = "1734135792:AAEbHhJ44ie3m3fBh6eJtqekKMhyWGhSakc";
        private static readonly string _chid = "-583357250";
       //public static Client client = new Client();
        public static TelegramBotClient Bot = new TelegramBotClient(_token);

        
        public async void telegramAPIAsync()
        {
            var me = await Bot.GetMeAsync();
            Console.WriteLine("내 이름은 {0}", me.Username);
        }


        public async void SendMessage(string msg)
        {
            Bot.SendTextMessageAsync(_chid, msg);
        }



        public void Bot_Onmessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {


            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {

                if (e.Message.Text.StartsWith("/count"))
                {

                    string response = "the Number of letters in your text is -> ";
                    response += e.Message.Text.ToString();
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "하");

                }

               else if (e.Message.Text.StartsWith("/sell"))
                {

                    string 종목코드 = "";
                    int 보유수량 =  0;

                    
                    //  client.sellBot(종목코드, 보유수량);
                    string response = e.Message.Text.ToString();
                    // /sell(종목코드,숫자)
                    string[] vs = response.Split('(',',',')'); ////sell(종목코드,수량)      

                
                    string test = "sellBot(" + vs[1] + ","+vs[2]+")";
                    
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, test);

                }
              
                     
            }




        }
    }
}