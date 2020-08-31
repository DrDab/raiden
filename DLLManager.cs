using System;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace Raiden
{
    class DLLManager
    {
        static NamedPipeServerStream read_server;
        static NamedPipeServerStream write_server;
        static Process process;
        static StreamWriter writer;
        const string process_name = "Among Us.exe";

        static private void Process_Exited(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        static public void SetProcess()
        {
            Process[] processes = Process.GetProcessesByName(
                Path.GetFileNameWithoutExtension(process_name));

            if (processes.Length == 0)
            {
                MessageBox.Show("Raiden cannot run if Among Us isn't running.",
                    "Game not running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }

            process = processes[0];

            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(Process_Exited);
        }

        static void RunInjector(string dll_name, string option)
        {
            Process injector = new Process();
            injector.StartInfo.FileName = "Injector.exe";
            injector.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            injector.StartInfo.Arguments = "-p " + process.Id.ToString() +
                " " + option + " " + dll_name;
            injector.Start();
            injector.WaitForExit();
        }

        static void InjectDLL(string dll_name)
        {
            RunInjector(dll_name, "-i");
        }

        static void EjectDLL(string dll_name)
        {
            RunInjector(dll_name, "-e");
        }

        static public void StartDLLs()
        {
            EjectDLLs();
            InjectDLLs();
            Program.client_form.Print("DLLs injected.");
        }

        static public void InjectDLLs()
        {
            // Kill any unused Injector processes.
            foreach (var process in Process.GetProcessesByName("Injector"))
            {
                process.Kill();
            }
            DLLManager.InjectDLL("SigScan.dll");
            DLLManager.InjectDLL("RaidenDLL.dll");
        }

        static public void EjectDLLs()
        {
            DLLManager.EjectDLL("RaidenDLL.dll");
            DLLManager.EjectDLL("SigScan.dll");
        }

        

        static public void Listen()
        {
            Task.Run(() =>
            {
                read_server = new NamedPipeServerStream("raidenreveal");
                read_server.WaitForConnection();
                StreamReader reader = new StreamReader(read_server);
                while (true)
                {
                    string data = reader.ReadLine();
                    HackManager.HandleLine(data);
                }
            });
            Task.Run(() =>
            {
                write_server = new NamedPipeServerStream("raidencolor");
                write_server.WaitForConnection();
                writer = new StreamWriter(write_server);
            });
            
        }

        static public void Send(string data)
        {
            
            writer.Write(data);
            writer.Write((char)0);
            writer.Flush();
        }
    }
}
