﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSach
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            label2.Text = Properties.Settings.Default.userName;
        }
    }
}
