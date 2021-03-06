﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyInventory.API.Tests.Infrastructure
{
    public class Substituter
    {
        private readonly IDictionary<string, string> _substituteMap = new Dictionary<string, string>();
        public void AddSubstitute(string key, string value)
        {
            _substituteMap["{" + key + "}"] = value;
        }

        public string SubstitueKeys(string s)
        {
            var match = SubstituteMatches(s);
            return ReplaceMatches(s, match);
        }

        private static MatchCollection SubstituteMatches(string s)
        {
            return Regex.Matches(s, "{.*?}+");
        }

        private string ReplaceMatches(string s, MatchCollection match)
        {
            for (var i = 0; i < match.Count; i++)
            {
                var key = match[i].Value;
                if (_substituteMap.ContainsKey(key))
                {
                    s = s.Replace(key, _substituteMap[key]);
                }
                else
                {
                    Console.WriteLine("WARN: Potential missing key in context \"" + key + "\"");
                }
            }
            return s;
        }   
    }
}