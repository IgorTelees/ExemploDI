namespace ExemploDI;

internal sealed class ServicoMostrarCicloDeVida(
    ITransientService ServicoTransient,
    IScopedService ServicoScoped,
    ISingletonService ServicoSingleton)

{
    private static void MostraServico<T>(T servico, string mensagem)
        where T : IReportServiceLifetime => Console.WriteLine($"{typeof(T).Name}: {servico.Id} ({mensagem})");

    public void MostrarDetalhes(string detalhes)
    {
        Console.WriteLine(detalhes);
        MostraServico(ServicoTransient, mensagem:"Muda sempre");
        MostraServico(ServicoScoped, mensagem:"Muda no escopo");
        MostraServico(ServicoSingleton, mensagem:"Nunca muda");
    }
}    