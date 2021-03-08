using System.IO;

namespace Business.Lib
{
    public class ErrorsLogs
    {
        /// <summary>
        /// Method that write error in project directory.
        /// </summary>
        /// <param name="error">String error to write</param>
        public static void WriteError(string error)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            StreamWriter sw = new StreamWriter(startupPath + "\\errorsEmployees.txt");
            sw.WriteLine(error);
            sw.Close();
        }
    }
}
