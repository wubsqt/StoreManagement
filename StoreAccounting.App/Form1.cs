﻿using Accounting.utility.Convertor;
using StoreAccounting.App.Forms;
using StoreAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAccounting.App
{
    public partial class frmSartup : Form
    {
        public frmSartup()
        {
            InitializeComponent();
        }

        private void frmSartup_Load(object sender, EventArgs e)
        {
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            lblDateTime.Text = DateTime.Now.ToShamsi();
            lblTimer.Text = DateConvertor.Timer(DateTime.Now); // TODO : FIX timer every 1 seccond update
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }
    }
}
