using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        private int getFirtsNum()
        {


            if (input.Text.Length > 0)
            {
                if (int.TryParse(input.Text, out FirstNum) == false)
                {
                    throw new InvalidOperationException("ESTA CALCULADORA NO ADMITE LETRAS");
                }
                
                    
                /*
                 *  CATCHEAR EL ERROR DE CUANDO ESCRIBIMOS MUCHO
                if (input.Text.Length > 5)
                {
                    input.Multiline = true;
                    input.Height = 150;
                }
                
                
        
            }
        }*/


        private void ButttonClicked(object sender, EventArgs e)
        {
            string numsEraseLastChar;
            string inputText;
            inputText = input.Text;

            //MessageBox.Show(sender.ToString());
            switch (sender.ToString())
            {
                case "System.Windows.Forms.Button, Text: 0":
                    input.AppendText("0");
                    break;
                case "System.Windows.Forms.Button, Text: 1":
                    input.AppendText("1");
                    break;
                case "System.Windows.Forms.Button, Text: 2":
                    input.AppendText("2");
                    break;
                case "System.Windows.Forms.Button, Text: 3":
                    input.AppendText("3");
                    break;
                case "System.Windows.Forms.Button, Text: 4":
                    input.AppendText("4");
                    break;
                case "System.Windows.Forms.Button, Text: 5":
                    input.AppendText("5");
                    break;
                case "System.Windows.Forms.Button, Text: 6":
                    input.AppendText("6");
                    break;
                case "System.Windows.Forms.Button, Text: 7":
                    input.AppendText("7");
                    break;
                case "System.Windows.Forms.Button, Text: 8":
                    input.AppendText("8");
                    break;
                case "System.Windows.Forms.Button, Text: 9":
                    input.AppendText("9");
                    break;
                case "System.Windows.Forms.Button, Text: <--":
                    // Verificamos que existan mas de 0 numeros en en input evitar borrar elementos que no existen y generar un error en el codigo
                    if (inputText.Length > 0)
                    {
                        numsEraseLastChar = EraseNum(inputText);
                        input.AppendText(numsEraseLastChar);
                    }
                    break;
                case "System.Windows.Forms.Button, Text: C":
                    input.Clear();
                    break;
                case "System.Windows.Forms.Button, Text: +":
                    //Sumar(inputText);
                    break;
            }
        }

        private string EraseNum(string nums)
        {
            string numsEraseLastChar;
            // Eliminamos el ultimo caracter
            numsEraseLastChar = nums.Remove(nums.Length - 1);
            // Limpiamos el input para poder pegar los numeros y que no se acumulen
            input.Clear();
            return numsEraseLastChar;
        }

    }
}
