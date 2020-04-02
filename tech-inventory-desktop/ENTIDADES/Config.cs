using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System;

namespace ENTIDADES
{
    public static class Config
    {
        public static string usuario { get; set; }
        public static string clave { get; set; }
        private static SqlConnection connection { get; set; }
        /// <summary>
        /// Obtiene la conexión a la base de datos.
        /// </summary>
        /// <returns>Retorna la conexión a la base de datos.</returns>
        public static SqlConnection getConnection()
        {
            if (connection == null)
                connection = new SqlConnection(string.Format("Data Source=.\\SOFTWARE;Initial Catalog=PCSOFT;Integrated Security=False;User ID={0};Password={1};Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True", usuario, clave));

            if (connection.State == ConnectionState.Open)
                connection.Close();

            return connection;
        }
        /// <summary>
        /// Apertura la conexión a la base de datos de la SqlConnection que sea proporcionada al metodo.
        /// </summary>
        /// <param name="connection">Especifica la conexión que quiere aperturarse.</param>
        public static void openConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        /// <summary>
        /// Cierra la conexión a la base de datos de la SqlConnection que sea proporcionada al metodo.
        /// </summary>
        /// <param name="connection">Especifica la conexión que quiere cerrarse.</param>
        public static void closeConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        /// <summary>
        /// Realiza un binding hacia un grid view para mostrar las propiedades de un una coleccion <list type="T"></list> y sus subobjetos
        /// permitiendo mostrar sub objetos en el grid.
        /// </summary>
        /// <param name="property">Objeto enlazado a datos que ha rellenado la fila</param>
        /// <param name="propertyName">Nombre de la propiedad bindeable en el grid view</param>
        /// <returns></returns>
        public static string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }
    }
}
