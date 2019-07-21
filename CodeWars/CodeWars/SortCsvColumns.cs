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
            List<string> rowList = new List<string>();

            while ((line = strReader.ReadLine()) != null)
            {
                rowList.Add(line);
            }

            int cols = rowList[0].Split(';').Count();
            int rows = rowList.Count();
            string[,] matrix = new string[rows, cols];
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < rows; i++)
            {
                string[] t = rowList[i].Split(';');
                for (int j=0; j< cols; j++)
                {
                    matrix[i, j] = t[j];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                List<string> col = new List<string>();
                for (int j = 1; j < rows; j++)
                {
                    col.Add(matrix[j,i]);
                }
                dict.Add(matrix[0, i],col);
            }

            SortedDictionary<string, List<string>> sorted = new SortedDictionary<string, List<string>>(dict);
            string keys = string.Join(";", sorted.Select(x => x.Key))+ "\r\n";
            string vals=string.Empty;

            for (int i = 0; i < rows-1; i++)
            {
                foreach (string k in sorted.Keys)
                {
                    List<string> te = sorted[k];
                    vals += te[i]+ ";";
                }
                vals += "\r\n";
            }

            return (keys+vals);
        }                   
    }
}

/*
if (i == 0)
                {
                    foreach (string s in temp)
                    {
                        csvz.Add(s, templ);
                    }
                }
                else
                {
                    int k = 0;
                    foreach (string z in tempList[0].Split(';'))
                    {
                        List<string> tt = new List<string>();
                        tt = csvz[z];
                        tt.Add(temp[k]);
                        csvz[z]=tt;
                        k++;
                    }
                    
                }
                i++;

    */