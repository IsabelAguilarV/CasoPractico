using Money.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money.Formularios
{

    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtAño.Text = DateTime.Now.Year.ToString();
            cboMes.SelectedIndex = (DateTime.Now.Month - 1);
            ListarMovimiento();
        }

        private void ResumenIngreso()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes", (cboMes.SelectedIndex + 1)),
                new Parametro("@Año",txtAño.Text)

            };

            dgvRIngreso.DataSource = DBDatos.Listar("IngresoResumen_Listar", parametros);
        }

        private void ResumenGasto()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes", (cboMes.SelectedIndex + 1)),
                new Parametro("@Año",txtAño.Text)

            };
            dgvRGastos.DataSource = DBDatos.Listar("GastoResumen_Listar", parametros);
        }

        private void ListarMovimiento()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes", (cboMes.SelectedIndex + 1)),
                new Parametro("@Año",txtAño.Text)

            };

            dgvMovimiento.DataSource = DBDatos.Listar("Movimiento_Listar", parametros);
            DBDatos.OcultarIds(dgvMovimiento);
            dgvMovimiento.Columns["Movimiento"].Visible = false;
            dgvMovimiento.Columns["Descripcion"].Width = 180;

            pintar();

            ResumenIngreso();
            ResumenGasto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FIngreso frm = new FIngreso();
            frm.ShowDialog();

            ListarMovimiento();
        }

        private void dvgMovimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarMovimiento();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FGastos frm = new FGastos();
            frm.ShowDialog();

            ListarMovimiento();
        }

        public void pintar()
        {
            decimal TIngreso = 0, TGasto = 0;

            foreach(DataGridViewRow fila in dgvMovimiento.Rows)
            {
                string movimiento = fila.Cells["Movimiento"].Value.ToString();
                decimal monto = Convert.ToDecimal(fila.Cells["Monto"].Value);

                if (movimiento.Equals("I"))
                {
                    fila.DefaultCellStyle.BackColor = Color.Lime;
                    TIngreso += monto;
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                    TGasto += monto;
                }
            }

            txtIngreso.Text = TIngreso.ToString("N2");
            txtGasto.Text = TGasto.ToString("0");
            txtSaldo.Text = (TIngreso - TGasto).ToString("0");
        }


        private void editarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string movimiento = dgvMovimiento.CurrentRow.Cells["Movimiento"].Value.ToString();
            int idMovimiento = Convert.ToInt32(dgvMovimiento.CurrentRow.Cells["IDMovimiento"].Value);
            string descripcion = dgvMovimiento.CurrentRow.Cells["Descripcion"].Value.ToString();
            string monto = dgvMovimiento.CurrentRow.Cells["Monto"].Value.ToString();
            string tipo = dgvMovimiento.CurrentRow.Cells["tipo"].Value.ToString();
             string fecha = dgvMovimiento.CurrentRow.Cells["Fecha"].Value.ToString();



            if (movimiento.Equals("I"))
            {
                FIngreso frm = new FIngreso();
                frm.IDIngreso = idMovimiento;
                frm.Editar = true;
                frm.txtDescripcion.Text = descripcion;
                frm.txtMonto.Text = monto;
                frm.tipo = tipo;
                frm.dtpFecha.Value = Convert.ToDateTime(fecha).Date;
                frm.ShowDialog();
            }
            else
            {
                FGastos frm = new FGastos();
                frm.Editar = true;
                frm.IDGasto = idMovimiento;
                frm.txtDescripcion.Text = descripcion;
                frm.txtMonto.Text = monto;
                frm.tipo = tipo;
                frm.dtpFecha.Value = Convert.ToDateTime(fecha);
                frm.ShowDialog();
            }

            ListarMovimiento();
        }

       
    }
}
