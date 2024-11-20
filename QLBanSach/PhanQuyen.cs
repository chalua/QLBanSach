using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLBS;
using BLL_QLBS;

namespace QLBanSach
{
    public partial class PhanQuyen : Form
    {
        PhanQuyenBLL phanQuyen = new PhanQuyenBLL();
        public PhanQuyen()
        {
            InitializeComponent();
            this.Load += PhanQuyen_Load;
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn doWork = new DataGridViewCheckBoxColumn();
            doWork.HeaderText = "ADMIN";
            doWork.FalseValue = "0";
            doWork.TrueValue = "1";
            dataGridView1.Columns.Insert(0, doWork);
            DataGridViewCheckBoxColumn doWork1 = new DataGridViewCheckBoxColumn();
            doWork1.HeaderText = "Employee";
            doWork1.FalseValue = "0";
            doWork1.TrueValue = "1";
            dataGridView1.Columns.Insert(1, doWork1);
            DataGridViewCheckBoxColumn doWork2 = new DataGridViewCheckBoxColumn();
            doWork2.HeaderText = "Saler";
            doWork2.FalseValue = "0";
            doWork2.TrueValue = "1";
            dataGridView1.Columns.Insert(2, doWork2);
            dataGridView1.DataSource = phanQuyen.loadDataEmployee();
        }
    }
}
