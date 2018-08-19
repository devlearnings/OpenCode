using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static string Outputs = "";
        public static string Errors = "";
        public static StreamReader PsftpOutput;
        public static StreamReader PsftpError;
        public static StreamWriter sw;

        static void Main(string[] args)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"F:\Users\Jay\Desktop\sftp-client\sftp.exe";
            processStartInfo.Arguments = "-b test.batch -S ./ssh.exe -i \"E:\\SFTP_ROOT\\sftp001\\id_rsa_sftp001\" -o UserKnownHostsFile=\"F:\\cygwin64\\home\\Jay\\.ssh\\known_hosts\" sftp001@192.168.0.102:/eventlist";
            //processStartInfo.Arguments = "-b test.batch -S ./ssh.exe -pw \"1122\" -o UserKnownHostsFile=\"F:\\cygwin64\\home\\Jay\\.ssh\\known_hosts\" sftp001@192.168.0.102:/eventlist";
            //processStartInfo.Arguments = "-b test.batch -S ./ssh.exe -i \"E:\\SFTP_ROOT\\sftp001\\id_rsa_sftp001\" sftp001@192.168.0.102:/eventlist";
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.UseShellExecute = false;

            Process p = new Process();
            p.StartInfo = processStartInfo;
            p.Start();

            PsftpOutput = p.StandardOutput;
            PsftpError = p.StandardError;
            sw = p.StandardInput;
            //sw.WriteLine("yes");

            Read(p).Wait();
            PsftpOutput.Close();
            PsftpError.Close();
            p.WaitForExit();

            Console.ReadLine();
        }

        static async Task Read(Process p)
        {
            var result = await PsftpOutput.ReadToEndAsync();
            Console.WriteLine(result);
        }
    }
}
