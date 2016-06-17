using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace BusinessObjects
{
    public class Utils
    {
        private static ArrayList _filters;
        public static ArrayList Filters
        {
            get
            {
                if (_filters == null)
                {
                    _filters = new ArrayList();
                }
                return _filters;
            }
        }
        
        public static string FilterPath = System.Environment.CurrentDirectory + "\\syncFilter.ini";
        public static void readFilters()
        {
            Filters.Clear();
            StreamReader sr = new StreamReader(FilterPath, Encoding.UTF8);
            string filterText;
            while ((filterText = sr.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    //the line is white space or empty line, just keep it

                    continue;
                }
                else
                {
                    Filters.Add(filterText);
                }
            }
            sr.Close();
        }

        public static void addFilter(string filterText)
        {
            Filters.Add(filterText);
            StreamWriter wr = new StreamWriter(FilterPath,true);
            wr.WriteLine(filterText);
            wr.Close();
        }

        public static void deleteFilter(string filterText)
        {
            Filters.Remove(filterText);
            StreamWriter sw = new StreamWriter(FilterPath, false);
            foreach (var filter in Filters)
            {
                sw.WriteLine(filter);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
