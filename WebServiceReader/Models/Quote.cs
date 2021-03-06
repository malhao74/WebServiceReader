﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceReader
{
    /// <summary>
    /// Class to map the webservice information
    /// </summary>
    public class QuoteModel
    {
        public string Quote { get; }
        public string Author { get; }
        public string Cat { get; }

        public QuoteModel(string quote, string author, string cat)
        {
            Quote = quote;
            Author = author;
            Cat = cat;
        }
    }
}