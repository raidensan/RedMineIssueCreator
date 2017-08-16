/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.rtf', which is part of this source code package.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace redmine_outlook.Helper
{
    public static class MarkdownHelper
    {
        private static string MakeQuote(string source)
        {
            source = "> " + source;
            return Environment.NewLine + source.Replace(Environment.NewLine,  Environment.NewLine + "> ");
        }

        private static string RemoveLinks(string source)
        {
            return Regex.Replace(source, @"((http|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)", "");
        }

        public static string PrepareBody(string from, string to, string datetime, string body)
        {
            body = string.Format("Date: {0}{1}From: {2}{3}To: {4}{5}{6}",
                datetime, Environment.NewLine,
                from, Environment.NewLine,
                to, Environment.NewLine,
                RemoveLinks(body));
            return  MakeQuote(body);
        }
    }
}
