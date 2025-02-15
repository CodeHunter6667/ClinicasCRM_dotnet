using Newtonsoft.Json;

namespace ClinicasCRM.Api.Handlers;

public class ErrodDetail
{
    public string? Message { get; set; }
    public int StatusCode { get; set; }
    public string? Trace { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}