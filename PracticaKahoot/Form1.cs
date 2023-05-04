using System;
using System.Windows.Forms;

//Código del kahoot 271 4095

namespace PracticaKahoot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbNumeroUsuarios.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                if (control is TextBox)
                    control.Text = string.Empty;

            cbNumeroUsuarios.SelectedIndex = 0;
            txtCodigoJuego.Focus();
        }

        private void cbNumeroUsuarios_TextChanged(object sender, EventArgs e)
        {
            switch (cbNumeroUsuarios.SelectedIndex)
            {
                case 0:
                    habilitarTextBoxes(false, false);
                    break;
                case 1:
                    habilitarTextBoxes(true, false);
                    break;
                case 2:
                    habilitarTextBoxes(true, true);
                    break;
            }
        }

        private void habilitarTextBoxes(bool usuario2, bool usuario3)
        {
            lblNombre2.Enabled = usuario2;
            txtUsuario2.Enabled = usuario2;
            lblNombre3.Enabled = usuario3;
            txtUsuario3.Enabled = usuario3;

            foreach (Control control in Controls)
                if (control is TextBox && !control.Enabled)
                    control.Text = string.Empty;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuarios()
        {
            //Ingresar a la pagina https://kahoot.com/
            //Darle clic al boton "Play" con id (menu-item-92364)
            //Escribir en el único input que hay, el código del juego
            //Presionar en el único boton que hay
            //Escribir el nombre de usuario en el único input que hay
            //Presionar en el único boton que hay
            //Repetir los últimos dos pasos dependiendo del número de usuarios que haya
        }

        private void txtCodigoJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCodigoJuego_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonEnviar();
        }

        private void habilitarBotonEnviar()
        {
            bool faltaAlgo = false;

            foreach (Control control in Controls)
                if (control is TextBox && control.Enabled && control.Text == string.Empty)
                    faltaAlgo = true;

            if (faltaAlgo)
                btnEnviar.Enabled = false;
            else
            {
                if (txtCodigoJuego.TextLength < 7)
                    btnEnviar.Enabled = false;
                else
                    btnEnviar.Enabled = true;
            }
        }
    }
}
