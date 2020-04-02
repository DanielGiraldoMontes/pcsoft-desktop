using System.Collections.Generic;
using System.Data;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CNEquipos
    {

        private CDEquipos equipos = new CDEquipos();

        public List<CEMarca> CargarMarcas()
        {
            return equipos.CargarMarcas();
        }
        public List<CEModelo> CargarModelos(CEMarca marca)
        {
            return equipos.CargarModelos(marca);
        }
        public DataSet CargarEquiposTableFilter()
        {
            return equipos.CargarEquiposTableFilter();
        }
        public DataSet CargarEquiposDisponibles()
        {
            return equipos.CargarEquiposDisponibles();
        }
        public List<CEEquipo> CargarEquiposPorEmpleado(string empleadoDocumento)
        {
            return equipos.CargarEquiposPorEmpleado(empleadoDocumento);
        }
        public int AgregarMarca(CEMarca marca)
        {
            return equipos.AgregarMarca(marca);
        }
        public int AgregarModelo(CEMarca marca, CEModelo modelo)
        {
            return equipos.AgregarModelo(marca, modelo);
        }
        public int AgregarEquipo(CEEquipo equipo)
        {
            return equipos.AgregarEquipo(equipo);
        }
        public int ActualizarEquipo(CEEquipo equipo)
        {
            return equipos.ActualizarEquipo(equipo);
        }
    }
}
