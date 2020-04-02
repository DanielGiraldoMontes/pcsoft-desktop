using ENTIDADES;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDEquipos
    {

        private SqlConnection connection { get; set; }

        public CDEquipos()
        {
            connection = Config.getConnection();
        }

        public List<CEMarca> CargarMarcas()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MARCA_ID, MARCA_DESC FROM INV.MARCA ORDER BY MARCA_DESC ASC", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<CEMarca> marcas = new List<CEMarca>();
            while (reader.Read())
                marcas.Add(new CEMarca
                {
                    id = reader.GetInt32(0),
                    descripcion = reader.GetString(1)
                });

            reader.Close();
            Config.closeConnection(connection);
            return marcas;
        }
        public List<CEModelo> CargarModelos(CEMarca marca)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MODELO_ID, MODELO_DESC FROM INV.MODELO WHERE MARCA_ID = '" + marca.id + "'ORDER BY MODELO_DESC ASC", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<CEModelo> modelos = new List<CEModelo>();
            while (reader.Read())
                modelos.Add(new CEModelo
                {
                    id = reader.GetInt32(0),
                    descripcion = reader.GetString(1)
                });

            reader.Close();
            Config.closeConnection(connection);
            return modelos;
        }
        public DataSet CargarEquiposTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CE");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.EQUIPOS");
            Config.closeConnection(connection);
            return dt;
        }
        public DataSet CargarEquiposDisponibles()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CED");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.EQUIPOS");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEEquipo> CargarEquiposPorEmpleado(string EmpCedula)
        {
            Config.openConnection(connection);
            List<CEEquipo> equipoAsignar = new List<CEEquipo>();
            SqlCommand command = new SqlCommand("INV.EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CEE");
            command.Parameters.AddWithValue("@EMP_CEDULA", EmpCedula);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                equipoAsignar.Add(new CEEquipo
                {
                    equipoCodigo = reader.GetString(0),
                    equipoDescripcion = reader.GetString(1),
                    proveedorNombreCorto = reader.GetString(2),
                    fechaIngreso = reader.GetDateTime(3).ToString("yyyy-MM-dd"),
                    observacion = reader.GetString(4)
                });
            }
            reader.Close();
            Config.closeConnection(connection);
            return equipoAsignar;
        }
        public int AgregarMarca(CEMarca marca)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.AGREGAR_MARCA @MARCA", connection);
            command.Parameters.AddWithValue("MARCA", marca.descripcion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarModelo(CEMarca marca, CEModelo modelo)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.AGREGAR_MODELO @MARCA, @MODELO", connection);
            command.Parameters.AddWithValue("MARCA", marca.id);
            command.Parameters.AddWithValue("MODELO", modelo.descripcion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarEquipo(CEEquipo equipo)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IE");
            command.Parameters.AddWithValue("@EQ_CODIGO", equipo.equipoCodigo);
            command.Parameters.AddWithValue("@EQ_DESCRIPCION", equipo.equipoDescripcion);
            command.Parameters.AddWithValue("@EQ_MODELO", equipo.modelo.id);
            command.Parameters.AddWithValue("@EQ_SERIAL", equipo.equipoSerial);
            command.Parameters.AddWithValue("@EQ_ESTADO", equipo.equipoEstado);
            command.Parameters.AddWithValue("@EMP_CEDULA", equipo.documento);
            command.Parameters.AddWithValue("@PROV_NIT", equipo.proveedorDocumento);
            command.Parameters.AddWithValue("@EQ_FECHAINGRESO", equipo.fechaIngreso);
            command.Parameters.AddWithValue("@EQ_FECHASALIDA", equipo.fechaSalida);
            command.Parameters.AddWithValue("@EQ_OBSERVACION", equipo.observacion);
            command.Parameters.AddWithValue("@EQ_PROYECTO", equipo.proyecto.id);
            command.Parameters.AddWithValue("@EQ_SEDE", equipo.sede.id);
            command.Parameters.AddWithValue("@EQ_UBICACION", equipo.ubicacion.id);
            command.Parameters.AddWithValue("@EQ_PUESTO", equipo.numeroPuesto);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int ActualizarEquipo(CEEquipo equipo)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "UE");
            command.Parameters.AddWithValue("@EQ_CODIGO", equipo.equipoCodigo);
            command.Parameters.AddWithValue("@EQ_DESCRIPCION", equipo.equipoDescripcion);
            command.Parameters.AddWithValue("@EQ_MODELO", equipo.modelo.id);
            command.Parameters.AddWithValue("@EQ_SERIAL", equipo.equipoSerial);
            command.Parameters.AddWithValue("@PROV_NIT", equipo.proveedorDocumento);
            command.Parameters.AddWithValue("@EQ_FECHAINGRESO", equipo.fechaIngreso);
            command.Parameters.AddWithValue("@EQ_OBSERVACION", equipo.observacion);
            command.Parameters.AddWithValue("@EQ_ESTADO", equipo.equipoEstado);
            command.Parameters.AddWithValue("@EQ_PROYECTO", equipo.proyecto.id);
            command.Parameters.AddWithValue("@EQ_SEDE", equipo.sede.id);
            command.Parameters.AddWithValue("@EQ_UBICACION", equipo.ubicacion.id);
            command.Parameters.AddWithValue("@EQ_PUESTO", equipo.numeroPuesto);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
    }
}
