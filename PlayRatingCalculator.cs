using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayRatingCalcSecondEdition
{
    public partial class PlayRatingCalculator : Form
    {
        public PlayRatingCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatePR();
        }

        private void score_ValueChanged(object sender, EventArgs e)
        {
            if (score.Value < 8600000)
            {
                labelGrade.Text = "D";
                labelGrade.ForeColor = Color.Crimson;
            } else if (score.Value < 8900000)
            {
                labelGrade.Text = "C";
                labelGrade.ForeColor = Color.Orange;
            } else if (score.Value < 9200000)
            {
                labelGrade.Text = "B";
                labelGrade.ForeColor = Color.Green;
            } else if (score.Value < 9500000)
            {
                labelGrade.Text = "A";
                labelGrade.ForeColor = Color.BlueViolet;
            } else if (score.Value < 9800000)
            {
                labelGrade.Text = "AA";
                labelGrade.ForeColor = Color.PaleVioletRed;
            } else if (score.Value < 9900000)
            {
                labelGrade.Text = "EX";
                labelGrade.ForeColor = Color.Violet;
            } else
            {
                labelGrade.Text = "EX+";
                labelGrade.ForeColor = Color.Magenta;
            }
            CalculatePR();
        }

        private void PlayRatingCalculator_Load(object sender, EventArgs e)
        {

        }

        public void CalculatePR()
        {
            decimal constant = chartConstant.Value;
            decimal scorevalue = score.Value;
            decimal resultvalue;

            if (scorevalue > 9800000)
            {
                resultvalue = 1.0m;
                resultvalue += ((scorevalue - 9800000) / 200000);
                resultvalue += constant;
            }
            else
            {
                resultvalue = ((scorevalue - 9500000) / 300000);
                resultvalue += constant;
            }

            if (scorevalue >= 10000000)
            {
                resultvalue = constant + 2.0m;
            }

            resultLabel.Text = resultvalue.ToString();
        }

        public void CalculatePR_CHUNI()
        {
            decimal constant = chartConstantCHUNI.Value;
            decimal scorevalue = scoreCHUNI.Value;
            decimal resultvalue;

            if (scorevalue >= 1005000)
            {
                resultvalue = 1.5m;
                resultvalue += ((scorevalue - 1005000) / 5000);
                resultvalue += constant;
            }
            if (scorevalue >= 1000000 && scorevalue < 1005000)
            {
                resultvalue = 1.0m;
                resultvalue += ((scorevalue - 1000000) / 10000);
                resultvalue += constant;
            } else
            {
                resultvalue = ((scorevalue - 975000) / 25000);
                resultvalue += constant;
            }

            if (scorevalue >= 1007500)
            {
                resultvalue = constant + 2.0m;
            }

            labelOutputCHUNI.Text = resultvalue.ToString();
        }

        private void chartConstant_ValueChanged(object sender, EventArgs e)
        {
            CalculatePR();
        }

        private void labelGrade_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chartConstantCHUNI_ValueChanged(object sender, EventArgs e)
        {
            CalculatePR_CHUNI();
        }

        private void scoreCHUNI_ValueChanged(object sender, EventArgs e)
        {
            if (scoreCHUNI.Value < 500000)
            {
                labelGradeCHUNI.Text = "D";
                labelGradeCHUNI.ForeColor = Color.Gray;
            }
            else if (scoreCHUNI.Value < 600000)
            {
                labelGradeCHUNI.Text = "C";
                labelGradeCHUNI.ForeColor = Color.Orange;
            }
            else if (scoreCHUNI.Value < 700000)
            {
                labelGradeCHUNI.Text = "B";
                labelGradeCHUNI.ForeColor = Color.BlueViolet;
            }
            else if (scoreCHUNI.Value < 800000)
            {
                labelGradeCHUNI.Text = "BB";
                labelGradeCHUNI.ForeColor = Color.Blue;
            }
            else if (scoreCHUNI.Value < 900000)
            {
                labelGradeCHUNI.Text = "BBB";
                labelGradeCHUNI.ForeColor = Color.Aqua;
            }
            else if (scoreCHUNI.Value < 925000)
            {
                labelGradeCHUNI.Text = "A";
                labelGradeCHUNI.ForeColor = Color.DarkOrange;
            }
            else if (scoreCHUNI.Value < 950000)
            {
                labelGradeCHUNI.Text = "AA";
                labelGradeCHUNI.ForeColor = Color.Orange;
            }
            else if (scoreCHUNI.Value < 975000)
            {
                labelGradeCHUNI.Text = "AAA";
                labelGradeCHUNI.ForeColor = Color.OrangeRed;
            }
            else if (scoreCHUNI.Value < 1000000)
            {
                labelGradeCHUNI.Text = "S";
                labelGradeCHUNI.ForeColor = Color.YellowGreen;
            }
            else if (scoreCHUNI.Value < 1007500)
            {
                labelGradeCHUNI.Text = "SS";
                labelGradeCHUNI.ForeColor = Color.Green;
            } else
            {
                labelGradeCHUNI.Text = "SSS";
                labelGradeCHUNI.ForeColor = Color.LimeGreen;
            }

            CalculatePR_CHUNI();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
