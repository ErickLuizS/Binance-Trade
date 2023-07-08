using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TrandingBotClasses.Context;

namespace TrandingBotClasses
{
    public static class Usuario
    {

        static private string nome { get; set; }
        static private string senha { get; set; }
 
        public static SqlServerContext SqlServer = new SqlServerContext();
        public static SqlCipherContext SqlCipher = new SqlCipherContext();


        public static List<Cliente> Clientes = SqlCipher.Clientes.Include(p => p.Conta).Include(p => p.Sheets).ToList();

       
        /// <summary>
        /// Testa se é possivel a conexao com o banco de dados é possível.<para />
        /// </summary>
        /// <returns>True ou False.</returns>
        public static bool TestarConexao()
        {
            var contexto = new SqlServerContext();
            
            bool result = contexto.Database.CanConnect();
         
            return result;
               

        }

        /// <summary>
        /// Verifica se o horario do Servdir da Binance é a mesma do horario local.<para />
        /// </summary>
        /// <returns>True ou False.</returns> 
        public static async Task<bool> TestarHorarioServidor()
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://api.binance.com/api/v3/time");
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic responseObject = JsonConvert.DeserializeObject(responseContent);
            long serverTime = responseObject.serverTime;

            // Converte o tempo do servidor em Unix para DateTimeOffset
            DateTimeOffset serverTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(serverTime);

            // Obtém a hora atual do PC em UTC
            DateTimeOffset horaPC = DateTimeOffset.UtcNow;

            // Calcula a diferença entre as horas do PC e do servidor
            if (serverTimeOffset == horaPC) { return true; }
            else { return false; }
        }




















    }
}
