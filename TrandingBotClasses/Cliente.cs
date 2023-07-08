namespace TrandingBotClasses
{
    public class Cliente
    {

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }


        public Guid CBinanceId { get; set; }
        public Guid GoogleSheetsId { get; set; }



        public virtual CBinance Conta { get; set; }

        public virtual GoogleSheets Sheets { get; set; }


        public Cliente() { }


        public Cliente(string nome) { Nome = nome; }



        /// <summary>
        /// Calcula a porcentagem de um total.
        /// </summary>
        /// <returns>porcentagem do total.</returns>
        public static double porcentagem(double porcentagem, double total)
        {
            return (porcentagem / 100) * total;
        }



















































    }
}
