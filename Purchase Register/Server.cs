using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Purchase_Register
{
    class Server
    {
        public void start()
        {
            Process process = new Process();
            process.StartInfo.FileName = "mongod.exe";
            process.StartInfo.WorkingDirectory = @"C:\Program Files\MongoDB\Server\3.2\bin";
            process.StartInfo.Arguments = @" --dbpath ""F:\Dropbox\Documents\Project\Purchase Register\DB""";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            process.Start();
        }
        public void stop()
        {
            Process[] pro = Process.GetProcessesByName("mongod");
            foreach(Process process in pro)
            {
                process.CloseMainWindow();
            }
        }
    }
}
