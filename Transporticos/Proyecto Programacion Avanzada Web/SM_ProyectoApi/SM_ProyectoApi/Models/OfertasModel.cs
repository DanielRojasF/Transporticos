namespace SM_ProyectoApi.Models
{
    public class OfertasModel
    {
        public long Id { get; set; }
        public long IdPuesto { get; set; }
        public string? Nombre { get; set; }
        public decimal Salario { get; set; }
        public string? Horario { get; set; }
        public int Cantidad { get; set; }
    }
}
