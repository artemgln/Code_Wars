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
            var csv = new Dictionary<string[], string[]>();

            List<string> tempList = new List<string>();

            int i = 0;
            while ((line = strReader.ReadLine()) != null)
            {
                tempList.Add(line);
                if (i > 0) { csv.Add(tempList[0].Split(';'), tempList[i].Split(';')); };
                i++;
            }
            //var keyys = tempList[0].Split(';');
            //csv.Add(keyys, null);


            return csvFileContent;
        }                   
    }
}
