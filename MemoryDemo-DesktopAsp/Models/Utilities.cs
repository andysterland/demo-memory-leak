using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MemoryDemo_DesktopAsp.Models
{
    public class Utilities
    {
        private static Random _rg = new Random();
        private static List<char> _allowed = null;
        private static List<char> _allowedChars
        {
            get
            {
                if (_allowed == null)
                {
                    _allowed = new List<char>();
                    for (char c = 'A'; c < 'Z'; c++)
                    {
                        _allowed.Add(c);
                    }
                    for (char c = 'a'; c < 'z'; c++)
                    {
                        _allowed.Add(c);
                    }
                    for (char c = '0'; c < '9'; c++)
                    {
                        _allowed.Add(c);
                    }
                }
                return _allowed;
            }
        }


        private static Dictionary<string, bool> _usedIds = new Dictionary<string, bool>();

        public static string GenerateRandomString(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(_allowedChars[_rg.Next(0, _allowedChars.Count)]);
            }
            return sb.ToString();
        }

        public static string GetPageTrackingId()
        {
            string id = string.Empty;

            id = Utilities.GenerateRandomString(256);

            if (!_usedIds.ContainsKey(id))
            {
                _usedIds.Add(id, true);
            }

            return id;
        }
    }
}