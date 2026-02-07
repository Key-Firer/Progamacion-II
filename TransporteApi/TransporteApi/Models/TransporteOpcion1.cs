namespace TransporteApi.Controllers
{
    public class TransporteOpcion
    {
        public int Id { get; set; }
        public string Medio { get; set; }
        public int DistanciaKm { get; set; }
        public int CostoEstimado { get; set; }
    }
}