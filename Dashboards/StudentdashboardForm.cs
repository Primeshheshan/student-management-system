﻿using StudentManagementSystem.Resultsheet;
using StudentManagementSystem.Updatestudent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Dashboards
{
    public partial class StudentdashboardForm : Form
    {
        public StudentdashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProfileForm up = new UpdateProfileForm();
            this.Hide();
            up.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure Want To Log Out", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void StudentdashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            ResultsheetForm r = new ResultsheetForm();
            this.Hide();
            r.Show();
            this.Close();
        }
    }
}
