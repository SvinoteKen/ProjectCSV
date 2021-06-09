namespace ProjectCSV
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.findTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.findRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statesListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.diagramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findTextBox
            // 
            this.findTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findTextBox.Depth = 0;
            this.findTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findTextBox.LeadingIcon = null;
            this.findTextBox.Location = new System.Drawing.Point(3, 3);
            this.findTextBox.MaxLength = 50;
            this.findTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.findTextBox.Multiline = false;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(280, 50);
            this.findTextBox.TabIndex = 0;
            this.findTextBox.Text = "";
            this.findTextBox.TrailingIcon = null;
            // 
            // findRadioButton
            // 
            this.findRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findRadioButton.Depth = 0;
            this.findRadioButton.Location = new System.Drawing.Point(286, 0);
            this.findRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.findRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.findRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.findRadioButton.Name = "findRadioButton";
            this.findRadioButton.Ripple = true;
            this.findRadioButton.Size = new System.Drawing.Size(100, 25);
            this.findRadioButton.TabIndex = 1;
            this.findRadioButton.TabStop = true;
            this.findRadioButton.Text = "Найти";
            this.findRadioButton.UseVisualStyleBackColor = true;
            this.findRadioButton.CheckedChanged += new System.EventHandler(this.findRadioButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.updateButton.AutoSize = false;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(305, 516);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(158, 45);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Обновить";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(49, 516);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 45);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteButton.AutoSize = false;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(561, 516);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(158, 45);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.15144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.84856F));
            this.tableLayoutPanel2.Controls.Add(this.findTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.findRadioButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelRadioButton, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(771, 513);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 51);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // cancelRadioButton
            // 
            this.cancelRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelRadioButton.Depth = 0;
            this.cancelRadioButton.Location = new System.Drawing.Point(286, 25);
            this.cancelRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cancelRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelRadioButton.Name = "cancelRadioButton";
            this.cancelRadioButton.Ripple = true;
            this.cancelRadioButton.Size = new System.Drawing.Size(100, 26);
            this.cancelRadioButton.TabIndex = 2;
            this.cancelRadioButton.TabStop = true;
            this.cancelRadioButton.Text = "Отмена";
            this.cancelRadioButton.UseVisualStyleBackColor = true;
            this.cancelRadioButton.CheckedChanged += new System.EventHandler(this.cancelRadioButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.14839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.14839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.14839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.55482F));
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statesListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.94709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.05291F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 567);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // statesListView
            // 
            this.statesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statesListView.AutoSizeTable = false;
            this.statesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader13,
            this.columnHeader14});
            this.tableLayoutPanel1.SetColumnSpan(this.statesListView, 4);
            this.statesListView.ContextMenuStrip = this.contextMenuStrip1;
            this.statesListView.Depth = 0;
            this.statesListView.FullRowSelect = true;
            this.statesListView.HideSelection = false;
            this.statesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.statesListView.Location = new System.Drawing.Point(3, 3);
            this.statesListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.statesListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.statesListView.MouseState = MaterialSkin.MouseState.OUT;
            this.statesListView.Name = "statesListView";
            this.statesListView.OwnerDraw = true;
            this.statesListView.Size = new System.Drawing.Size(1154, 504);
            this.statesListView.TabIndex = 1;
            this.statesListView.UseCompatibleStateImageBehavior = false;
            this.statesListView.View = System.Windows.Forms.View.Details;
            this.statesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.statesListView_ColumnClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Регион";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Штат";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Площадь тыс. км^2";
            this.columnHeader13.Width = 250;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Население тыс. чел.";
            this.columnHeader14.Width = 250;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletMenuItem,
            this.updateMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.diagramMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            // 
            // deletMenuItem
            // 
            this.deletMenuItem.Name = "deletMenuItem";
            this.deletMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletMenuItem.Text = "Удалить";
            this.deletMenuItem.Click += new System.EventHandler(this.deletMenuItem_Click);
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateMenuItem.Text = "Обновить";
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Печать";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Новый файл",
            "Старый файл"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // diagramMenuItem
            // 
            this.diagramMenuItem.Name = "diagramMenuItem";
            this.diagramMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diagramMenuItem.Text = "Диаграмма";
            this.diagramMenuItem.Click += new System.EventHandler(this.diagramMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Штаты Австралии";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialTextBox findTextBox;
        private MaterialSkin.Controls.MaterialRadioButton findRadioButton;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialRadioButton cancelRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListView statesListView;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem diagramMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

