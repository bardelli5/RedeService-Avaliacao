using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeService.userControls
    {
    public partial class SobreMim : UserControl
        {
        public SobreMim()
            {
                InitializeComponent();
            }

        private void link_Linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = "https://www.linkedin.com/in/lucas-bardelli-31205a188/",
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }

        private void link_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = "https://github.com/bardelli5",
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }
        }
    }
