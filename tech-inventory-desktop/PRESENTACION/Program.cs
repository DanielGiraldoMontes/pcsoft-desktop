using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
	static class Program
	{
        public static string usuario { get; set; }
        public static string clave { get; set; }
        public static string conexion { get; set; }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Inicio.Login());
		}
        static string Connection (){
            return conexion = string.Format("Data Source=gfisoft.database.windows.net;Initial Catalog=PCSOFT;Integrated Security=False;User ID={0};Password={1};Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", usuario, clave);
        }
	}
}
