
namespace IPSubnetCalculator {
  partial class calculateForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculateForm));
      this.oktett1Txt = new System.Windows.Forms.TextBox();
      this.oktett2Txt = new System.Windows.Forms.TextBox();
      this.oktett3Txt = new System.Windows.Forms.TextBox();
      this.oktett4Txt = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.binarisIPLabel = new System.Windows.Forms.Label();
      this.calculateBtn = new System.Windows.Forms.Button();
      this.cidrComboBox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.maszkLabel = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.binarisMaszkLabel = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.cimosztalyLabel = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.halozatiCimLabel = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.broadcastLabel = new System.Windows.Forms.Label();
      this.ipCimtartomanyLabel = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.ipCimekDbLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // oktett1Txt
      // 
      this.oktett1Txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.oktett1Txt.Location = new System.Drawing.Point(50, 55);
      this.oktett1Txt.Multiline = true;
      this.oktett1Txt.Name = "oktett1Txt";
      this.oktett1Txt.Size = new System.Drawing.Size(100, 40);
      this.oktett1Txt.TabIndex = 0;
      this.oktett1Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.oktett1Txt.TextChanged += new System.EventHandler(this.oktett1Txt_TextChanged);
      // 
      // oktett2Txt
      // 
      this.oktett2Txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.oktett2Txt.Location = new System.Drawing.Point(200, 55);
      this.oktett2Txt.Multiline = true;
      this.oktett2Txt.Name = "oktett2Txt";
      this.oktett2Txt.Size = new System.Drawing.Size(100, 40);
      this.oktett2Txt.TabIndex = 1;
      this.oktett2Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.oktett2Txt.TextChanged += new System.EventHandler(this.oktett2Txt_TextChanged);
      // 
      // oktett3Txt
      // 
      this.oktett3Txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.oktett3Txt.Location = new System.Drawing.Point(350, 55);
      this.oktett3Txt.Multiline = true;
      this.oktett3Txt.Name = "oktett3Txt";
      this.oktett3Txt.Size = new System.Drawing.Size(100, 40);
      this.oktett3Txt.TabIndex = 2;
      this.oktett3Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.oktett3Txt.TextChanged += new System.EventHandler(this.oktett3Txt_TextChanged);
      // 
      // oktett4Txt
      // 
      this.oktett4Txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.oktett4Txt.Location = new System.Drawing.Point(500, 55);
      this.oktett4Txt.Multiline = true;
      this.oktett4Txt.Name = "oktett4Txt";
      this.oktett4Txt.Size = new System.Drawing.Size(100, 40);
      this.oktett4Txt.TabIndex = 3;
      this.oktett4Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.oktett4Txt.TextChanged += new System.EventHandler(this.oktett4Txt_TextChanged);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(646, 50);
      this.label1.TabIndex = 8;
      this.label1.Text = "Adja meg az IP címet:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(0, 190);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(225, 30);
      this.label2.TabIndex = 7;
      this.label2.Text = "Bináris IP cím:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // binarisIPLabel
      // 
      this.binarisIPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.binarisIPLabel.Location = new System.Drawing.Point(225, 190);
      this.binarisIPLabel.Name = "binarisIPLabel";
      this.binarisIPLabel.Size = new System.Drawing.Size(381, 30);
      this.binarisIPLabel.TabIndex = 6;
      this.binarisIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // calculateBtn
      // 
      this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.calculateBtn.Location = new System.Drawing.Point(350, 110);
      this.calculateBtn.Name = "calculateBtn";
      this.calculateBtn.Size = new System.Drawing.Size(100, 30);
      this.calculateBtn.TabIndex = 5;
      this.calculateBtn.Text = "Számol";
      this.calculateBtn.UseVisualStyleBackColor = true;
      this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
      // 
      // cidrComboBox
      // 
      this.cidrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cidrComboBox.FormattingEnabled = true;
      this.cidrComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
      this.cidrComboBox.Location = new System.Drawing.Point(231, 113);
      this.cidrComboBox.Name = "cidrComboBox";
      this.cidrComboBox.Size = new System.Drawing.Size(69, 28);
      this.cidrComboBox.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(0, 110);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(225, 30);
      this.label3.TabIndex = 9;
      this.label3.Text = "CIDR értéke:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(0, 230);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(225, 30);
      this.label4.TabIndex = 10;
      this.label4.Text = "Alhálózati maszk:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // maszkLabel
      // 
      this.maszkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.maszkLabel.Location = new System.Drawing.Point(225, 230);
      this.maszkLabel.Name = "maszkLabel";
      this.maszkLabel.Size = new System.Drawing.Size(381, 30);
      this.maszkLabel.TabIndex = 11;
      this.maszkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(0, 270);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(225, 30);
      this.label5.TabIndex = 12;
      this.label5.Text = "Bináris alhálózati maszk:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // binarisMaszkLabel
      // 
      this.binarisMaszkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.binarisMaszkLabel.Location = new System.Drawing.Point(225, 270);
      this.binarisMaszkLabel.Name = "binarisMaszkLabel";
      this.binarisMaszkLabel.Size = new System.Drawing.Size(381, 30);
      this.binarisMaszkLabel.TabIndex = 13;
      this.binarisMaszkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.Location = new System.Drawing.Point(0, 150);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(225, 30);
      this.label6.TabIndex = 14;
      this.label6.Text = "Címosztály:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cimosztalyLabel
      // 
      this.cimosztalyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cimosztalyLabel.Location = new System.Drawing.Point(225, 150);
      this.cimosztalyLabel.Name = "cimosztalyLabel";
      this.cimosztalyLabel.Size = new System.Drawing.Size(381, 30);
      this.cimosztalyLabel.TabIndex = 15;
      this.cimosztalyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label7
      // 
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label7.Location = new System.Drawing.Point(0, 147);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(646, 3);
      this.label7.TabIndex = 16;
      this.label7.Text = "label7";
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label8.Location = new System.Drawing.Point(0, 310);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(225, 30);
      this.label8.TabIndex = 17;
      this.label8.Text = "Hálózati cím:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // halozatiCimLabel
      // 
      this.halozatiCimLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.halozatiCimLabel.Location = new System.Drawing.Point(225, 310);
      this.halozatiCimLabel.Name = "halozatiCimLabel";
      this.halozatiCimLabel.Size = new System.Drawing.Size(381, 30);
      this.halozatiCimLabel.TabIndex = 18;
      this.halozatiCimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label9.Location = new System.Drawing.Point(0, 350);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(225, 30);
      this.label9.TabIndex = 19;
      this.label9.Text = "Broadcast cím:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // broadcastLabel
      // 
      this.broadcastLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.broadcastLabel.Location = new System.Drawing.Point(225, 350);
      this.broadcastLabel.Name = "broadcastLabel";
      this.broadcastLabel.Size = new System.Drawing.Size(381, 30);
      this.broadcastLabel.TabIndex = 20;
      this.broadcastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ipCimtartomanyLabel
      // 
      this.ipCimtartomanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ipCimtartomanyLabel.Location = new System.Drawing.Point(225, 390);
      this.ipCimtartomanyLabel.Name = "ipCimtartomanyLabel";
      this.ipCimtartomanyLabel.Size = new System.Drawing.Size(381, 30);
      this.ipCimtartomanyLabel.TabIndex = 21;
      this.ipCimtartomanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label11.Location = new System.Drawing.Point(0, 390);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(225, 30);
      this.label11.TabIndex = 22;
      this.label11.Text = "IP-címtartomány:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label10.Location = new System.Drawing.Point(0, 430);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(225, 30);
      this.label10.TabIndex = 23;
      this.label10.Text = "Érvényes IP címek:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ipCimekDbLabel
      // 
      this.ipCimekDbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ipCimekDbLabel.Location = new System.Drawing.Point(225, 430);
      this.ipCimekDbLabel.Name = "ipCimekDbLabel";
      this.ipCimekDbLabel.Size = new System.Drawing.Size(381, 30);
      this.ipCimekDbLabel.TabIndex = 24;
      this.ipCimekDbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // calculateForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(650, 478);
      this.Controls.Add(this.ipCimekDbLabel);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.ipCimtartomanyLabel);
      this.Controls.Add(this.broadcastLabel);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.halozatiCimLabel);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.cimosztalyLabel);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.binarisMaszkLabel);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.maszkLabel);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cidrComboBox);
      this.Controls.Add(this.calculateBtn);
      this.Controls.Add(this.binarisIPLabel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.oktett4Txt);
      this.Controls.Add(this.oktett3Txt);
      this.Controls.Add(this.oktett2Txt);
      this.Controls.Add(this.oktett1Txt);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "calculateForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "IP alhálózati maszk kalkulátor";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox oktett1Txt;
    private System.Windows.Forms.TextBox oktett2Txt;
    private System.Windows.Forms.TextBox oktett3Txt;
    private System.Windows.Forms.TextBox oktett4Txt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label binarisIPLabel;
    private System.Windows.Forms.Button calculateBtn;
    private System.Windows.Forms.ComboBox cidrComboBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label maszkLabel;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label binarisMaszkLabel;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label cimosztalyLabel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label halozatiCimLabel;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label broadcastLabel;
    private System.Windows.Forms.Label ipCimtartomanyLabel;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label ipCimekDbLabel;
  }
}

