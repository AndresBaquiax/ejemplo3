using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo3
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Declarar un objeto
            
            //Inicio
            //Para remover los valores establecidos
            string[] charsToRemove = new string[] { "@", "!", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "-", "*", "/", ".", "~", "`", "[", "]", "{", "}", ";", ",", "/", "?", "|", "<", ">" };    
            foreach (var c in charsToRemove)
            {
                textBoxNombre.Text = textBoxNombre.Text.Replace(c, string.Empty);
            }
            string[] charsToRemove1 = new string[] { "@", "!", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "-", "*", "/", ".", "~", "`", "[", "]", "{", "}", ";", ",", "/", "?", "|", "<", ">" };
            foreach (var c in charsToRemove1)
            {
                textBoxApellido.Text = textBoxApellido.Text.Replace(c, string.Empty);
            }
            //Fin

            //Inicio
            //Pasar primera letra de cada palabra a mayuscula
            textBoxApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxApellido.Text);
            textBoxApellido.SelectionStart = textBoxApellido.Text.Length;
            textBoxNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxNombre.Text);
            textBoxNombre.SelectionStart = textBoxNombre.Text.Length;
            //Fin

            //Trim() para quitar espacios al inicio y al final
            persona.Dpi = textBoxDPI.Text.Trim();
            persona.Apellido = textBoxApellido.Text.Trim();
            persona.Nombre = textBoxNombre.Text.Trim();
            persona.Telefono = textBoxTelefono.Text.Trim();
            persona.FechaNacimiento = dateTimePicker1.Value;

            
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - dateTimePicker1.Value.Year;
            if (fechaHoy < dateTimePicker1.Value.AddYears(edad))
            {
                edad = edad - 1;
            }

            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelTelefono.Text = persona.Telefono;  
            labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            labelEdad.Text = edad.ToString() + " anos";

        }

        private void buttonAbrirCuentas_Click(object sender, EventArgs e)
        {
            Form2 formularioCuenta = new Form2();
            formularioCuenta.Show();

        }
    }
}
