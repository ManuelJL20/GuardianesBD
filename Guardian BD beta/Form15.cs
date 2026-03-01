using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Guardian_BD_beta
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Link.Links.Add(0, Link.Text.Length, "https://www.facebook.com/share/1BwMtYHCKu/");
            Link1.Links.Add(0, Link1.Text.Length, "https://www.facebook.com/share/18jQdNFhAv/");
        }

        private void Link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (url != null)
                System.Diagnostics.Process.Start(url);
        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (url != null)
                System.Diagnostics.Process.Start(url);
        }
    }
}
