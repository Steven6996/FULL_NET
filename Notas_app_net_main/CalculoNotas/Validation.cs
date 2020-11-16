using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoNotas
{
    public class Validation
    {

        public bool isVoid(TextBox textBox, ErrorProvider errorProvider)
        {
            if (textBox.Text != "")
                return false;
            else
            {
                errorProvider.SetError(textBox, "Este campo es requerido");
                return true;
            }
        }

        public bool isNumber(TextBox textBox, ErrorProvider errorProvider, string errorMessage)
        {
            Regex expresion = new Regex(@"^[0-9]+$");

            if(!isVoid(textBox, errorProvider))
            {
                if (expresion.IsMatch(textBox.Text))
                {
                    return true;
                }
                else
                {
                    errorProvider.SetError(textBox, errorMessage);
                    return false;
                }
            } else
            {
                return false;
            }

        }
        public bool isText(TextBox textBox, ErrorProvider errorProvider, string errorMessage)
        {
            Regex expresion = new Regex(@"^[a-zA-Z]+$");
            if (!isVoid(textBox, errorProvider))
            {
                if (expresion.IsMatch(textBox.Text))
                {
                    return true;
                }
                else
                {
                    errorProvider.SetError(textBox, errorMessage);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool isEmail(TextBox textBox, ErrorProvider errorProvider, string errorMessage)
        {
            Regex expresion = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!isVoid(textBox, errorProvider))
            {
                if (expresion.IsMatch(textBox.Text))
                {
                    return true;
                }
                else
                {
                    errorProvider.SetError(textBox, errorMessage);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
