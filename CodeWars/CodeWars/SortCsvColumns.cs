using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SortCsvColumns
    {
        public static string SortCsvCol(string csvFileContent)
        {
            StringReader strReader = new StringReader(csvFileContent);
            string line;
            Dictionary<int, string[]> csv = new Dictionary<int, string[]>();
            int i = 0;
            while ((line = strReader.ReadLine()) != null)
            {
                csv.Add(i, line.Split(';'));
                i++;
            }
            var array=csv.ToArray();
            return csvFileContent;
        }
    }
}
