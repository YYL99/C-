using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void lstLeft_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstLeft.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                lstRight.Items.Add(lstLeft.SelectedItem);
                lstBottom.Items.Add(lstLeft.SelectedItem.ToString() + "被移到右侧");
                lstLeft.Items.Remove(lstLeft.SelectedItem);
            }
        }

        private void btnRigthAll_Click(object sender, EventArgs e)
        {
            foreach (object item in lstLeft.Items)
            {
                lstRight.Items.Add(item);
            }
            lstBottom.Items.Add("左侧列表项全被移至右侧");
            lstLeft.Items.Clear();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstRight.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                lstLeft.Items.Add(lstRight.SelectedItem);
                lstBottom.Items.Add(lstRight.SelectedItem.ToString() + "被移到左侧");
                lstRight.Items.Remove(lstRight.SelectedItem);
            }
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            foreach (object item in lstRight.Items)
            {
                lstLeft.Items.Add(item);
            }
            lstBottom.Items.Add("右侧列表项全被移至左侧");
            lstRight.Items.Clear();
        }
    }
}
