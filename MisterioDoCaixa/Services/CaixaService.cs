namespace MisterioDoCaixa.Services;

public class CaixaService
{
    public int CalcularTotal()
    {
        int[] vendas = { 100, 200, 50 };
        int total = 0;

        for (int i = 0; i < vendas.Length; i++)
        {
            total = vendas[i];
        }

        return total;
    }
}
