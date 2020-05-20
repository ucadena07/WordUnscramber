using System;
using System.IO;

namespace WordUnscramber1.Workers
{
    public class FileReader
    {
        
        public string[] Read(string filename)
        {
            string[] fileContent;
            try
            {
                fileContent = File.ReadAllLines(filename);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileContent;
        }
    }
}
