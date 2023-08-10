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

        int num1;
        int num2;
        string res;
        string operation;


        private void ButttonClicked(object sender, EventArgs e)
        {
            string numsEraseLastChar;
            string inputText;
            inputText = input.Text;

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
                    operation = "n";
                    break;
                case "System.Windows.Forms.Button, Text: +":
                    num1 = int.Parse(input.Text);
                    input.Clear();
                    operation = "+";
                    break;
                case "System.Windows.Forms.Button, Text: -":
                    num1 = int.Parse(input.Text);
                    input.Clear();
                    operation = "-";
                    break;
                case "System.Windows.Forms.Button, Text: x":
                    num1 = int.Parse(input.Text);
                    input.Clear();
                    operation = "x";
                    break;
                case "System.Windows.Forms.Button, Text: /":
                    num1 = int.Parse(input.Text);
                    input.Clear();
                    operation = "/";
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


        private void Result(object sender, EventArgs e)
        {
            num2 = int.Parse(input.Text);

            if (operation == "+")
            {
                res = (num1 + num2).ToString();
                input.Text = res;
            }
            if (operation == "-")
            {
                res = (num1 - num2).ToString();
                input.Text = res;
            }
            if (operation == "x")
            {
                res = (num1 * num2).ToString();
                input.Text = res;
            }
            if (operation == "/")
            {
                res = (num1 / num2).ToString();
                input.Text = res;
            }

        }
    }
}
