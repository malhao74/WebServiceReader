using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebServiceReader.Models
{
    public class DataLayer
    {
        public static QuoteModel Get()
        {
            QuoteWebService.QuoteWebServiceClient quoteWebServiceClient = new QuoteWebService.QuoteWebServiceClient();
            string quoteJson = "";

            try
            {
                // Call the web service 
                quoteJson = quoteWebServiceClient.GetQuote();
                quoteWebServiceClient.Close();
            }
            catch (Exception)
            {
                //throw new HttpException("The web service is not working...");
                return null;
            }

            // Deserialize the json string returned by the web service
            QuoteModel quote = JsonConvert.DeserializeObject<QuoteModel>(quoteJson);

            return quote;
        }
    }
}