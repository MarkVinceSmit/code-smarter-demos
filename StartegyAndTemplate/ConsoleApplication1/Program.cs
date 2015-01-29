using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            printReport();
            Reporter rep = new DirectoryReporter();
            rep.PrintReport(new ConsoleOutputter());
        }


        private static void printReport()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\");
            Console.WriteLine("Report for " + di.FullName);
            Console.WriteLine("Filename        Size            Date");

            di.GetFiles("*.*").ToList().ForEach( (file) =>
            {
                Console.WriteLine(" {0:25} {1:12} {2:20}", file.Name, file.Length, file.LastWriteTimeUtc);
            });

            Console.WriteLine("This report was generated on " + DateTime.Now.ToLongDateString());


            // Header
            // columns 
            // rows
            // footer
        }

    }

    public class DirectoryReporter : Reporter
    {
        DirectoryInfo di = new DirectoryInfo(@"C:\");

        public override string getFooter()
        {
            return "This report was generated on " + DateTime.Now.ToLongDateString();
        }

        public override string getHeader()
        {
            return "Report for " + di.FullName;
        }

        public override List<string> getColumns()
        {
           return new List<string>() { "Filename", "Size", "Date" };
        }

        public override List<List<string>> getRows()
        {
            List<List<string>> result = new List<List<string>>();
            di.GetFiles("*.*").ToList().ForEach((fileinfo) =>
            {
                result.Add(new List<string>() { fileinfo.FullName, fileinfo.Length.ToString(), fileinfo.LastWriteTimeUtc.ToString()});
            });

            return result;
        }
    }



    public abstract class Reporter    
    {

        public void PrintReport(IOutput output)
        {
            output.WriteLine(getHeader());

            getColumns().ForEach((col) => output.Write(col + "  "));
            
            getRows().ForEach((row) =>
            {
                row.ForEach((coldata) =>
                {
                    output.WriteLine(coldata);
                });
                output.WriteLine("");
            });
            output.WriteLine(getFooter());
        }

        public abstract string getFooter();
        public abstract string getHeader();
        public abstract List<string> getColumns();
        public abstract List<List<string>> getRows();

    }

    public interface IOutput
    {
        void Write(string msg);
        void WriteLine(string msg);
    }

    public class ConsoleOutputter : IOutput
    {
        public void Write(string msg)
        {
            Console.Write(msg  );
        }

        public void WriteLine(string msg)
        {
            Console.WriteLine(  msg );
        }
    }

}
