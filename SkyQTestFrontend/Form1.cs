using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyQLib;

namespace SkyQTestFrontend
{
    public partial class Form1 : Form
    {
        PvrList pvr;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGetPvrList_Click(object sender, EventArgs e)
        {
            Comms c = new Comms();

            c.IPAddress = this.txtIP.Text;
            pvr = c.GetPvrList();

            c = null;

            RefreshList();

            MessageBox.Show("PVR Information Downloaded");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPvr.Enabled = false;

            cboFilter.Items.Add("ALL");
            cboFilter.Items.Add("Films Only");

            cboFilter.SelectedIndex = 0;
            lblTitle.Text = "";
        }

        private void lstPvr_SelectedIndexChanged(object sender, EventArgs e)
        {
            PvrItem i;

            i = (PvrItem)lstPvr.SelectedItem;

            lblTitle.Text = i.t;
            txtSynopsis.Text = i.sy;
            txtChan.Text = i.cn;
            txtRat.Text = i.carating;
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
            
        }

        private void RefreshList()
        {
            if (pvr != null)
            {
                lstPvr.Items.Clear();

                List<PvrItem> filteredList;

                switch (cboFilter.SelectedIndex)
                {
                    case 1:
                        filteredList = (from i in pvr.pvrItems
                                       where i.carating != null
                                       select i).ToList();
                        break;

                    default:
                        filteredList = pvr.pvrItems;
                        break;
                }

                foreach (PvrItem i in filteredList)
                {
                    lstPvr.Items.Add(i);
                }

                lstPvr.Enabled = true;
            } else
            {
                lstPvr.Enabled = false;
            }
        }
    }
}
