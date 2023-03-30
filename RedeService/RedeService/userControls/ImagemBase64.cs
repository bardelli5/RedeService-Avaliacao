using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeService
    {
    public partial class ImagemBase64 : UserControl
        {
        public ImagemBase64()
            {
                InitializeComponent();
            }

        private void Btn_DownloadEGravar_Click(object sender, EventArgs e)
            {
            using (var client = new WebClient())
                {
                    client.DownloadFile("https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png", Application.StartupPath + "redeservice-logo.png");
                }

                Byte[] bytes = File.ReadAllBytes("redeservice-logo.png");
                String file = Convert.ToBase64String(bytes);
             
                resultadoBase64Box.Text = file;
            }
        }
    }
