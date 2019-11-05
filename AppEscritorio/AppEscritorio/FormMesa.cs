using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class FormMesa : Form
    {
        public FormMesa()
        {
            InitializeComponent();
        }

        private void FormMesa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'appescritorioDataSet1.Cuenta' Puede moverla o quitarla según sea necesario.
            this.cuentaTableAdapter.Fill(this.appescritorioDataSet1.Cuenta);
            // TODO: esta línea de código carga datos en la tabla 'appescritorioDataSet.Mesa' Puede moverla o quitarla según sea necesario.
            this.mesaTableAdapter.Fill(this.appescritorioDataSet.Mesa);
     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 v = new Form1();
            v.Show();
        }
    }
}
