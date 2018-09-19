
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
    class ExceptionInTextFile
    {
        static void Main(string[] args)
        {
        //    try
        //    {

        //        string str = string.Empty;
        //        if (string.IsNullOrEmpty(str))
        //        {
        //            throw new Exception("WrongData");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogging(ex);
        //        ReadError();
                
        //    }
        //}
        //public static void ErrorLogging(Exception exception)
        //{
        //    string filepath = @"D:\hello.txt";
        //    if (!File.Exists(filepath))
        //    {
        //        File.Create(filepath).Dispose();
        //    }
        //    using (StreamWriter writer = File.AppendText(filepath))
        //    {
        //        writer.WriteLine("===========ErrorLogging=============");
        //        writer.WriteLine("\n============Start====="+ DateTime.Now);
        //        writer.WriteLine("\nError Message" + exception.Message);
        //        writer.WriteLine("\nStackTrace" + exception.StackTrace);
        //        writer.WriteLine("\n===============END====================");
                
        //    }
        //}

        //public static void ReadError()
        //{
        //    string filepath = @"D:\check.txt";
        //    using (StreamReader streamReader = new StreamReader(filepath))
        //    {
        //        string Line;
        //        while((Line= streamReader.ReadLine()) != null)
        //        {
        //            Console.WriteLine(Line);
        //        }
        //    }
        }
       
    }
}
