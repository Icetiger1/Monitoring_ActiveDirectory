﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.DirectoryServices;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AD_Monitoring
{
    public class Modes
    {
        public static void mstsc(string cn)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            myprocess.StartInfo.FileName = ("mstsc.exe");
            myprocess.StartInfo.Arguments = ("/v:" + cn);
            myprocess.Start();
            myprocess.Close();
        }
        public static void compmgmt(string cn)
        {
            Cursor.Current = Cursors.WaitCursor;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            myprocess.StartInfo.CreateNoWindow = true;
            myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myprocess.StartInfo.UseShellExecute = false;
            myprocess.StartInfo.Verb = "runas";
            myprocess.StartInfo.FileName = "cmd.exe";
            myprocess.StartInfo.Arguments = "/k mmc.exe compmgmt.msc /computer:" + cn;
            myprocess.Start();
            myprocess.Close();
            Cursor.Current = Cursors.Default;
        }
        public static void CmRcViewer(string cn)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            string path = Application.StartupPath;
            myprocess.StartInfo.FileName = path + @"\ConfMgr 2012 Remote Tools\CmRcViewer.exe";
            myprocess.StartInfo.Arguments = (cn);
            myprocess.Start();
            myprocess.Close();
        } //не работает
        public static string PSLogin(string cn)
        {
            Cursor.Current = Cursors.WaitCursor;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            string ps = "Get-WMIObject -Class Win32_ComputerSystem -Computer \"" + cn + "\"|Select-Object Username";
            startInfo.Arguments = ps;

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.StandardOutputEncoding = Encoding.GetEncoding(866);

            Process myprocess = Process.Start(startInfo);
            string output = myprocess.StandardOutput.ReadToEnd();
            string us = default;
            try
            {
                string[] mass1 = output.Split('R');
                string text = mass1[1];
                us = text.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[1];
                myprocess.WaitForExit();
                myprocess.Close();
                Cursor.Current = Cursors.Default;
                return us;
            }
            catch
            {
                us = null;
                //fio = null;
                Cursor.Current = Cursors.Default;
                return us;
            }

        }
        public static void Open_disk(string cn)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            myprocess.StartInfo.FileName = "explorer.exe";
            myprocess.StartInfo.Arguments = @"\\" + cn + "\\c$";
            myprocess.Start();
            myprocess.Close();
        } 
        public static void Share_Folders(string cn)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            myprocess.StartInfo.FileName = "explorer.exe";
            myprocess.StartInfo.Arguments = @"\\" + cn + "\\";
            myprocess.Start();
            myprocess.Close();
        } 
        public static void ShutDown(string cn, string key, RichTextBox rich)
        {
            Cursor.Current = Cursors.WaitCursor;
            Process myprocess = new Process();
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            myprocess.StartInfo.CreateNoWindow = true;
            myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myprocess.StartInfo.UseShellExecute = true;
            myprocess.StartInfo.Verb = "runas";
            myprocess.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            myprocess.StartInfo.Arguments = @"/k shutdown /m \\" + cn + key;
            myprocess.Start();
            myprocess.Close();
            Cursor.Current = Cursors.Default;
        } 
        public static string Ping(string cn)
        {
            Cursor.Current = Cursors.WaitCursor;
            int timeout = 100;
            int maxTTL = 4;
            int bufferSize = 4;

            byte[] buffer = new byte[bufferSize];
            new Random().NextBytes(buffer);
            var scanInfo = new ScanInfo();
            using (var pinger = new Ping())
            {
                try
                {
                    for (int ttl = 1; ttl <= maxTTL; ttl++)
                    {

                        PingOptions options = new PingOptions(ttl, true);
                        PingReply reply = pinger.Send(cn, timeout, buffer, options);
                        if (reply.Status == IPStatus.Success || reply.Status == IPStatus.TtlExpired)
                        {
                            scanInfo.IP= reply.Address.ToString();
                        }
                        if (reply.Status != IPStatus.TtlExpired && reply.Status != IPStatus.TimedOut)
                        {
                            scanInfo.IP = reply.Address.ToString();
                        }
                        else
                        {
                            scanInfo.IP = null;
                        }
                    }
                    return scanInfo.IP;
                }

                catch
                {
                    scanInfo.IP = null;
                    return scanInfo.IP;
                }

            }
            Cursor.Current = Cursors.Default;
        }
        public static void Printers(string cn, RichTextBox rich)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ManagementScope scope = new ManagementScope(@"\\" + cn + @"\root\cimv2");
                scope.Connect();
                rich.Text += "Принтеры " + cn + ":" + Environment.NewLine;
                if (scope.IsConnected)
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\\" + cn + @"\root\cimv2", "SELECT * From Win32_Printer");
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        rich.Text += obj["Name"].ToString() + Environment.NewLine;
                    }
                }
                else
                {
                    rich.Text += "Нет данных" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        } 
        public static void LocalAdmin(string cn, RichTextBox rich)
        {
            using (DirectoryEntry machine = new DirectoryEntry("WinNT://" + cn))
            {
                try
                {
                    using (DirectoryEntry group = machine.Children.Find("Администраторы", "Group"))
                    {
                        object members = group.Invoke("Members", null);
                        rich.Text += "Локальные администраторы " + cn + Environment.NewLine;
                        foreach (object member in (IEnumerable)members)
                        {
                            string acc = new DirectoryEntry(member).Name;
                            var res = new string[2];
                            res[0] = cn;
                            res[1] = acc;
                            rich.Text += res[1] + Environment.NewLine;
                        }
                    }
                }
                catch
                {
                    using (DirectoryEntry group = machine.Children.Find("Administrators", "Group"))
                    {
                        object members = group.Invoke("Members", null);
                        rich.Text += "Локальные администраторы " + cn + Environment.NewLine;
                        foreach (object member in (IEnumerable)members)
                        {
                            string acc = new DirectoryEntry(member).Name;
                            var res = new string[2];
                            res[0] = cn;
                            res[1] = acc;
                            rich.Text += res[1] + Environment.NewLine;
                        }
                    }
                }
            }
        }
        public static void Send_msg(string address, string text)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\System32\";
            startInfo.WorkingDirectory = filepath;
            startInfo.FileName = filepath + @"\msg.exe";
            startInfo.UseShellExecute = true;
            startInfo.Arguments = "* /Server:" + address + " " + text;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process myprocess = Process.Start(startInfo);
            myprocess.WaitForExit();
            myprocess.Close();
        }  
    }
}
