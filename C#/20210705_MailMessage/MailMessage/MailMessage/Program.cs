using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Toolkit.Uwp.Notifications;

namespace MailMessage
{
    
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            MyData getDirekt = new MyData();
            FileSystemWatcher watcher = new FileSystemWatcher(getDirekt.GetData());
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            //watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            //watcher.Deleted += OnDeleted;
            //watcher.Renamed += OnRenamed;
            //watcher.Error += OnError;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;



            //Console.WriteLine("Press enter to exit.");
            //Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
            
        }
        //public static ToastContentBuilder MyMessage = new ToastContentBuilder();
        
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Changed: {e.FullPath}");
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"�����: {e.Name}";
            //Console.WriteLine(value);
            //���� if �������, �� ����������� � �������� � ����������
            // if (!value.Contains(@"\")) 
            //{
            //MessageBox.Show(value);
            //new ToastContentBuilder().AddText(value).Show();
            new ToastContentBuilder()
                .AddText(value)
                .Show();
            //}

        }

        private static void OnDeleted(object sender, FileSystemEventArgs e) =>
            Console.WriteLine($"Deleted: {e.FullPath}");

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Renamed:");
            Console.WriteLine($"    Old: {e.OldFullPath}");
            Console.WriteLine($"    New: {e.FullPath}");
        }

        // private static void OnError(object sender, ErrorEventArgs e) =>
        // PrintException(e.GetException());

        /* private static void PrintException(Exception? ex)
         {
             if (ex != null)
             {
                 Console.WriteLine($"Message: {ex.Message}");
                 Console.WriteLine("Stacktrace:");
                 Console.WriteLine(ex.StackTrace);
                 Console.WriteLine();
                 PrintException(ex.InnerException);
             }
         }*/

    }
    class MyData
    {
        public string month;
        public string month0;
        public string day;
        public string direkt;

        public string GetData()
        {
            DateTime thisday = DateTime.Today;
            if (thisday.Day.ToString().Length == 1)
            {
                day = "0" + thisday.Day.ToString();
            }
            if (thisday.Month == 1)
            {
                month = "������";
                month0 = "01";
            }
            if (thisday.Month == 2)
            {
                month = "�������";
                month0 = "02";
            }
            if (thisday.Month == 3)
            {
                month = "����";
                month0 = "03";
            }
            if (thisday.Month == 4)
            {
                month = "������";
                month0 = "04";
            }
            if (thisday.Month == 5)
            {
                month = "���";
                month0 = "05";
            }
            if (thisday.Month == 6)
            {
                month = "����";
                month0 = "06";
            }
            if (thisday.Month == 7)
            {
                month = "����";
                month0 = "07";
            }
            if (thisday.Month == 8)
            {
                month = "������";
                month0 = "08";
            }
            if (thisday.Month == 9)
            {
                month = "��������";
                month0 = "09";
            }
            if (thisday.Month == 10)
            {
                month = "�������";
                month0 = "10";
            }
            if (thisday.Month == 11)
            {
                month = "������";
                month0 = "11";
            }
            if (thisday.Month == 12)
            {
                month = "�������";
                month0 = "12";
            }
            return direkt = "\\\\tal\\mail\\" + thisday.Year.ToString() + "\\" + month + "\\" + day + "_" + month0 + "_" + thisday.Year.ToString();
        }
    }
}
