using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquare
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int value = 1;
            int endingValue;
            int squareRootAsInteger;
            int numberOfPerfectSquares = 0;
            double squareRootAsDouble;

            this.lstPerfectSquares.Items.Clear();

            endingValue = Convert.ToInt32(this.nudNumber.Text);

            while (value <= endingValue)
            {
                squareRootAsDouble = Math.Sqrt(value);
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                if (squareRootAsInteger == squareRootAsDouble)
                {
                    numberOfPerfectSquares++;
                    this.lstPerfectSquares.Items.Add(value);
                }

                value++;
            }
        }
    }
}
