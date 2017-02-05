using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluator
{
    public partial class frmChoose : Form { 

        public frmChoose()
        {
            InitializeComponent();
        }
        frmEvaluator evaluator = new frmEvaluator();
        private void btnPrefix_Click(object sender, EventArgs e)
        {
            
            evaluator.type = "pre";
            evaluator.Activate();
            evaluator.ShowDialog();
            this.Close();
            
        }
        private void btnInfix_Click(object sender, EventArgs e)
        {
            evaluator.type = "in";
            evaluator.Activate();
            evaluator.ShowDialog();
            this.Close();
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            evaluator.type = "post";
            evaluator.Activate();
            evaluator.ShowDialog();
            this.Close();
        }
    }
}
