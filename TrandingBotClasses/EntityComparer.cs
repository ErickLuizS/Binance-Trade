namespace TrandingBotClasses
{
    public class ClienteComparer : IEqualityComparer<Cliente>
    {
        /// <summary>
        /// Verifica se os clientes sao o mesmo 
        /// </summary>
        /// <returns>True ou False.</returns>    
        public bool Equals(Cliente x, Cliente y)
        {
            if (x == null && y == null)
            {
                return true;
            }
            else if (x == null || y == null)
            {
                return false;
            }
            else
            {
                return x.ClienteId == y.ClienteId;
            }
        }

        /// <summary>
        /// Retorna o código hash para esta instância.
        /// </summary>
        /// <returns>Um código hash de 32 bits, com sinal, inteiro.</returns>    
        public int GetHashCode(Cliente obj)
        {
            return obj.ClienteId.GetHashCode();
        }
    }
}
