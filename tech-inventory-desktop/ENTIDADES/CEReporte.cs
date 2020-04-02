using System.Data;

namespace ENTIDADES
{
    public class CEReporte
    {
        public string Proyecto { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public DataSet Data { get; set; }
        public string RutaBackUp { get; set; }
    }
}
