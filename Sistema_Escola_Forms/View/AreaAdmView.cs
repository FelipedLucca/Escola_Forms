using Sistema_Escola_Forms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escola_Forms.view
{
    public partial class AreaAdmView : Form
    {
        public AreaAdmView()
        {
            InitializeComponent();
        }
        private void BtnCriarProfessor_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new NotaView()));
            t.Start();
        }

        private void BtnBoletim_Click(object sender, EventArgs e)
        {
            Close();
            Thread a = new Thread(() => Application.Run(new AdicionarNotaView()));
            a.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new CriarProfessor()));
            t.Start();
        }
    }
}
