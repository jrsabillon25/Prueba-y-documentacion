using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    class validaciones
    {
        public static void soloLetas(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

       


        public static  bool Correo(string email)
        {
            string expresion = expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


public static void soloNumeros( KeyPressEventArgs e)
{
if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
{
      MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Handled = true;
      return;
}
}

public static void soloLetrasyNumeros(KeyPressEventArgs e)
{
    if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
    {
        MessageBox.Show("Solo se permiten Numeros y Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
    }
}


public static void soloLetrasyNumerosyPunto(KeyPressEventArgs e)
{
    if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && (char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
    {
        MessageBox.Show("Solo se permiten Numeros,Letras y Puntos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
    }
}

public static void SinEspacios(KeyPressEventArgs e)
{
    if (char.IsWhiteSpace(e.KeyChar))
    {
        e.Handled = true;
    }
    else
    {
        e.Handled = false;
    }
}

       

    }
    }





