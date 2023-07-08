using Binance.Common;
using Binance.Spot;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TrandingBotClasses.Converte_Object_Json;

namespace TrandingBotClasses
{
    public class MBinance
    {




        public static Market Market = new Market();
        private Market cmarket { get; set; }
        JsonConversao jsonConversao = new JsonConversao();

        public MBinance() { }




        public MBinance(string apiKey, string apiSecret)
        {

            cmarket = new Market(baseUrl: "https://testnet.binance.vision", apiKey, apiSecret);

        }



        /// <summary>
        /// Verifica se é possivel se conectar com o servidor da Binance.
        /// </summary>
        public static async Task<bool> ServerConnectCheck()
        {
            try
            {
                await Market.TestConnectivity();
                return true;

            }
            catch (BinanceServerException ex) { return false; }

        }

        /// <summary>
        /// Verifica o preço atual de um par.<para />
        /// </summary>
        /// <param name="simbolo">Simbolo de trade, exemplo BNBUSDT.</param>
        public static async Task<double> PrecoSimbolo(string simbolo)
        {

            dynamic Simbol = JsonConvert.DeserializeObject(await Market.SymbolPriceTicker(simbolo));

            double result = Simbol.price;

            return result;

        }



        /// <summary>
        /// Verifica a quantidade minima para operar sobre o par.<para />
        /// </summary>
        /// <param name="par">Simbolo de trade, exemplo BNBUSDT.</param>

        public static async Task<decimal> MinimoPar(string par)
        {

            dynamic Minimo = JsonConvert.DeserializeObject(await Market.ExchangeInformation(par));

            var hj = Minimo.symbols;

            var symbolsJSON = JsonConvert.SerializeObject(hj);

            JArray symbols = JArray.Parse(symbolsJSON);

            var pre_filtersJSON = JsonConvert.SerializeObject(symbols[0]);

            var pre_filters = JsonConvert.DeserializeObject(pre_filtersJSON);

            var filtersJSON = JsonConvert.SerializeObject(pre_filters);

            dynamic filters = JsonConvert.DeserializeObject(filtersJSON);

            var filtersTrue = filters.filters[1];

            var LOT_SIZE_JSON = JsonConvert.SerializeObject(filtersTrue);

            dynamic LOT_SIZE = JsonConvert.DeserializeObject(LOT_SIZE_JSON);

            var result = LOT_SIZE.minQty;

            return result;


        }




    }

}
