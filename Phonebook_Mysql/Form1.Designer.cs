﻿
namespace Phonebook_Mysql
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label debtLabel;
            System.Windows.Forms.Label mobile_noLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.phonebookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.phonebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonebook = new Phonebook_Mysql.Dataset.phonebook();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phonebookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.debtTextBox = new System.Windows.Forms.TextBox();
            this.mobile_noTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.del_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.save_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cancel_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.phonebookTableAdapter = new Phonebook_Mysql.Dataset.phonebookTableAdapters.phonebookTableAdapter();
            this.tableAdapterManager = new Phonebook_Mysql.Dataset.phonebookTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browse_button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.phonebookDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            idLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            debtLabel = new System.Windows.Forms.Label();
            mobile_noLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingNavigator)).BeginInit();
            this.phonebookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(51, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(29, 22);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(51, 56);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(93, 22);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(51, 90);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(92, 22);
            last_nameLabel.TabIndex = 6;
            last_nameLabel.Text = "last name:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(51, 125);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(45, 22);
            dobLabel.TabIndex = 8;
            dobLabel.Text = "dob:";
            // 
            // debtLabel
            // 
            debtLabel.AutoSize = true;
            debtLabel.Location = new System.Drawing.Point(51, 158);
            debtLabel.Name = "debtLabel";
            debtLabel.Size = new System.Drawing.Size(50, 22);
            debtLabel.TabIndex = 10;
            debtLabel.Text = "debt:";
            // 
            // mobile_noLabel
            // 
            mobile_noLabel.AutoSize = true;
            mobile_noLabel.Location = new System.Drawing.Point(51, 192);
            mobile_noLabel.Name = "mobile_noLabel";
            mobile_noLabel.Size = new System.Drawing.Size(92, 22);
            mobile_noLabel.TabIndex = 12;
            mobile_noLabel.Text = "mobile no:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(51, 226);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 22);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "email:";
            // 
            // phonebookBindingNavigator
            // 
            this.phonebookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phonebookBindingNavigator.BindingSource = this.phonebookBindingSource;
            this.phonebookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phonebookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phonebookBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phonebookBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.phonebookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phonebookBindingNavigatorSaveItem});
            this.phonebookBindingNavigator.Location = new System.Drawing.Point(0, 540);
            this.phonebookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phonebookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phonebookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phonebookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phonebookBindingNavigator.Name = "phonebookBindingNavigator";
            this.phonebookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phonebookBindingNavigator.Size = new System.Drawing.Size(649, 38);
            this.phonebookBindingNavigator.TabIndex = 0;
            this.phonebookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // phonebookBindingSource
            // 
            this.phonebookBindingSource.DataMember = "phonebook";
            this.phonebookBindingSource.DataSource = this.phonebook;
            // 
            // phonebook
            // 
            this.phonebook.DataSetName = "phonebook";
            this.phonebook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // phonebookBindingNavigatorSaveItem
            // 
            this.phonebookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phonebookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phonebookBindingNavigatorSaveItem.Image")));
            this.phonebookBindingNavigatorSaveItem.Name = "phonebookBindingNavigatorSaveItem";
            this.phonebookBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.phonebookBindingNavigatorSaveItem.Text = "Save Data";
            this.phonebookBindingNavigatorSaveItem.Visible = false;
            this.phonebookBindingNavigatorSaveItem.Click += new System.EventHandler(this.phonebookBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(150, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 28);
            this.idTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(150, 53);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 28);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(150, 87);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(200, 28);
            this.last_nameTextBox.TabIndex = 7;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phonebookBindingSource, "dob", true));
            this.dobDateTimePicker.Location = new System.Drawing.Point(150, 121);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.dobDateTimePicker.TabIndex = 9;
            // 
            // debtTextBox
            // 
            this.debtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "debt", true));
            this.debtTextBox.Location = new System.Drawing.Point(150, 155);
            this.debtTextBox.Name = "debtTextBox";
            this.debtTextBox.Size = new System.Drawing.Size(200, 28);
            this.debtTextBox.TabIndex = 11;
            // 
            // mobile_noTextBox
            // 
            this.mobile_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "mobile_no", true));
            this.mobile_noTextBox.Location = new System.Drawing.Point(150, 189);
            this.mobile_noTextBox.Name = "mobile_noTextBox";
            this.mobile_noTextBox.Size = new System.Drawing.Size(200, 28);
            this.mobile_noTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(150, 223);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 28);
            this.emailTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(first_nameLabel);
            this.groupBox1.Controls.Add(this.first_nameTextBox);
            this.groupBox1.Controls.Add(last_nameLabel);
            this.groupBox1.Controls.Add(this.last_nameTextBox);
            this.groupBox1.Controls.Add(dobLabel);
            this.groupBox1.Controls.Add(this.dobDateTimePicker);
            this.groupBox1.Controls.Add(debtLabel);
            this.groupBox1.Controls.Add(this.debtTextBox);
            this.groupBox1.Controls.Add(mobile_noLabel);
            this.groupBox1.Controls.Add(this.mobile_noTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 255);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_butt,
            this.toolStripSeparator4,
            this.edit_butt,
            this.toolStripSeparator3,
            this.del_butt,
            this.toolStripSeparator2,
            this.save_butt,
            this.toolStripSeparator5,
            this.cancel_butt,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 61);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_butt
            // 
            this.add_butt.Image = global::Phonebook_Mysql.Properties.Resources.new_butt;
            this.add_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(90, 56);
            this.add_butt.Text = "Add New";
            this.add_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 61);
            // 
            // edit_butt
            // 
            this.edit_butt.Image = global::Phonebook_Mysql.Properties.Resources.edit_butt;
            this.edit_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_butt.Name = "edit_butt";
            this.edit_butt.Size = new System.Drawing.Size(106, 56);
            this.edit_butt.Text = "Edit Record";
            this.edit_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.edit_butt.Click += new System.EventHandler(this.edit_butt_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 61);
            // 
            // del_butt
            // 
            this.del_butt.Image = global::Phonebook_Mysql.Properties.Resources.del_butt;
            this.del_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.del_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.del_butt.Name = "del_butt";
            this.del_butt.Size = new System.Drawing.Size(126, 56);
            this.del_butt.Text = "Delete Record";
            this.del_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.del_butt.Click += new System.EventHandler(this.del_butt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // save_butt
            // 
            this.save_butt.Image = global::Phonebook_Mysql.Properties.Resources.save_butt;
            this.save_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.save_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_butt.Name = "save_butt";
            this.save_butt.Size = new System.Drawing.Size(53, 56);
            this.save_butt.Text = "Save";
            this.save_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save_butt.Click += new System.EventHandler(this.save_butt_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 61);
            // 
            // cancel_butt
            // 
            this.cancel_butt.Image = global::Phonebook_Mysql.Properties.Resources.cancel_butt;
            this.cancel_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancel_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel_butt.Name = "cancel_butt";
            this.cancel_butt.Size = new System.Drawing.Size(67, 56);
            this.cancel_butt.Text = "Cancel";
            this.cancel_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancel_butt.Click += new System.EventHandler(this.cancel_butt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // phonebookTableAdapter
            // 
            this.phonebookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.phonebookTableAdapter = this.phonebookTableAdapter;
            this.tableAdapterManager.UpdateOrder = Phonebook_Mysql.Dataset.phonebookTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.browse_button1);
            this.groupBox2.Location = new System.Drawing.Point(395, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 255);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photo Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.phonebookBindingSource, "image", true));
            this.pictureBox1.Image = global::Phonebook_Mysql.Properties.Resources.no_image_png_2;
            this.pictureBox1.Location = new System.Drawing.Point(43, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // browse_button1
            // 
            this.browse_button1.Location = new System.Drawing.Point(73, 214);
            this.browse_button1.Name = "browse_button1";
            this.browse_button1.Size = new System.Drawing.Size(96, 31);
            this.browse_button1.TabIndex = 42;
            this.browse_button1.Text = "Browse";
            this.browse_button1.UseVisualStyleBackColor = true;
            this.browse_button1.Click += new System.EventHandler(this.browse_button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images|*.jpg;*.png";
            // 
            // phonebookDataGridView
            // 
            this.phonebookDataGridView.AllowUserToAddRows = false;
            this.phonebookDataGridView.AllowUserToDeleteRows = false;
            this.phonebookDataGridView.AutoGenerateColumns = false;
            this.phonebookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phonebookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.image});
            this.phonebookDataGridView.DataSource = this.phonebookBindingSource;
            this.phonebookDataGridView.Location = new System.Drawing.Point(12, 325);
            this.phonebookDataGridView.Name = "phonebookDataGridView";
            this.phonebookDataGridView.ReadOnly = true;
            this.phonebookDataGridView.RowHeadersWidth = 62;
            this.phonebookDataGridView.RowTemplate.Height = 50;
            this.phonebookDataGridView.Size = new System.Drawing.Size(617, 220);
            this.phonebookDataGridView.TabIndex = 44;
            this.phonebookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phonebookDataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 150;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "debt";
            this.debtDataGridViewTextBoxColumn.HeaderText = "debt";
            this.debtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            this.debtDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            this.mobilenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobilenoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(649, 578);
            this.Controls.Add(this.phonebookDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.phonebookBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook MySQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingNavigator)).EndInit();
            this.phonebookBindingNavigator.ResumeLayout(false);
            this.phonebookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.phonebook phonebook;
        private System.Windows.Forms.BindingSource phonebookBindingSource;
        private Dataset.phonebookTableAdapters.phonebookTableAdapter phonebookTableAdapter;
        private Dataset.phonebookTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phonebookBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phonebookBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox debtTextBox;
        private System.Windows.Forms.TextBox mobile_noTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton add_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton edit_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton del_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton save_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton cancel_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browse_button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView phonebookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}

