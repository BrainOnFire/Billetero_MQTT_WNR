using System;
using System.IO;


public class CFileIO
{
    static public void WriteTextFile(string FileNameStub, string FileContents)
    {
        StreamWriter sw;
        string fileName;
        string logDir = "TEBS_Logs\\" + DateTime.Now.ToLongDateString();
        // if the log dir doesn't exist, create it 
        if (!Directory.Exists(logDir))
        {
            Directory.CreateDirectory(logDir);
        }
            
        // name this log as current time with name of validator at start
        fileName = FileNameStub + " at " + DateTime.Now.ToString("HH mm ss") + ".txt";
        // create/open the file
        sw = File.AppendText(logDir + "\\" + fileName);
        sw.Write(FileContents);
        sw.Close();
    }
}