namespace BankStatementParser.UI
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            Open = new Button();
            SaveToXML = new Button();
            SaveToBankAccountHistory = new Button();
            Print = new Button();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(24, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 71);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "119911020214869800000000";
            // 
            // Open
            // 
            Open.Location = new Point(24, 115);
            Open.Name = "Open";
            Open.Size = new Size(147, 56);
            Open.TabIndex = 1;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // SaveToXML
            // 
            SaveToXML.Location = new Point(24, 190);
            SaveToXML.Name = "SaveToXML";
            SaveToXML.Size = new Size(147, 56);
            SaveToXML.TabIndex = 2;
            SaveToXML.Text = "Save to XML";
            SaveToXML.UseVisualStyleBackColor = true;
            SaveToXML.Click += SaveToXML_Click;
            // 
            // SaveToBankAccountHistory
            // 
            SaveToBankAccountHistory.Location = new Point(24, 263);
            SaveToBankAccountHistory.Name = "SaveToBankAccountHistory";
            SaveToBankAccountHistory.Size = new Size(147, 56);
            SaveToBankAccountHistory.TabIndex = 3;
            SaveToBankAccountHistory.Text = "Save to Szlat";
            SaveToBankAccountHistory.UseVisualStyleBackColor = true;
            SaveToBankAccountHistory.Click += SaveToBankAccountHistory_Click;
            // 
            // Print
            // 
            Print.Location = new Point(24, 340);
            Print.Name = "Print";
            Print.Size = new Size(147, 56);
            Print.TabIndex = 4;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(200, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 74);
            panel2.TabIndex = 5;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(24, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(191, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "CAM kivonatból képzett osztály";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(193, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "XSD struktúrából képzett osztály";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(438, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(545, 199);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 46);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 7;
            label1.Text = "Beolvasott tételszám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(737, 46);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 8;
            label2.Text = "0";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 407);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Controls.Add(Print);
            Controls.Add(SaveToBankAccountHistory);
            Controls.Add(SaveToXML);
            Controls.Add(Open);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BankStatementParser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button Open;
        private Button SaveToXML;
        private Button SaveToBankAccountHistory;
        private Button Print;
        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}