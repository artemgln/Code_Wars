using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;

namespace CodeWars
{
    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            const string alp = "{abcdefghijklmnopqrstuvwxyz";
            List<string> lett = new List<string>();

            for (int i = 0; i < alp.Length; i++)
            {
                lett.Add(alp.Substring(i, 1));
            }

            Array txt = new Array[text.Length];
            text = text.ToLower();
            txt = text.ToCharArray();


            string result = "";

            foreach (char el in txt)
            {
                int temp = lett.IndexOf(el.ToString());
                if (temp > 0)
                {
                    result = result + temp + " ";
                }

            }
            if (result.Length > 0) result = result.Remove(result.Length - 1, 1);
            return result;
        }
    }

    public static class ReplaceWithAlphabetPosition2
    {
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }

public static class ReplaceWithAlphabetPosition3
    {
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower()
                                                  .Where(c => char.IsLetter(c))
                                                  .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
                                                  .ToArray());
        }
    }
}

