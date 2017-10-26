﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
using System;
using System.Text.RegularExpressions;
using Scriban.Runtime;

namespace Scriban.Functions
{
    /// <summary>
    /// Html functions available through the object 'html' in scriban.
    /// </summary>
    public class HtmlFunctions : ScriptObject
    {
        public static string Strip(TemplateContext context, string text)
        {
            if (text == null) return null;
            // From https://stackoverflow.com/a/17668453/1356325
            const string RegexMatchHtml = @"<script.*?</script>|<!--.*?-->|<style.*?</style>|<(?:[^>=]|='[^']*'|=""[^""]*""|=[^'""][^\s>]*)*>";
#if NET35 || NET40 || PCL328
            var matchHtml = new Regex(RegexMatchHtml, RegexOptions.IgnoreCase|RegexOptions.Singleline);
#else
            var matchHtml = new Regex(RegexMatchHtml, RegexOptions.IgnoreCase|RegexOptions.Singleline, context.RegexTimeOut);
#endif
            return matchHtml.Replace(text, string.Empty);
        }

#if !PCL328
        public static string Escape(string text)
        {
            if (text == null) return null;
#if NET35
            return System.Web.HttpUtility.HtmlEncode(text);
#else
            return System.Net.WebUtility.HtmlEncode(text);
#endif
        }
        
        public static string UrlEncode(string text)
        {
            if (text == null) return null;
            return Uri.EscapeDataString(text);
        }

        public static string UrlEscape(string text)
        {
            if (text == null) return null;
            return Uri.EscapeUriString(text);
        }
#endif
    }
}
