using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawlerDesktop
{
    public partial class Form1 : Form
    {
        public Form1(Produto produto)
        {
            InitializeComponent();
            labelNomeText.Text = produto.Nome;
            labelIdText.Text = produto.Id;
            labelPrecoText.Text = produto.Preco.ToString();
            labelSaldoText.Text = produto.Saldo.ToString();

            var request = WebRequest.Create(produto.ImagemURL);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }


            
        
    }
}
