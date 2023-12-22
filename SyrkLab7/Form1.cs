using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyrkTaylorFunctions;

namespace SyrkLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            funcCombo.Items.Add("Sin");
            funcCombo.Items.Add("Cos");          
            funcCombo.Items.Add("Tg");
            funcCombo.Items.Add("Ctg");

            unitCombo.Items.Add("Rad");
            unitCombo.Items.Add("Deg");
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double convVal = x;
            int function=funcCombo.SelectedIndex;
            int unit = unitCombo.SelectedIndex;
            int precision = int.Parse(precisionText.Text);

            if(unit==1)
                convVal=DegreeConverter.ToRadians(x);

            double result = 0;

            switch (function)
            {
                case 0:
                    {
                        result = Sinus.Taylor(convVal, precision);
                    }break;
                case 1:
                    {
                        result=Cosinus.Taylor(convVal, precision);
                    }
                    break;
                case 2:
                    {
                        result = Tangens.Taylor(convVal, precision);
                    }
                    break;
                case 3:
                    {
                        result=Catangens.Taylor(convVal, precision);
                    }break;
            }

            MessageBox.Show($"{funcCombo.SelectedItem.ToString()} {x} = {result}");
        }
    }
}
