using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escola_Forms.Validation
{
    public class Metodo
    {
        public void NotasDecimais(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar < 0 && e.KeyChar > 10)
            {
                e.Handled = true;
            }
        }
      
        //public bool ValidacaoNotas(double n1, double n2, double n3, double n4)
        //{
        //    if (n1 < 0 && n1 > 10)
        //    {
        //        MessageBox.Show("AS notas precisam estar entre 0 e 10");
        //        return true;
        //    }
        //    if (n2 < 0 && n2 > 10)
        //    {
        //        MessageBox.Show("AS notas precisam estar entre 0 e 10");
        //        return true;
        //    }
        //    if (n3 < 0 && n3 > 10)
        //    {
        //        MessageBox.Show("AS notas precisam estar entre 0 e 10");
        //        return true;
        //    }
        //    if (n4 < 0 && n4 > 10)
        //    {
        //        MessageBox.Show("AS notas precisam estar entre 0 e 10");
        //        return true;
        //    }
        //    return false;
        //}
    }
}
