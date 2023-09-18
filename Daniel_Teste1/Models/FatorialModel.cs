namespace Daniel_Teste1.Models
{
    public class FatorialModel
    {
        public uint Numero { get; set; }
        public long Resultado => CalcularFatorial(Numero);

        private long CalcularFatorial(uint n)
        {
            if (n == 0) return 1;
            long fatorial = 1;
            for (uint i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}

