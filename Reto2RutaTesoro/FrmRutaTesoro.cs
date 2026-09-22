using System;
using System.Windows.Forms;

namespace Reto2RutaTesoro
{
    public partial class FrmRutaTesoro : Form
    {
        private ListaSimple ruta = new ListaSimple();

        public FrmRutaTesoro()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvRuta.Rows.Clear();

            Nodo? actual = ruta.ObtenerInicio();

            while (actual != null)
            {
                dgvRuta.Rows.Add(
                    actual.Id,
                    actual.Nombre,
                    actual.Pista,
                    actual.Peligro);

                actual = actual.Siguiente;
            }

            lblEstado.Text =
                $"Total de ubicaciones en la ruta: {ruta.Cantidad}";
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Escribe el nombre de la ubicación.");
                return false;
            }

            if (txtPista.Text.Trim() == "")
            {
                MessageBox.Show("Escribe la pista.");
                return false;
            }

            return true;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            try
            {
                ruta.Insertar(
                    (int)numId.Value,
                    txtNombre.Text.Trim(),
                    txtPista.Text.Trim(),
                    (int)numPeligro.Value);

                ActualizarGrid();
                LimpiarCampos();

                MessageBox.Show("Ubicación agregada.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = (int)numId.Value;

            Nodo? nodo = ruta.Buscar(id);

            if (nodo == null)
            {
                MessageBox.Show("No se encontró la ubicación.");
                return;
            }

            txtNombre.Text = nodo.Nombre;
            txtPista.Text = nodo.Pista;
            numPeligro.Value = nodo.Peligro;

            MessageBox.Show("Ubicación encontrada.");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            bool modificado = ruta.Modificar(
                (int)numId.Value,
                txtNombre.Text.Trim(),
                txtPista.Text.Trim(),
                (int)numPeligro.Value);

            if (modificado)
            {
                ActualizarGrid();
                MessageBox.Show("Ubicación modificada.");
            }
            else
            {
                MessageBox.Show("No se encontró la ubicación.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)numId.Value;

            bool eliminado = ruta.Eliminar(id);

            if (eliminado)
            {
                ActualizarGrid();
                LimpiarCampos();
                MessageBox.Show("Ubicación eliminada.");
            }
            else
            {
                MessageBox.Show("No se encontró la ubicación.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            numId.Value = 1;
            txtNombre.Clear();
            txtPista.Clear();
            numPeligro.Value = 1;
            txtNombre.Focus();
        }
    }
}