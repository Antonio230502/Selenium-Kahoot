using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;

//Código del kahoot 271 4095

namespace PracticaKahoot
{
    public partial class Form1 : Form
    {
        string codigoJuego;
        Stack<string> usuarios = new Stack<string>();
        IWebDriver driver;

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
            guardarDatos();
            abrirPagina("https://kahoot.it/");

            agregarUsuario(usuarios.Pop());

            //foreach (string usuario in usuarios)
            //    agregarUsuario(usuario);
        }

        private void guardarDatos()
        {
            codigoJuego = txtCodigoJuego.Text;
            foreach (Control control in Controls)
                if (control is TextBox && control.Enabled && control.Name != "txtCodigoJuego")
                    usuarios.Push(control.Text);
        }

        private void agregarUsuario(string usuario)
        {
            //Escribir el código del juego en el único input que hay
            IWebElement inputCodigo = driver.FindElement(By.Name("gameId"));
            inputCodigo.SendKeys(codigoJuego);
            Thread.Sleep(2000);

            //Presionar en el único boton que hay
            IWebElement botonEnter = driver.FindElement(By.TagName("button"));
            botonEnter.Click();
            Thread.Sleep(2000);

            //Escribir el nombre de usuario en el único input que hay
            IWebElement inputUsername = driver.FindElement(By.Name("nickname"));
            inputUsername.SendKeys(usuario);
            Thread.Sleep(2000);

            //Presionar en el único boton que hay
            IWebElement botonOkGo = driver.FindElement(By.TagName("button"));
            botonOkGo.Click();
            Thread.Sleep(2000);
        }

        private void abrirPagina(string url)
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(chromeDriverService, new ChromeOptions());
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
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
