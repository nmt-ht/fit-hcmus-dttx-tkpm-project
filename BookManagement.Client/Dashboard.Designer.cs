﻿using System;
using FontAwesome.Sharp;
namespace BookManagement
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.btnCaiDat = new FontAwesome.Sharp.IconButton();
            this.btnBaoCao = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnDanhMucSach = new FontAwesome.Sharp.IconButton();
            this.pnlHomIcon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.btnMaximinze = new FontAwesome.Sharp.IconButton();
            this.btnMiniminze = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.IconHome = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlHomIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlLeftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftMenu.Controls.Add(this.btnCaiDat);
            this.pnlLeftMenu.Controls.Add(this.btnBaoCao);
            this.pnlLeftMenu.Controls.Add(this.btnHoaDon);
            this.pnlLeftMenu.Controls.Add(this.btnKhachHang);
            this.pnlLeftMenu.Controls.Add(this.btnNhanVien);
            this.pnlLeftMenu.Controls.Add(this.btnDanhMucSach);
            this.pnlLeftMenu.Controls.Add(this.pnlHomIcon);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(194, 711);
            this.pnlLeftMenu.TabIndex = 0;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCaiDat.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCaiDat.IconChar = FontAwesome.Sharp.IconChar.Dharmachakra;
            this.btnCaiDat.IconColor = System.Drawing.Color.White;
            this.btnCaiDat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaiDat.IconSize = 30;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 395);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCaiDat.Size = new System.Drawing.Size(192, 61);
            this.btnCaiDat.TabIndex = 9;
            this.btnCaiDat.Text = "Settings";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaoCao.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBaoCao.IconChar = FontAwesome.Sharp.IconChar.Hive;
            this.btnBaoCao.IconColor = System.Drawing.Color.White;
            this.btnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoCao.IconSize = 30;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 334);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(192, 61);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Reports";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoaDon.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnHoaDon.IconColor = System.Drawing.Color.White;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.IconSize = 30;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 273);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(192, 61);
            this.btnHoaDon.TabIndex = 7;
            this.btnHoaDon.Text = "Invoices";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.Children;
            this.btnKhachHang.IconColor = System.Drawing.Color.White;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.IconSize = 30;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 212);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(192, 61);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Customers";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.IconSize = 30;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 151);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(192, 61);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Employees";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDanhMucSach
            // 
            this.btnDanhMucSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMucSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMucSach.FlatAppearance.BorderSize = 0;
            this.btnDanhMucSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMucSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDanhMucSach.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDanhMucSach.IconChar = FontAwesome.Sharp.IconChar.Kaaba;
            this.btnDanhMucSach.IconColor = System.Drawing.Color.White;
            this.btnDanhMucSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhMucSach.IconSize = 30;
            this.btnDanhMucSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMucSach.Location = new System.Drawing.Point(0, 90);
            this.btnDanhMucSach.Name = "btnDanhMucSach";
            this.btnDanhMucSach.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDanhMucSach.Size = new System.Drawing.Size(192, 61);
            this.btnDanhMucSach.TabIndex = 3;
            this.btnDanhMucSach.Text = "Dasboard";
            this.btnDanhMucSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMucSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMucSach.UseVisualStyleBackColor = true;
            this.btnDanhMucSach.Click += new System.EventHandler(this.btnDanhMucSach_Click);
            // 
            // pnlHomIcon
            // 
            this.pnlHomIcon.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlHomIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHomIcon.Controls.Add(this.label2);
            this.pnlHomIcon.Controls.Add(this.label1);
            this.pnlHomIcon.Controls.Add(this.btnHome);
            this.pnlHomIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlHomIcon.Name = "pnlHomIcon";
            this.pnlHomIcon.Size = new System.Drawing.Size(192, 90);
            this.pnlHomIcon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(102, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(72, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Management";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::BookManagement.Client.Properties.Resources.books_2;
            this.btnHome.Location = new System.Drawing.Point(8, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(59, 67);
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.iconButton1);
            this.pnlTitle.Controls.Add(this.lblOrderTotal);
            this.pnlTitle.Controls.Add(this.btnOrder);
            this.pnlTitle.Controls.Add(this.lblWelcomeUser);
            this.pnlTitle.Controls.Add(this.btnMaximinze);
            this.pnlTitle.Controls.Add(this.btnMiniminze);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.IconHome);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(194, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(977, 52);
            this.pnlTitle.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(637, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 31);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrderTotal.Location = new System.Drawing.Point(822, 12);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(28, 21);
            this.lblOrderTotal.TabIndex = 12;
            this.lblOrderTotal.Text = "10";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.White;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 30;
            this.btnOrder.Location = new System.Drawing.Point(782, 7);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(49, 31);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcomeUser.Location = new System.Drawing.Point(683, 12);
            this.lblWelcomeUser.Margin = new System.Windows.Forms.Padding(10);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(86, 21);
            this.lblWelcomeUser.TabIndex = 10;
            this.lblWelcomeUser.Text = "Tu Nguyen";
            // 
            // btnMaximinze
            // 
            this.btnMaximinze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximinze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximinze.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnMaximinze.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMaximinze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximinze.IconSize = 22;
            this.btnMaximinze.Location = new System.Drawing.Point(911, 10);
            this.btnMaximinze.Name = "btnMaximinze";
            this.btnMaximinze.Size = new System.Drawing.Size(24, 23);
            this.btnMaximinze.TabIndex = 9;
            this.btnMaximinze.UseVisualStyleBackColor = false;
            this.btnMaximinze.Click += new System.EventHandler(this.btnMaximinze_Click);
            // 
            // btnMiniminze
            // 
            this.btnMiniminze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniminze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniminze.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMiniminze.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMiniminze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiniminze.IconSize = 22;
            this.btnMiniminze.Location = new System.Drawing.Point(880, 10);
            this.btnMiniminze.Name = "btnMiniminze";
            this.btnMiniminze.Size = new System.Drawing.Size(25, 23);
            this.btnMiniminze.TabIndex = 8;
            this.btnMiniminze.UseVisualStyleBackColor = false;
            this.btnMiniminze.Click += new System.EventHandler(this.btnMiniminze_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.Brown;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 22;
            this.btnExit.Location = new System.Drawing.Point(939, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle.Location = new System.Drawing.Point(46, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconHome
            // 
            this.IconHome.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.IconHome.ForeColor = System.Drawing.Color.SlateBlue;
            this.IconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconHome.IconColor = System.Drawing.Color.SlateBlue;
            this.IconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconHome.IconSize = 36;
            this.IconHome.Location = new System.Drawing.Point(6, 10);
            this.IconHome.Name = "IconHome";
            this.IconHome.Size = new System.Drawing.Size(37, 36);
            this.IconHome.TabIndex = 1;
            this.IconHome.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(194, 52);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(977, 659);
            this.pnlDesktop.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 711);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlLeftMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhà sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlHomIcon.ResumeLayout(false);
            this.pnlHomIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLeftMenu;
        private Panel pnlHomIcon;
        private FontAwesome.Sharp.IconButton btnCaiDat;
        private FontAwesome.Sharp.IconButton btnBaoCao;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnDanhMucSach;
        private Panel pnlTitle;
        private IconPictureBox IconHome;
        private Label lblTitle;
        private Panel pnlDesktop;
        private IconButton btnMaximinze;
        private IconButton btnMiniminze;
        private IconButton btnExit;
        private Label lblWelcomeUser;
        private PictureBox btnHome;
        private Label label2;
        private Label label1;
        private IconButton btnOrder;
        private Label lblOrderTotal;
        private IconButton iconButton1;
    }
}