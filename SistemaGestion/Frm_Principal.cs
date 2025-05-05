using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestion.Modelos;
using SistemaGestion.Helpers;

namespace SistemaGestion.Formularios
{
    public partial class Frm_Principal : Form
    {
        private Usuario _usuarioActual;
        private Timer _animacionTimer;
        private List<Control> _controlesAuxiliares = new List<Control>();
        public Frm_Principal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;

            ConfigurarControles();
            ConfigurarEventos();
            IniciarAnimaciones();
            ActualizarInterfazSegunRol();
        }

        private void ConfigurarControles()
        {
            lblBienvenida.Text = $"Bienvenido/a, {_usuarioActual.Username}";
            lblRol.Text = $"Rol: {_usuarioActual.NombreRol}";
            pnlDashboard.Visible = true;
        }

        private void ConfigurarEventos()
        {
            this.Load += Frm_Principal_Load;
            btnClientes.Click += BtnClientes_Click;
            btnProductos.Click += BtnProductos_Click;
            btnRoles.Click += BtnRoles_Click;
            btnAbonos.Click += BtnAbonos_Click;
            btnCerrarSesion.Click += BtnCerrarSesion_Click;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            AnimacionUI.EfectoFadeIn(this);
        }

        private void IniciarAnimaciones()
        {
            _animacionTimer = new Timer();
            _animacionTimer.Interval = 50;
            _animacionTimer.Tick += AnimacionTimer_Tick;
            _animacionTimer.Start();
        }

        private void AnimacionTimer_Tick(object sender, EventArgs e)
        {
            // Microinteracciones para botones del menú
            foreach (Button btn in pnlMenu.Controls.OfType<Button>())
            {
                if (btn.Enabled && btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position)))
                {
                    AnimacionUI.AplicarEfectoHover(btn);
                }
                else
                {
                    btn.BackColor = SystemColors.Control;
                }
            }
        }

        private void ActualizarInterfazSegunRol()
        {
            // Configurar acceso según el rol del usuario
            switch (_usuarioActual.NombreRol.ToLower())
            {
                case "administrador":
                    btnClientes.Enabled = true;
                    btnProductos.Enabled = true;
                    btnRoles.Enabled = true;
                    btnAbonos.Enabled = true;
                    break;
                case "vendedor":
                    btnClientes.Enabled = true;
                    btnProductos.Enabled = false;
                    btnRoles.Enabled = false;
                    btnAbonos.Enabled = true;
                    break;
                case "almacenista":
                    btnClientes.Enabled = false;
                    btnProductos.Enabled = true;
                    btnRoles.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnProductos.Enabled = false;
                    btnRoles.Enabled = false;
                    break;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            if (!btnClientes.Enabled) return;
            
            using (var formCliente = new Frm_Cliente(_usuarioActual))
            {
                AnimacionUI.EfectoSlide(formCliente);
                formCliente.ShowDialog();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (!btnProductos.Enabled) return;
            
            using (var formProducto = new Frm_Producto(_usuarioActual))
            {
                AnimacionUI.EfectoSlide(formProducto);
                formProducto.ShowDialog();
            }
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new Frm_Roles(_usuarioActual);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la gestión de roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbonos_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new Frm_Abonos(_usuarioActual);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la gestión de pagos/abonos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar Sesión", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AnimacionUI.EfectoFadeOut(this);
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _animacionTimer?.Stop();
            _animacionTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
