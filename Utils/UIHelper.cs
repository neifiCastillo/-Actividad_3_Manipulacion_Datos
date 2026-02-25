using System.Text.RegularExpressions;

namespace PracticaWinFormsTienda.Utils
{
    public static class UIHelper
    {
        public static void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public static void MostrarInfo(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public static DialogResult Confirmar(string mensaje)
        {
            return MessageBox.Show(
                mensaje,
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void SoloDecimal(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        public static void TelefonoRD_TextChanged(TextBox txt)
        {
            string soloNumeros = new string(txt.Text
                .Where(char.IsDigit)
                .Take(10) 
                .ToArray());

            string formateado = "";

            if (soloNumeros.Length > 0)
            {
                if (soloNumeros.Length <= 3)
                    formateado = soloNumeros;
                else if (soloNumeros.Length <= 6)
                    formateado = $"{soloNumeros.Substring(0, 3)}-{soloNumeros.Substring(3)}";
                else
                    formateado = $"{soloNumeros.Substring(0, 3)}-{soloNumeros.Substring(3, 3)}-{soloNumeros.Substring(6)}";
            }

            txt.TextChanged -= (s, e) => TelefonoRD_TextChanged(txt); // prevenir loop
            txt.Text = formateado;
            txt.SelectionStart = txt.Text.Length;
            txt.TextChanged += (s, e) => TelefonoRD_TextChanged(txt);
        }
        public static string LimpiarTelefono(string telefonoFormateado)
        {
            return new string(telefonoFormateado.Where(char.IsDigit).ToArray());
        }
        public static bool EsTelefonoValidoRD(string telefonoFormateado)
        {
            var limpio = LimpiarTelefono(telefonoFormateado);
            return limpio.Length == 10;
        }
        public static bool EsCorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            try
            {
                var emailRegex = new Regex(
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);

                return emailRegex.IsMatch(correo);
            }
            catch
            {
                return false;
            }
        }
        public static void ValidarCorreoEnTiempoReal(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, "");
                return;
            }

            if (!EsCorreoValido(txt.Text))
            {
                errorProvider.SetError(txt, "Correo electrónico no válido.");
            }
            else
            {
                errorProvider.SetError(txt, "");
            }
        }
    }
}
