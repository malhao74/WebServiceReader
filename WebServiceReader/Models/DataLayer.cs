using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebServiceReader
{
    /// <summary>
    /// Fetch a quote from the QuoteWebService
    /// </summary>
    public static class DataLayer
    {
        public static QuoteModel Get()
        {
            QuoteWebService.QuoteWebServiceClient quoteWebServiceClient = new QuoteWebService.QuoteWebServiceClient();
            string quoteJson = "";

            try
            {
                // Call the web service 
                quoteJson = quoteWebServiceClient.RandomQuote();
            }
            catch (Exception ex)
            {
                //throw new HttpException("The web service is not working...");
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                quoteWebServiceClient.Close();
            }

            // Deserialize the json string returned by the web service
            QuoteModel quote = JsonConvert.DeserializeObject<QuoteModel>(quoteJson);

            return quote;
        }
    }
}