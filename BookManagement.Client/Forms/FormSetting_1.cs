﻿using BookManagement.Client.UC;
using System.Windows;

namespace BookManagement.Client.Forms;

public partial class FormSetting_1 : Form
{
    public FormSetting_1()
    {
        InitializeComponent();
    }

    private void FormSetting_Load(object sender, EventArgs e)
    {
        for(int i = 0; i < 10; i++)
        {
            ucRow ucSetting = new ucRow();
            double width = SystemParameters.FullPrimaryScreenWidth;
            ucSetting.Width = (int)(width * 0.885);
            flpRow.Controls.Add(ucSetting);
        }
    }

    internal void ResetBackColor()
    {
        foreach(var item in flpRow.Controls.OfType<ucRow>())
        {
            item.BackColorTop = Color.FromArgb(142, 195, 176);
            item.BackColorBottom = Color.FromArgb(141, 114, 225);
        }
    }
}