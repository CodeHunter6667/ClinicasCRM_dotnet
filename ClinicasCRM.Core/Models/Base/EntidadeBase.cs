namespace ClinicasCRM.Core.Models.Base;
public class EntidadeBase
{
    public long Id { get; set; }
    public string UsuarioCriacao { get; set; } = string.Empty;
    public bool EstaSalva { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public DateTime? DataAlteracao { get; set; }
    public string UsuarioAlteracao { get; set; } = string.Empty;
    public long UsuarioId { get; set; }
}
