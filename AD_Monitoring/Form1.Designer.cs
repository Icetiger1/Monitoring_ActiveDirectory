﻿namespace AD_Monitoring
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            ColumnHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            remoteControlToolStripMenuItem = new ToolStripMenuItem();
            computerManagementToolStripMenuItem = new ToolStripMenuItem();
            sCCMConnectionToolStripMenuItem = new ToolStripMenuItem();
            whoOnlineToolStripMenuItem = new ToolStripMenuItem();
            discCToolStripMenuItem = new ToolStripMenuItem();
            shareFolderToolStripMenuItem = new ToolStripMenuItem();
            powerManagementToolStripMenuItem = new ToolStripMenuItem();
            shutdownToolStripMenuItem = new ToolStripMenuItem();
            rebootToolStripMenuItem = new ToolStripMenuItem();
            pingToolStripMenuItem = new ToolStripMenuItem();
            printersToolStripMenuItem = new ToolStripMenuItem();
            localAdminToolStripMenuItem = new ToolStripMenuItem();
            sentMessageToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton3 = new ToolStripSplitButton();
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            treeView1 = new TreeView();
            label2 = new Label();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Alignment = ListViewAlignment.SnapToGrid;
            listView1.AllowColumnReorder = true;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnHeader, columnHeader1, columnHeader2, columnHeader3, columnHeader6, columnHeader4, columnHeader5 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(219, 62);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(914, 517);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnHeader
            // 
            ColumnHeader.Text = "Name";
            ColumnHeader.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Description";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Location";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "OS";
            columnHeader3.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Company";
            columnHeader6.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "IP";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "User";
            columnHeader5.Width = 120;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { remoteControlToolStripMenuItem, computerManagementToolStripMenuItem, sCCMConnectionToolStripMenuItem, whoOnlineToolStripMenuItem, discCToolStripMenuItem, shareFolderToolStripMenuItem, powerManagementToolStripMenuItem, pingToolStripMenuItem, printersToolStripMenuItem, localAdminToolStripMenuItem, sentMessageToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.OwnerItem = toolStripButton3;
            contextMenuStrip1.Size = new Size(203, 268);
            // 
            // remoteControlToolStripMenuItem
            // 
            remoteControlToolStripMenuItem.Image = Properties.Resources._32officeicons_31_89708;
            remoteControlToolStripMenuItem.Name = "remoteControlToolStripMenuItem";
            remoteControlToolStripMenuItem.Size = new Size(202, 22);
            remoteControlToolStripMenuItem.Text = "Remote control";
            remoteControlToolStripMenuItem.Click += remoteControlToolStripMenuItem_Click;
            // 
            // computerManagementToolStripMenuItem
            // 
            computerManagementToolStripMenuItem.Image = Properties.Resources.rocket_startup_monitor_screen_computer_icon_124621;
            computerManagementToolStripMenuItem.Name = "computerManagementToolStripMenuItem";
            computerManagementToolStripMenuItem.Size = new Size(202, 22);
            computerManagementToolStripMenuItem.Text = "Computer Management";
            computerManagementToolStripMenuItem.Click += computerManagementToolStripMenuItem_Click;
            // 
            // sCCMConnectionToolStripMenuItem
            // 
            sCCMConnectionToolStripMenuItem.Image = Properties.Resources.cable_connect_connection_computer_hardware_icon_141983;
            sCCMConnectionToolStripMenuItem.Name = "sCCMConnectionToolStripMenuItem";
            sCCMConnectionToolStripMenuItem.Size = new Size(202, 22);
            sCCMConnectionToolStripMenuItem.Text = "SCCM connection";
            sCCMConnectionToolStripMenuItem.Click += sCCMConnectionToolStripMenuItem_Click;
            // 
            // whoOnlineToolStripMenuItem
            // 
            whoOnlineToolStripMenuItem.Image = Properties.Resources.question_emoticon_5618;
            whoOnlineToolStripMenuItem.Name = "whoOnlineToolStripMenuItem";
            whoOnlineToolStripMenuItem.Size = new Size(202, 22);
            whoOnlineToolStripMenuItem.Text = "Who online?";
            whoOnlineToolStripMenuItem.Click += whoOnlineToolStripMenuItem_Click;
            // 
            // discCToolStripMenuItem
            // 
            discCToolStripMenuItem.Image = Properties.Resources.documents_folder_18875;
            discCToolStripMenuItem.Name = "discCToolStripMenuItem";
            discCToolStripMenuItem.Size = new Size(202, 22);
            discCToolStripMenuItem.Text = "Disc C:\\";
            discCToolStripMenuItem.Click += discCToolStripMenuItem_Click;
            // 
            // shareFolderToolStripMenuItem
            // 
            shareFolderToolStripMenuItem.Image = Properties.Resources.OneDrive_Folder_23362;
            shareFolderToolStripMenuItem.Name = "shareFolderToolStripMenuItem";
            shareFolderToolStripMenuItem.Size = new Size(202, 22);
            shareFolderToolStripMenuItem.Text = "Share folder";
            shareFolderToolStripMenuItem.Click += shareFolderToolStripMenuItem_Click;
            // 
            // powerManagementToolStripMenuItem
            // 
            powerManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shutdownToolStripMenuItem, rebootToolStripMenuItem });
            powerManagementToolStripMenuItem.Name = "powerManagementToolStripMenuItem";
            powerManagementToolStripMenuItem.Size = new Size(202, 22);
            powerManagementToolStripMenuItem.Text = "Power management";
            // 
            // shutdownToolStripMenuItem
            // 
            shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            shutdownToolStripMenuItem.Size = new Size(128, 22);
            shutdownToolStripMenuItem.Text = "Shutdown";
            shutdownToolStripMenuItem.Click += shutdownToolStripMenuItem_Click;
            // 
            // rebootToolStripMenuItem
            // 
            rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            rebootToolStripMenuItem.Size = new Size(128, 22);
            rebootToolStripMenuItem.Text = "Reboot";
            rebootToolStripMenuItem.Click += rebootToolStripMenuItem_Click;
            // 
            // pingToolStripMenuItem
            // 
            pingToolStripMenuItem.Image = Properties.Resources.ping_big_logo_icon_icons_com_68373;
            pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            pingToolStripMenuItem.Size = new Size(202, 22);
            pingToolStripMenuItem.Text = "Ping";
            pingToolStripMenuItem.Click += pingToolStripMenuItem_Click;
            // 
            // printersToolStripMenuItem
            // 
            printersToolStripMenuItem.Image = Properties.Resources.printer;
            printersToolStripMenuItem.Name = "printersToolStripMenuItem";
            printersToolStripMenuItem.Size = new Size(202, 22);
            printersToolStripMenuItem.Text = "Printers";
            printersToolStripMenuItem.Click += printersToolStripMenuItem_Click;
            // 
            // localAdminToolStripMenuItem
            // 
            localAdminToolStripMenuItem.Image = Properties.Resources.image_07_10_22_12_14_2;
            localAdminToolStripMenuItem.Name = "localAdminToolStripMenuItem";
            localAdminToolStripMenuItem.Size = new Size(202, 22);
            localAdminToolStripMenuItem.Text = "Local admin";
            localAdminToolStripMenuItem.Click += localAdminToolStripMenuItem_Click;
            // 
            // sentMessageToolStripMenuItem
            // 
            sentMessageToolStripMenuItem.Image = Properties.Resources.student_work_office_desk_work_space_computer_working_support_icon_191191;
            sentMessageToolStripMenuItem.Name = "sentMessageToolStripMenuItem";
            sentMessageToolStripMenuItem.Size = new Size(202, 22);
            sentMessageToolStripMenuItem.Text = "Send message";
            sentMessageToolStripMenuItem.Click += sentMessageToolStripMenuItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.DropDown = contextMenuStrip1;
            toolStripButton3.Image = Properties.Resources.computer_77914;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(66, 56);
            toolStripButton3.Text = "Modes";
            toolStripButton3.ToolTipText = "Modes";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folderorangecd_93301.png");
            imageList1.Images.SetKeyName(1, "folderorangewifi_93453.png");
            imageList1.Images.SetKeyName(2, "folderyellow_92963.png");
            imageList1.Images.SetKeyName(3, "like-icon_31852.png");
            imageList1.Images.SetKeyName(4, "dislike-icon_31856.png");
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator4, toolStripButton3, toolStripButton2, toolStripButton5, toolStripButton6, toolStripButton4, toolStripSeparator3, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1145, 59);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 59);
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.BackColor = Color.Transparent;
            toolStripButton2.BackgroundImageLayout = ImageLayout.Zoom;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.microsoft_excel_alt_macos_bigsur_icon_189979;
            toolStripButton2.ImageTransparentColor = Color.Transparent;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(56, 56);
            toolStripButton2.Text = "Excel";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Enabled = false;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 56);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Enabled = false;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 56);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Enabled = false;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 56);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 59);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.iconfinder_technologymachineelectronicdevice39_4026421_113339;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(54, 56);
            toolStripButton1.Text = "Scan computers";
            toolStripButton1.Click += ScanButton1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 585);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1121, 120);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(631, 5);
            label1.Name = "label1";
            label1.Size = new Size(500, 15);
            label1.TabIndex = 3;
            label1.Text = "               ";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(12, 62);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(201, 517);
            treeView1.TabIndex = 4;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1002, 40);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 717);
            Controls.Add(label2);
            Controls.Add(treeView1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AD Monitoring";
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ColumnHeader ColumnHeader;
        public ListView listView1;
        private RichTextBox richTextBox1;
        private Label label1;
        private ToolStripButton toolStripButton2;
        private TreeView treeView1;
        private ImageList imageList1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label2;
        private ToolStripMenuItem remoteControlToolStripMenuItem;
        private ToolStripMenuItem computerManagementToolStripMenuItem;
        private ToolStripMenuItem sCCMConnectionToolStripMenuItem;
        private ToolStripMenuItem discCToolStripMenuItem;
        private ToolStripSplitButton toolStripButton3;
        private ToolStripMenuItem shareFolderToolStripMenuItem;
        private ToolStripMenuItem powerManagementToolStripMenuItem;
        private ToolStripMenuItem shutdownToolStripMenuItem;
        private ToolStripMenuItem rebootToolStripMenuItem;
        private ToolStripMenuItem pingToolStripMenuItem;
        private ToolStripMenuItem printersToolStripMenuItem;
        private ToolStripMenuItem localAdminToolStripMenuItem;
        private ToolStripMenuItem sentMessageToolStripMenuItem;
        private ToolStripMenuItem whoOnlineToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        public ContextMenuStrip contextMenuStrip1;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton4;
    }
}