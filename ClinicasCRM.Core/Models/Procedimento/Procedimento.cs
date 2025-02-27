﻿using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Procedimento;
public class Procedimento : EntidadeBase
{
    public string NomeProcedimento { get; set; } = string.Empty;
    public int Duracao { get; set; }
    public string EquipamentosUtilizados { get; set; } = string.Empty;
    public string ConsumoProdutos { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public EFormaPagamento FormaPagamento { get; set; }
    public List<Agendamento.Agendamento> Agendamentos { get; set; } = new List<Agendamento.Agendamento>();
}
