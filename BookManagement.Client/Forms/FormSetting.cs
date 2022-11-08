﻿using BookManagement.Business;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms;

public partial class FormSetting : Form
{
    private readonly ICustomerBiz _customerBiz;
    public User CurrentUser { get; set; }
    public FormSetting(ICustomerBiz customerBiz)
    {
        InitializeComponent();
        _customerBiz = customerBiz;
    }

    private void DataBind()
    {
       
    }

    private void FormCustomer_Load(object sender, EventArgs e)
    {
        DataBind();
    }

    internal void ResetBackColor()
    {
        //foreach (var item in flpRow.Controls.OfType<ucRow>())
        //{
        //    item.BackColorTop = Color.FromArgb(142, 195, 176);
        //    item.BackColorBottom = Color.FromArgb(141, 114, 225);
        //}
    }
}