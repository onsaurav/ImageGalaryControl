namespace ImageGalaryControl
{
    partial class ucImageControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucImageControl));
            this.tlsImgGalary = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbAddAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUp = new System.Windows.Forms.ToolStripButton();
            this.tsbDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbThumbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbCreate = new System.Windows.Forms.ToolStripButton();
            this.panSettings = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.picTumb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.P = new System.Windows.Forms.ProgressBar();
            this.lvwImage = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panThambSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.cboAlignment = new System.Windows.Forms.ComboBox();
            this.Alignment = new System.Windows.Forms.Label();
            this.Column = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picThambst = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboThambStyle = new System.Windows.Forms.ComboBox();
            this.txtMiWidth = new System.Windows.Forms.TextBox();
            this.txtMIHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tlsImgGalary.SuspendLayout();
            this.panSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTumb)).BeginInit();
            this.panThambSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThambst)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsImgGalary
            // 
            this.tlsImgGalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(177)))), ((int)(((byte)(237)))));
            this.tlsImgGalary.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.tlsImgGalary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator,
            this.tsbAdd,
            this.tsbAddAll,
            this.toolStripSeparator3,
            this.tsbClear,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.tsbUp,
            this.tsbDown,
            this.toolStripSeparator1,
            this.tsbThumbSettings,
            this.tsbSettings,
            this.tsbCreate});
            this.tlsImgGalary.Location = new System.Drawing.Point(0, 0);
            this.tlsImgGalary.Name = "tlsImgGalary";
            this.tlsImgGalary.Size = new System.Drawing.Size(737, 42);
            this.tlsImgGalary.TabIndex = 24;
            this.tlsImgGalary.Text = "tstTools";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::ImageGalaryControl.Properties.Resources.folder__1_;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(39, 39);
            this.tsbOpen.Text = "toolStripButton7";
            this.tsbOpen.ToolTipText = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::ImageGalaryControl.Properties.Resources.document_save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(39, 39);
            this.tsbSave.Text = "toolStripButton8";
            this.tsbSave.ToolTipText = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::ImageGalaryControl.Properties.Resources.document_new;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(39, 39);
            this.tsbAdd.Text = "toolStripButton1";
            this.tsbAdd.ToolTipText = "Add Image";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbAddAll
            // 
            this.tsbAddAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAll.Image")));
            this.tsbAddAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAll.Name = "tsbAddAll";
            this.tsbAddAll.Size = new System.Drawing.Size(39, 39);
            this.tsbAddAll.Text = "Add All";
            this.tsbAddAll.ToolTipText = "Add all from a Folder";
            this.tsbAddAll.Click += new System.EventHandler(this.tsbAddAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(39, 39);
            this.tsbClear.Text = "toolStripButton1";
            this.tsbClear.ToolTipText = "Clear All";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::ImageGalaryControl.Properties.Resources.deletered;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(39, 39);
            this.tsbDelete.Text = "toolStripButton2";
            this.tsbDelete.ToolTipText = "Delete Image";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbUp
            // 
            this.tsbUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUp.Image = global::ImageGalaryControl.Properties.Resources.up_256;
            this.tsbUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUp.Name = "tsbUp";
            this.tsbUp.Size = new System.Drawing.Size(39, 39);
            this.tsbUp.Text = "toolStripButton4";
            this.tsbUp.ToolTipText = "Up";
            this.tsbUp.Click += new System.EventHandler(this.tsbUp_Click);
            // 
            // tsbDown
            // 
            this.tsbDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDown.Image = global::ImageGalaryControl.Properties.Resources.down_256;
            this.tsbDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDown.Name = "tsbDown";
            this.tsbDown.Size = new System.Drawing.Size(39, 39);
            this.tsbDown.Text = "toolStripButton3";
            this.tsbDown.ToolTipText = "Down";
            this.tsbDown.Click += new System.EventHandler(this.tsbDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbThumbSettings
            // 
            this.tsbThumbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThumbSettings.Image = global::ImageGalaryControl.Properties.Resources.boot;
            this.tsbThumbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThumbSettings.Name = "tsbThumbSettings";
            this.tsbThumbSettings.Size = new System.Drawing.Size(39, 39);
            this.tsbThumbSettings.Text = "toolStripButton1";
            this.tsbThumbSettings.ToolTipText = "Other Settings";
            this.tsbThumbSettings.Click += new System.EventHandler(this.tsbThumbSettings_Click);
            // 
            // tsbSettings
            // 
            this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettings.Image = global::ImageGalaryControl.Properties.Resources.preferences_desktop_personal;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(39, 39);
            this.tsbSettings.Text = "toolStripButton5";
            this.tsbSettings.ToolTipText = "Settings";
            this.tsbSettings.Click += new System.EventHandler(this.tsbSettings_Click);
            // 
            // tsbCreate
            // 
            this.tsbCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCreate.Image = global::ImageGalaryControl.Properties.Resources.publish;
            this.tsbCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreate.Name = "tsbCreate";
            this.tsbCreate.Size = new System.Drawing.Size(39, 39);
            this.tsbCreate.Text = "toolStripButton6";
            this.tsbCreate.ToolTipText = "Create Galary";
            this.tsbCreate.Click += new System.EventHandler(this.tsbCreate_Click);
            // 
            // panSettings
            // 
            this.panSettings.Controls.Add(this.btnClose);
            this.panSettings.Controls.Add(this.picTumb);
            this.panSettings.Controls.Add(this.label1);
            this.panSettings.Controls.Add(this.cboStyle);
            this.panSettings.Location = new System.Drawing.Point(14, 59);
            this.panSettings.Name = "panSettings";
            this.panSettings.Size = new System.Drawing.Size(211, 287);
            this.panSettings.TabIndex = 23;
            this.panSettings.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(127, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 21);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picTumb
            // 
            this.picTumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTumb.Location = new System.Drawing.Point(15, 42);
            this.picTumb.Name = "picTumb";
            this.picTumb.Size = new System.Drawing.Size(181, 207);
            this.picTumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTumb.TabIndex = 2;
            this.picTumb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Style";
            // 
            // cboStyle
            // 
            this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Items.AddRange(new object[] {
            "Androied",
            "Dark_Glass",
            "Facebook",
            "iPhone",
            "Mac",
            "Vista"});
            this.cboStyle.Location = new System.Drawing.Point(91, 13);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(105, 21);
            this.cboStyle.TabIndex = 0;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(14, 43);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(211, 16);
            this.P.TabIndex = 22;
            this.P.Visible = false;
            // 
            // lvwImage
            // 
            this.lvwImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwImage.LargeImageList = this.imageList1;
            this.lvwImage.Location = new System.Drawing.Point(1, 43);
            this.lvwImage.Name = "lvwImage";
            this.lvwImage.Size = new System.Drawing.Size(735, 360);
            this.lvwImage.SmallImageList = this.imageList1;
            this.lvwImage.TabIndex = 21;
            this.lvwImage.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 75);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panThambSettings
            // 
            this.panThambSettings.Controls.Add(this.txtMiWidth);
            this.panThambSettings.Controls.Add(this.txtMIHeight);
            this.panThambSettings.Controls.Add(this.label5);
            this.panThambSettings.Controls.Add(this.label6);
            this.panThambSettings.Controls.Add(this.label4);
            this.panThambSettings.Controls.Add(this.button1);
            this.panThambSettings.Controls.Add(this.txtColumn);
            this.panThambSettings.Controls.Add(this.txtWidth);
            this.panThambSettings.Controls.Add(this.txtHeight);
            this.panThambSettings.Controls.Add(this.cboAlignment);
            this.panThambSettings.Controls.Add(this.Alignment);
            this.panThambSettings.Controls.Add(this.Column);
            this.panThambSettings.Controls.Add(this.label3);
            this.panThambSettings.Controls.Add(this.picThambst);
            this.panThambSettings.Controls.Add(this.label2);
            this.panThambSettings.Controls.Add(this.cboThambStyle);
            this.panThambSettings.Location = new System.Drawing.Point(29, 59);
            this.panThambSettings.Name = "panThambSettings";
            this.panThambSettings.Size = new System.Drawing.Size(231, 231);
            this.panThambSettings.TabIndex = 25;
            this.panThambSettings.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Width";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(151, 107);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(65, 20);
            this.txtColumn.TabIndex = 11;
            this.txtColumn.Text = "10";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(151, 85);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(65, 20);
            this.txtWidth.TabIndex = 10;
            this.txtWidth.Text = "100";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(151, 63);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(65, 20);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.Text = "75";
            // 
            // cboAlignment
            // 
            this.cboAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlignment.FormattingEnabled = true;
            this.cboAlignment.Location = new System.Drawing.Point(111, 37);
            this.cboAlignment.Name = "cboAlignment";
            this.cboAlignment.Size = new System.Drawing.Size(105, 21);
            this.cboAlignment.TabIndex = 8;
            this.cboAlignment.SelectedIndexChanged += new System.EventHandler(this.cboAlignment_SelectedIndexChanged);
            this.cboAlignment.Enter += new System.EventHandler(this.cboAlignment_Enter);
            // 
            // Alignment
            // 
            this.Alignment.AutoSize = true;
            this.Alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alignment.Location = new System.Drawing.Point(12, 37);
            this.Alignment.Name = "Alignment";
            this.Alignment.Size = new System.Drawing.Size(62, 13);
            this.Alignment.TabIndex = 7;
            this.Alignment.Text = "Alignment";
            // 
            // Column
            // 
            this.Column.AutoSize = true;
            this.Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column.Location = new System.Drawing.Point(12, 107);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(48, 13);
            this.Column.TabIndex = 6;
            this.Column.Text = "Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // picThambst
            // 
            this.picThambst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThambst.Location = new System.Drawing.Point(73, 63);
            this.picThambst.Name = "picThambst";
            this.picThambst.Size = new System.Drawing.Size(72, 44);
            this.picThambst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThambst.TabIndex = 2;
            this.picThambst.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Style";
            // 
            // cboThambStyle
            // 
            this.cboThambStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThambStyle.FormattingEnabled = true;
            this.cboThambStyle.Items.AddRange(new object[] {
            "Androied",
            "Facebook",
            "iPhone",
            "StickyNotes",
            "Vista",
            "Special"});
            this.cboThambStyle.Location = new System.Drawing.Point(111, 13);
            this.cboThambStyle.Name = "cboThambStyle";
            this.cboThambStyle.Size = new System.Drawing.Size(105, 21);
            this.cboThambStyle.TabIndex = 0;
            this.cboThambStyle.SelectedIndexChanged += new System.EventHandler(this.cboThambStyle_SelectedIndexChanged);
            // 
            // txtMiWidth
            // 
            this.txtMiWidth.Location = new System.Drawing.Point(152, 164);
            this.txtMiWidth.Name = "txtMiWidth";
            this.txtMiWidth.Size = new System.Drawing.Size(65, 20);
            this.txtMiWidth.TabIndex = 20;
            this.txtMiWidth.Text = "750";
            this.txtMiWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiWidth_KeyPress);
            // 
            // txtMIHeight
            // 
            this.txtMIHeight.Location = new System.Drawing.Point(152, 142);
            this.txtMIHeight.Name = "txtMIHeight";
            this.txtMIHeight.Size = new System.Drawing.Size(65, 20);
            this.txtMIHeight.TabIndex = 19;
            this.txtMIHeight.Text = "550";
            this.txtMIHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMIHeight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Main Image Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Main Image Height";
            // 
            // ucImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(177)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panThambSettings);
            this.Controls.Add(this.tlsImgGalary);
            this.Controls.Add(this.panSettings);
            this.Controls.Add(this.P);
            this.Controls.Add(this.lvwImage);
            this.Name = "ucImageControl";
            this.Size = new System.Drawing.Size(737, 413);
            this.Load += new System.EventHandler(this.ucImageControl_Load);
            this.Resize += new System.EventHandler(this.ucImageControl_Resize);
            this.tlsImgGalary.ResumeLayout(false);
            this.tlsImgGalary.PerformLayout();
            this.panSettings.ResumeLayout(false);
            this.panSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTumb)).EndInit();
            this.panThambSettings.ResumeLayout(false);
            this.panThambSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThambst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsImgGalary;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbAddAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbUp;
        private System.Windows.Forms.ToolStripButton tsbDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStripButton tsbCreate;
        private System.Windows.Forms.Panel panSettings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picTumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.ProgressBar P;
        private System.Windows.Forms.ListView lvwImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panThambSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.ComboBox cboAlignment;
        private System.Windows.Forms.Label Alignment;
        private System.Windows.Forms.Label Column;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picThambst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboThambStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tsbThumbSettings;
        private System.Windows.Forms.TextBox txtMiWidth;
        private System.Windows.Forms.TextBox txtMIHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
