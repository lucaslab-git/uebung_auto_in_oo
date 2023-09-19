using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uebung_auto_in_oo
{
    public partial class Form1 : Form
    {
        Auto myauto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_erzeugen_Click(object sender, EventArgs e)
        {
           myauto= new Auto();
        }

        private void btn_gib_werte_Click(object sender, EventArgs e)
        {
           
            tb_preis.Text = myauto.getPreis().ToString();
            tb_farbe.Text = myauto.getFarbe();
        }

        private void btn_setze_werte_Click(object sender, EventArgs e)
        {
            myauto.setPreis(Convert.ToInt16(tb_preis.Text));
            myauto.setFarbe(tb_farbe.Text);
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            myauto.setPreis(0);
            myauto.setFarbe("");
            tb_preis.Text = "";
            tb_farbe.Text = "";
        }
    }
}
