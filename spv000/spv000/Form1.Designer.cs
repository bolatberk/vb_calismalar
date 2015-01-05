namespace spv000
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
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudR = new System.Windows.Forms.ComboBox();
            this.comboBoxDataB = new System.Windows.Forms.ComboBox();
            this.comboBoxStopB = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myserial = new System.IO.Ports.SerialPort(this.components);
            this.rtbEkran = new System.Windows.Forms.TextBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.Openport_Click = new System.Windows.Forms.Button();
            this.closeport_Click = new System.Windows.Forms.Button();
            this.buttonSend_Click_Click = new System.Windows.Forms.Button();
            this.clear_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 0;
            // 
            // comboBoxBaudR
            // 
            this.comboBoxBaudR.FormattingEnabled = true;
            this.comboBoxBaudR.Items.AddRange(new object[] {
            "75",
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudR.Location = new System.Drawing.Point(12, 39);
            this.comboBoxBaudR.Name = "comboBoxBaudR";
            this.comboBoxBaudR.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudR.TabIndex = 1;
            // 
            // comboBoxDataB
            // 
            this.comboBoxDataB.FormattingEnabled = true;
            this.comboBoxDataB.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataB.Location = new System.Drawing.Point(12, 66);
            this.comboBoxDataB.Name = "comboBoxDataB";
            this.comboBoxDataB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDataB.TabIndex = 2;
            // 
            // comboBoxStopB
            // 
            this.comboBoxStopB.FormattingEnabled = true;
            this.comboBoxStopB.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopB.Location = new System.Drawing.Point(12, 120);
            this.comboBoxStopB.Name = "comboBoxStopB";
            this.comboBoxStopB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopB.TabIndex = 4;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParity.Location = new System.Drawing.Point(12, 93);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BaudRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(154, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(154, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(154, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop Bit";
            // 
            // rtbEkran
            // 
            this.rtbEkran.AllowDrop = true;
            this.rtbEkran.Location = new System.Drawing.Point(351, 12);
            this.rtbEkran.Multiline = true;
            this.rtbEkran.Name = "rtbEkran";
            this.rtbEkran.Size = new System.Drawing.Size(368, 139);
            this.rtbEkran.TabIndex = 10;
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Location = new System.Drawing.Point(351, 169);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(368, 41);
            this.richTextBoxSend.TabIndex = 11;
            this.richTextBoxSend.Text = "";
            // 
            // Openport_Click
            // 
            this.Openport_Click.Location = new System.Drawing.Point(12, 167);
            this.Openport_Click.Name = "Openport_Click";
            this.Openport_Click.Size = new System.Drawing.Size(75, 23);
            this.Openport_Click.TabIndex = 12;
            this.Openport_Click.Text = "Open";
            this.Openport_Click.UseVisualStyleBackColor = true;
            this.Openport_Click.Click += new System.EventHandler(this.Openport_Click_Click);
            // 
            // closeport_Click
            // 
            this.closeport_Click.Location = new System.Drawing.Point(93, 167);
            this.closeport_Click.Name = "closeport_Click";
            this.closeport_Click.Size = new System.Drawing.Size(70, 23);
            this.closeport_Click.TabIndex = 13;
            this.closeport_Click.Text = "Close";
            this.closeport_Click.UseVisualStyleBackColor = true;
            this.closeport_Click.Click += new System.EventHandler(this.closeport_Click_Click);
            // 
            // buttonSend_Click_Click
            // 
            this.buttonSend_Click_Click.Location = new System.Drawing.Point(351, 227);
            this.buttonSend_Click_Click.Name = "buttonSend_Click_Click";
            this.buttonSend_Click_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonSend_Click_Click.TabIndex = 14;
            this.buttonSend_Click_Click.Text = "Send";
            this.buttonSend_Click_Click.UseVisualStyleBackColor = true;
            this.buttonSend_Click_Click.Click += new System.EventHandler(this.buttonSend_Click_Click_Click);
            // 
            // clear_Click
            // 
            this.clear_Click.Location = new System.Drawing.Point(644, 227);
            this.clear_Click.Name = "clear_Click";
            this.clear_Click.Size = new System.Drawing.Size(75, 23);
            this.clear_Click.TabIndex = 15;
            this.clear_Click.Text = "Clear";
            this.clear_Click.UseVisualStyleBackColor = true;
            this.clear_Click.Click += new System.EventHandler(this.clear_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(781, 269);
            this.Controls.Add(this.clear_Click);
            this.Controls.Add(this.buttonSend_Click_Click);
            this.Controls.Add(this.closeport_Click);
            this.Controls.Add(this.Openport_Click);
            this.Controls.Add(this.richTextBoxSend);
            this.Controls.Add(this.rtbEkran);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStopB);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxDataB);
            this.Controls.Add(this.comboBoxBaudR);
            this.Controls.Add(this.comboBoxPort);
            this.Name = "Form1";
            this.Text = "Basic Serial Port Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaudR;
        private System.Windows.Forms.ComboBox comboBoxDataB;
        private System.Windows.Forms.ComboBox comboBoxStopB;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort myserial;
        private System.Windows.Forms.TextBox rtbEkran;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Button Openport_Click;
        private System.Windows.Forms.Button closeport_Click;
        private System.Windows.Forms.Button buttonSend_Click_Click;
        private System.Windows.Forms.Button clear_Click;
    }
}

