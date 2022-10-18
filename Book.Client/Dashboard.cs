using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Book.Infrastructure.DataAccess.Data;
using FontAwesome.Sharp;
namespace BookManagement
{
    public partial class Dashboard : Form
    {
        IUserData userData;
        public Dashboard(IUserData userData)
        {
            InitializeComponent();
            this.userData = userData;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.userData.GetUsers();
        }
    }
}