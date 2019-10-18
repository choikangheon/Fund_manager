using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Fund_Manager
{
   public class kakaoMessage
    {
        /***********카카오톡메세지전송************/
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        //FindWindow (최상위 창 핸들값 가져오는 API)

        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int hWnd1, int hWnd2, string lpsz1, string lpsz2);
        //FindWindowEX (인자로 받아온 핸들의 자식의 핸들값 가져오는 API)

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hwnd, int wMsg, int wParam, string lParam);
        //SendMessage

        [DllImport("user32.dll")]
        public static extern uint PostMessage(int hwnd, int wMsg, int wParam, int lParam);
        //PostMessage
        public void SendKatalk(string title, string msg)
        {
            int hd01 = FindWindow(null, title);
            int hd03 = FindWindowEx(hd01, 0, "RichEdit20W", "");
            SendMessage(hd03, 0x000c, 0, msg);
            PostMessage(hd03, 0x0100, 0xD, 0x1C001);

        }
        /****************************************/
    }
}
