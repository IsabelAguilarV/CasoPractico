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
    class TipoGasto
    {
        public int IDTipoGasto { get; set; }
        public string Denominacion { get; set; }
        
        public static bool Guardar(TipoGasto tipoGasto, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Denominacion", tipoGasto.Denominacion),
                new Parametro("@IDTipoGasto", tipoGasto.IDTipoGasto),
                new Parametro("@Editar", editar)
            };

            return DBDatos.Ejecutar("TipoGasto_Agregar", parametros);
        }
        public static DataTable Listar()
        {
            return DBDatos.Listar("TipoGasto_Listar");
        }

        public static void ListarCombo(ComboBox comboBox)
        {
            DBDatos.ListarCombo(Listar(), "Denominacion", "IDTipoGasto", comboBox);
        }

        
    }
}
