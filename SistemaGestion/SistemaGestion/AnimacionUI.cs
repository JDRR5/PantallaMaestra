using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.Helpers
{
    /// <summary>
    /// Clase para manejar animaciones y efectos en la interfaz de usuario
    /// </summary>
    public static class AnimacionUI
    {
        private static Timer timerAnimacion;

        /// <summary>
        /// Aplica un efecto de desvanecimiento al mostrar un formulario
        /// </summary>
        /// <param name="formulario">Formulario a animar</param>
        public static void EfectoFadeIn(Form formulario)
        {
            formulario.Opacity = 0;
            timerAnimacion = new Timer();
            timerAnimacion.Interval = 30;
            timerAnimacion.Tag = formulario;
            timerAnimacion.Tick += (s, e) =>
            {
                var form = (Form)((Timer)s).Tag;
                if (form.Opacity < 1)
                {
                    form.Opacity += 0.1;
                }
                else
                {
                    ((Timer)s).Stop();
                    ((Timer)s).Dispose();
                }
            };
            timerAnimacion.Start();
        }

        /// <summary>
        /// Aplica un efecto de desvanecimiento al cerrar un formulario
        /// </summary>
        /// <param name="formulario">Formulario a animar</param>
        public static void EfectoFadeOut(Form formulario)
        {
            formulario.Opacity = 1;
            timerAnimacion = new Timer();
            timerAnimacion.Interval = 30;
            timerAnimacion.Tag = formulario;
            timerAnimacion.Tick += (s, e) =>
            {
                var form = (Form)((Timer)s).Tag;
                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.1;
                }
                else
                {
                    ((Timer)s).Stop();
                    ((Timer)s).Dispose();
                }
            };
            timerAnimacion.Start();
        }

        /// <summary>
        /// Aplica un efecto de deslizamiento al mostrar un formulario
        /// </summary>
        /// <param name="formulario">Formulario a animar</param>
        public static void EfectoSlide(Form formulario)
        {
            int originalHeight = formulario.Height;
            formulario.Height = 0;
            
            timerAnimacion = new Timer();
            timerAnimacion.Interval = 10;
            timerAnimacion.Tag = new { Form = formulario, OriginalHeight = originalHeight };
            
            timerAnimacion.Tick += (s, e) =>
            {
                var data = (dynamic)((Timer)s).Tag;
                var form = (Form)data.Form;
                int target = (int)data.OriginalHeight;
                
                if (form.Height < target)
                {
                    form.Height += 30;
                    form.Opacity = (double)form.Height / target;
                }
                else
                {
                    form.Height = target;
                    form.Opacity = 1;
                    ((Timer)s).Stop();
                    ((Timer)s).Dispose();
                }
            };
            
            timerAnimacion.Start();
        }

        /// <summary>
        /// Aplica un efecto visual al pasar el cursor sobre un control (hover)
        /// </summary>
        /// <param name="control">Control al que se aplicará el efecto</param>
        public static void AplicarEfectoHover(Control control)
        {
            if (control is Button)
            {
                Button btn = (Button)control;
                btn.BackColor = Color.FromArgb(200, 220, 255);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(100, 150, 255);
            }
        }

        /// <summary>
        /// Aplica un efecto de parpadeo a un control
        /// </summary>
        /// <param name="control">Control al que se aplicará el efecto</param>
        /// <param name="duracion">Duración del parpadeo en milisegundos</param>
        public static void EfectoParpadeo(Control control, int duracion = 500)
        {
            Color colorOriginal = control.ForeColor;
            timerAnimacion = new Timer();
            timerAnimacion.Interval = 250;
            
            bool estaVisible = true;
            DateTime inicio = DateTime.Now;
            
            timerAnimacion.Tick += (s, e) =>
            {
                if ((DateTime.Now - inicio).TotalMilliseconds >= duracion)
                {
                    control.ForeColor = colorOriginal;
                    ((Timer)s).Stop();
                    ((Timer)s).Dispose();
                    return;
                }
                
                if (estaVisible)
                {
                    control.ForeColor = Color.Transparent;
                }
                else
                {
                    control.ForeColor = colorOriginal;
                }
                
                estaVisible = !estaVisible;
            };
            
            timerAnimacion.Start();
        }

        /// <summary>
        /// Aplica un efecto de movimiento a un control
        /// </summary>
        /// <param name="control">Control a mover</param>
        /// <param name="xDestino">Posición X de destino</param>
        /// <param name="yDestino">Posición Y de destino</param>
        public static void MoverControl(Control control, int xDestino, int yDestino)
        {
            Point puntoInicial = control.Location;
            timerAnimacion = new Timer();
            timerAnimacion.Interval = 10;
            timerAnimacion.Tag = new { Control = control, XInicial = puntoInicial.X, YInicial = puntoInicial.Y, XDestino = xDestino, YDestino = yDestino, Paso = 0 };
            
            timerAnimacion.Tick += (s, e) =>
            {
                var data = (dynamic)((Timer)s).Tag;
                var ctrl = (Control)data.Control;
                int xInicial = (int)data.XInicial;
                int yInicial = (int)data.YInicial;
                int xFinal = (int)data.XDestino;
                int yFinal = (int)data.YDestino;
                int paso = (int)data.Paso + 1;
                
                // Calcular la nueva posición usando una interpolación lineal
                const int totalPasos = 20;
                int xNuevo = xInicial + (xFinal - xInicial) * paso / totalPasos;
                int yNuevo = yInicial + (yFinal - yInicial) * paso / totalPasos;
                
                ctrl.Location = new Point(xNuevo, yNuevo);
                
                if (paso >= totalPasos)
                {
                    ctrl.Location = new Point(xFinal, yFinal);
                    ((Timer)s).Stop();
                    ((Timer)s).Dispose();
                }
                else
                {
                    ((Timer)s).Tag = new { Control = ctrl, XInicial = xInicial, YInicial = yInicial, XDestino = xFinal, YDestino = yFinal, Paso = paso };
                }
            };
            
            timerAnimacion.Start();
        }
    }
}
