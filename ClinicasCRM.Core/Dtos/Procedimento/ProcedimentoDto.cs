using ClinicasCRM.Core.Enums;

namespace ClinicasCRM.Core.Dtos.Procedimento;
public class ProcedimentoDto
{
    public long Id { get; set; }
    public bool EstaSalva { get; set; }
    public string NomeProcedimento { get; set; } = string.Empty;
    public int Duracao { get; set; }
    public string EquipamentosUtilizados { get; set; } = string.Empty;
    public string ConsumoProdutos { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public EFormaPagamento FormaPagamento { get; set; }

    public ProcedimentoDto(Models.Procedimento.Procedimento procedimento)
    {
        Id = procedimento.Id;
        EstaSalva = procedimento.EstaSalva;
        NomeProcedimento = procedimento.NomeProcedimento;
        Duracao = procedimento.Duracao;
        EquipamentosUtilizados = procedimento.EquipamentosUtilizados;
        ConsumoProdutos = procedimento.ConsumoProdutos;
        Preco = procedimento.Preco;
        FormaPagamento = procedimento.FormaPagamento;
    }
}
