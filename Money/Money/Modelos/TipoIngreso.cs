using Money.Clases;
using Money.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money.Modelos
{
    class TipoIngreso
    {
        public int IDTipoIngreso { get; set; }
        public string Denominacion { get; set; }

        public static bool Guardar(TipoIngreso tipoIngreso, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Denominacion", tipoIngreso.Denominacion),
                new Parametro("@IDTipoIngreso", tipoIngreso.IDTipoIngreso),
                new Parametro("@Editar", editar)
            };

            return DBDatos.Ejecutar("TipoIngreso_Agregar", parametros);
        }

        internal static void ListarCombo(object comboBox)
        {
            throw new NotImplementedException();
        }

        internal static void ListarCombo()
        {
            throw new NotImplementedException();
        }

        public static DataTable Listar()
        {
            return DBDatos.Listar("TipoIngreso_Listar");
        }

        public static void ListarCombo(ComboBox comboBox)
        {
            DBDatos.ListarCombo(Listar(), "Denominacion", "IDTipoIngreso", comboBox);
        }
    }
}
