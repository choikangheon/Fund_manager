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
using System.Threading;


namespace Fund_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                int processCount = 0;
                processCount = CheckAlreadyRunThisProcess();
                 int processCount2 = CheckOpenapiThisProcess();


               if (processCount==0 /*&& processCount2 == 0*/)
                {
                    Process.Start("Fund_Manager.exe");
                    Console.WriteLine("프로그램 실행완료");
                }
                else if (processCount == 1 /*&& processCount2 == 1*/)
                {


                    Console.WriteLine(processCount+"정상실행중");

                }
                else if (processCount >=2 || processCount2 >=2)
                {

                    ProcessKill("Fund_Manager");
                    ProcessKill("opstarter");
                    Console.WriteLine(processCount+"+" + processCount2 +"프로그램 종료완료");
                   
                }

                
                Thread.Sleep(2000);
                Console.WriteLine("Running Time " + (sw.ElapsedMilliseconds/1000).ToString() + " ms\n");

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

        private int CheckOpenapiThisProcess()
        {
            int processCount = 0;

            System.Diagnostics.Process[] procs;
            procs = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process aProc in procs)
            {
                if (aProc.ProcessName.ToString().Equals("opstarter"))
                {
                    processCount++;
                }
            }
            return processCount;
        }
    }
}
    




