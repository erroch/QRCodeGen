namespace QRCodeGen
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
            label1 = new Label();
            txtURL = new TextBox();
            label2 = new Label();
            btnUploadIcon = new Button();
            picQRCode = new PictureBox();
            btnSave = new Button();
            btnGenerate = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label3 = new Label();
            cboECCLevel = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            numericUpDownIconSize = new NumericUpDown();
            picIcon = new PictureBox();
            btnClearIcon = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIconSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtURL.Location = new Point(63, 6);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(394, 23);
            txtURL.TabIndex = 1;
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Icon %:";
            // 
            // btnUploadIcon
            // 
            btnUploadIcon.Location = new Point(211, 38);
            btnUploadIcon.Name = "btnUploadIcon";
            btnUploadIcon.Size = new Size(75, 23);
            btnUploadIcon.TabIndex = 3;
            btnUploadIcon.Text = "Set Icon";
            btnUploadIcon.UseVisualStyleBackColor = true;
            btnUploadIcon.Click += btnUploadIcon_Click;
            // 
            // picQRCode
            // 
            picQRCode.Location = new Point(3, 3);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(256, 256);
            picQRCode.TabIndex = 5;
            picQRCode.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(4, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(4, 99);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 38);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "ECC:";
            // 
            // cboECCLevel
            // 
            cboECCLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboECCLevel.FormattingEnabled = true;
            cboECCLevel.Items.AddRange(new object[] { "Default", "L", "M", "Q", "H" });
            cboECCLevel.Location = new Point(63, 35);
            cboECCLevel.Name = "cboECCLevel";
            cboECCLevel.Size = new Size(121, 23);
            cboECCLevel.TabIndex = 9;
            cboECCLevel.SelectedIndexChanged += cboECCLevel_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDownIconSize
            // 
            numericUpDownIconSize.Location = new Point(63, 66);
            numericUpDownIconSize.Name = "numericUpDownIconSize";
            numericUpDownIconSize.Size = new Size(120, 23);
            numericUpDownIconSize.TabIndex = 11;
            numericUpDownIconSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // picIcon
            // 
            picIcon.Location = new Point(292, 35);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(64, 64);
            picIcon.TabIndex = 12;
            picIcon.TabStop = false;
            // 
            // btnClearIcon
            // 
            btnClearIcon.Location = new Point(211, 64);
            btnClearIcon.Name = "btnClearIcon";
            btnClearIcon.Size = new Size(75, 23);
            btnClearIcon.TabIndex = 13;
            btnClearIcon.Text = "Clear Icon";
            btnClearIcon.UseVisualStyleBackColor = true;
            btnClearIcon.Click += btnClearIcon_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(picQRCode);
            panel1.Location = new Point(86, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 366);
            panel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 478);
            Controls.Add(panel1);
            Controls.Add(btnClearIcon);
            Controls.Add(picIcon);
            Controls.Add(numericUpDownIconSize);
            Controls.Add(cboECCLevel);
            Controls.Add(label3);
            Controls.Add(btnGenerate);
            Controls.Add(btnSave);
            Controls.Add(btnUploadIcon);
            Controls.Add(label2);
            Controls.Add(txtURL);
            Controls.Add(label1);
            Name = "Form1";
            Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIconSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtURL;
        private Label label2;
        private Button btnUploadIcon;
        private PictureBox picQRCode;
        private Button btnSave;
        private Button btnGenerate;
        private SaveFileDialog saveFileDialog1;
        private Label label3;
        private ComboBox cboECCLevel;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown numericUpDownIconSize;
        private PictureBox picIcon;
        private Button btnClearIcon;
        private Panel panel1;
    }
}
