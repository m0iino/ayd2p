using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Form1 : Form
    {
        public int mesa;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesa = 1;
            this.Visible = false;
            FormMesa fmesa = new FormMesa();
            fmesa.Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://localhost:50655/");
            HttpResponseMessage response = await cliente.GetAsync("WebService1.asmx/getMesas");
            string result = await response.Content.ReadAsStringAsync();
            label1.Text = result;
        }
    }
}
