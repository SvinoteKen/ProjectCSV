namespace ProjectCSV.Views
{
    partial class AddState
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
            this.regionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.populationText = new MaterialSkin.Controls.MaterialTextBox();
            this.stateText = new MaterialSkin.Controls.MaterialTextBox();
            this.areaText = new MaterialSkin.Controls.MaterialTextBox();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.okButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regionComboBox
            // 
            this.regionComboBox.AutoResize = false;
            this.regionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regionComboBox.Depth = 0;
            this.regionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.regionComboBox.DropDownHeight = 174;
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.DropDownWidth = 121;
            this.regionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.regionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.IntegralHeight = false;
            this.regionComboBox.ItemHeight = 43;
            this.regionComboBox.Items.AddRange(new object[] {
            "Северный",
            "Южный",
            "Западный",
            "Восточный"});
            this.regionComboBox.Location = new System.Drawing.Point(93, 114);
            this.regionComboBox.MaxDropDownItems = 4;
            this.regionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(326, 49);
            this.regionComboBox.StartIndex = 0;
            this.regionComboBox.TabIndex = 87;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(487, 176);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 19);
            this.materialLabel5.TabIndex = 85;
            this.materialLabel5.Text = "Население";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(487, 93);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 84;
            this.materialLabel4.Text = "Штат";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(90, 175);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 83;
            this.materialLabel2.Text = "Площадь";
            // 
            // populationText
            // 
            this.populationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.populationText.Depth = 0;
            this.populationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.populationText.LeadingIcon = null;
            this.populationText.Location = new System.Drawing.Point(484, 197);
            this.populationText.MaxLength = 30;
            this.populationText.MouseState = MaterialSkin.MouseState.OUT;
            this.populationText.Multiline = false;
            this.populationText.Name = "populationText";
            this.populationText.Size = new System.Drawing.Size(326, 50);
            this.populationText.TabIndex = 82;
            this.populationText.Text = "";
            this.populationText.TrailingIcon = null;
            // 
            // stateText
            // 
            this.stateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateText.Depth = 0;
            this.stateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stateText.LeadingIcon = null;
            this.stateText.Location = new System.Drawing.Point(484, 115);
            this.stateText.MaxLength = 30;
            this.stateText.MouseState = MaterialSkin.MouseState.OUT;
            this.stateText.Multiline = false;
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(326, 50);
            this.stateText.TabIndex = 81;
            this.stateText.Text = "";
            this.stateText.TrailingIcon = null;
            // 
            // areaText
            // 
            this.areaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.areaText.Depth = 0;
            this.areaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.areaText.LeadingIcon = null;
            this.areaText.Location = new System.Drawing.Point(93, 197);
            this.areaText.MaxLength = 30;
            this.areaText.MouseState = MaterialSkin.MouseState.OUT;
            this.areaText.Multiline = false;
            this.areaText.Name = "areaText";
            this.areaText.Size = new System.Drawing.Size(326, 50);
            this.areaText.TabIndex = 80;
            this.areaText.Text = "";
            this.areaText.TrailingIcon = null;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(592, 292);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 36);
            this.cancelButton.TabIndex = 79;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.AutoSize = false;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.okButton.Depth = 0;
            this.okButton.HighEmphasis = true;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(153, 292);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(158, 36);
            this.okButton.TabIndex = 78;
            this.okButton.Text = "OK";
            this.okButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.okButton.UseAccentColor = false;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(90, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 77;
            this.materialLabel1.Text = "Регион";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(592, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(218, 20);
            this.textBox5.TabIndex = 76;
            // 
            // AddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 356);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.populationText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.areaText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBox5);
            this.Name = "AddState";
            this.Text = "Добавить Штат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox regionComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox populationText;
        private MaterialSkin.Controls.MaterialTextBox stateText;
        private MaterialSkin.Controls.MaterialTextBox areaText;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton okButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBox5;
    }
}