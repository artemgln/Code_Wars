﻿using System;
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
            string keys = string.Join(";", sorted.Select(x => x.Key))+ "\n";
            string vals=string.Empty;

            for (int i = 0; i < rows-1; i++)
            {
                foreach (string k in sorted.Keys)
                {
                    List<string> te = sorted[k];
                    vals += te[i]+ ";";
                }
                vals = vals.Remove(vals.Length - 1);
                vals += "\n";
            }

            vals = vals.Remove(vals.Length - 2);
            return (keys+vals);
        }

        public static string SortCsvCol2(string csvFileContent)
        {
            var lines = csvFileContent.Split('\n').Select(line => line.Split(';')).ToArray();
            var indices = lines[0].Select((x, i) => new { Value = x, Index = i }).OrderBy(x => x.Value).Select(x => x.Index).ToArray();
            return string.Join("\n", lines.Select(line => string.Join(";", indices.Select(i => line[i]))));
        }

        public static string SortCsvCol3(string csvFileContent)
        {
            var csv = csvFileContent.Split('\n').Select(x => x.Split(';')).ToArray();
            return Enumerable.Range(0, csv[0].Length).Select(i => csv.Select(t => t[i])).OrderBy(x => x.ElementAt(0)).Aggregate((a, b) => a.Zip(b, (c, d) => $"{c};{d}").ToList()).Aggregate((a, b) => $"{a}\n{b}");
        }
    }
}