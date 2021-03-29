using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fund_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            while (true)
            {
                int processCount = 0;
                processCount = CheckAlreadyRunThisProcess();

                switch(processCount)
                {
                    case 0:
                        Process.Start("Fund_Manager");
                        break;
                    case 1:
                        Console.WriteLine("정상실행중");
                        break;

                    default:
                        ProcessKill("Fund_Mangager");
                        break;


                }
            }
        }

        // 이미지 네임에 해당하는 모든 프로세스를 종료하는 메소드
        private void ProcessKill(string imgName)
        {
            // 프로세스 종료
            Process[] processes = Process.GetProcessesByName(imgName);
            foreach (var process in processes)
            {
                try
                {
                    process.Kill();
                }
                catch (Exception e) { }
            }
        }

        private int CheckAlreadyRunThisProcess()
        {
            int processCount = 0;

            System.Diagnostics.Process[] procs;
            procs = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process aProc in procs)
            {
                if (aProc.ProcessName.ToString().Equals("Fund_Manager"))
                {
                    processCount++;
                }
            }
            return processCount;
        }
    }
}
    




