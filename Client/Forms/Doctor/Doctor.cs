using Hospital_Management_System.Client.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Doctor
{
    public partial class Doctor : Form
    {
        Form previousForm;
        Users user;
        public Doctor(Form previousForm, Users user)
        {
            InitializeComponent();
        }
    }
}
