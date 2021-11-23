using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSubnetCalculator {

  public partial class calculateForm : Form {

    public String oktettBinarisan(int oktett) {
      String binaris = "";
      String szamBinarisas = Convert.ToString(oktett, 2);
      if (szamBinarisas.Length < 8) {
        int n = 8-szamBinarisas.Length;
        for (int i = 0; i < n; i++) {
          binaris += "0";
        }
      }
      binaris += szamBinarisas;
      return binaris;
    }

    public int[] binarisSzamokkal(String binarisCim) {
      int[] cim = new int[4];
      String[] seged = binarisCim.Split('.');
      for (int i = 0; i < cim.Length; i++) {
        cim[i] = Convert.ToInt32(seged[i], 2);
      }
      return cim;
    }

    private void calculate() {
      // Címosztály meghatározása
      int oktettIP1 = int.Parse(oktett1Txt.Text);
      if (oktettIP1 >= 1 && oktettIP1 <= 127) cimosztalyLabel.Text = "A osztály";
      if (oktettIP1 >= 128 && oktettIP1 <= 192) cimosztalyLabel.Text = "B osztály";
      if (oktettIP1 >= 192 && oktettIP1 <= 223) cimosztalyLabel.Text = "C osztály";
      if (oktettIP1 >= 224 && oktettIP1 <= 293) cimosztalyLabel.Text = "D osztály";
      if (oktettIP1 >= 240 && oktettIP1 <= 255) cimosztalyLabel.Text = "E osztály";

      // Bináris IP cím
      String binarisIP = "";
      int oktettIP2 = int.Parse(oktett2Txt.Text);
      int oktettIP3 = int.Parse(oktett3Txt.Text);
      int oktettIP4 = int.Parse(oktett4Txt.Text);
      String oktettIP1_bin = oktettBinarisan(oktettIP1);
      String oktettIP2_bin = oktettBinarisan(oktettIP2);
      String oktettIP3_bin = oktettBinarisan(oktettIP3);
      String oktettIP4_bin = oktettBinarisan(oktettIP4);
      binarisIP = oktettIP1_bin+"."+oktettIP2_bin+"."+oktettIP3_bin+"."+oktettIP4_bin;
      binarisIPLabel.Text =  binarisIP;

      // Alhálózati maszk meghatározása
      int cidr = int.Parse(cidrComboBox.SelectedItem.ToString());
      String maszk = "";
      switch (cidr) {
        case 1: maszk = "128.0.0.0"; break;
        case 2: maszk = "192.0.0.0"; break;
        case 3: maszk = "224.0.0.0"; break;
        case 4: maszk = "240.0.0.0"; break;
        case 5: maszk = "248.0.0.0"; break;
        case 6: maszk = "252.0.0.0"; break;
        case 7: maszk = "254.0.0.0"; break;
        case 8: maszk = "255.0.0.0"; break;
        case 9: maszk = "255.128.0.0"; break;
        case 10: maszk = "255.192.0.0"; break;
        case 11: maszk = "255.224.0.0"; break;
        case 12: maszk = "255.240.0.0"; break;
        case 13: maszk = "255.248.0.0"; break;
        case 14: maszk = "255.252.0.0"; break;
        case 15: maszk = "255.254.0.0"; break;
        case 16: maszk = "255.255.0.0"; break;
        case 17: maszk = "255.255.128.0"; break;
        case 18: maszk = "255.255.192.0"; break;
        case 19: maszk = "255.255.224.0"; break;
        case 20: maszk = "255.255.240.0"; break;
        case 21: maszk = "255.255.248.0"; break;
        case 22: maszk = "255.255.252.0"; break;
        case 23: maszk = "255.255.254.0"; break;
        case 24: maszk = "255.255.255.0"; break;
        case 25: maszk = "255.255.255.128"; break;
        case 26: maszk = "255.255.255.192"; break;
        case 27: maszk = "255.255.255.224"; break;
        case 28: maszk = "255.255.255.240"; break;
        case 29: maszk = "255.255.255.248"; break;
        case 30: maszk = "255.255.255.252"; break;
        case 31: maszk = "255.255.255.254"; break;
        case 32: maszk = "255.255.255.255"; break;
      }
      maszkLabel.Text = maszk;

      // Bináris alhálózati maszk
      String binarisMaszk = "";
      String[] maszk_darabolt = maszk.Split('.');
      int[] maszk_oktettek = new int[4];
      maszk_oktettek[0] = int.Parse(maszk_darabolt[0]);
      maszk_oktettek[1] = int.Parse(maszk_darabolt[1]);
      maszk_oktettek[2] = int.Parse(maszk_darabolt[2]);
      maszk_oktettek[3] = int.Parse(maszk_darabolt[3]);

      String oktettMaszk1_bin = oktettBinarisan(maszk_oktettek[0]);
      String oktettMaszk2_bin = oktettBinarisan(maszk_oktettek[1]);
      String oktettMaszk3_bin = oktettBinarisan(maszk_oktettek[2]);
      String oktettMaszk4_bin = oktettBinarisan(maszk_oktettek[3]);
      binarisMaszk = oktettMaszk1_bin+"."+oktettMaszk2_bin+"."+oktettMaszk3_bin+"."+oktettMaszk4_bin;
      binarisMaszkLabel.Text = binarisMaszk;

      // Hálózati cím meghatározása
      String halozatiCim = "";
      for (int i = 0; i < binarisIP.Length; i++) {
        if (binarisIP[i] == '.') {
          halozatiCim += '.';
        } else {
          int a = (int)Char.GetNumericValue(binarisIP[i]);
          int b = (int)Char.GetNumericValue(binarisMaszk[i]);
          int and = a&b;
          halozatiCim += and;
        }
      }
      int[] halCim = binarisSzamokkal(halozatiCim);
      halozatiCimLabel.Text = halCim[0]+"."+halCim[1]+"."+halCim[2]+"."+halCim[3];

      // Broadcast cím meghatározása
      String broadcast = "";
      String kiegeszitoMaszk = binarisMaszk;
      kiegeszitoMaszk = kiegeszitoMaszk.Replace('0', 'a');
      kiegeszitoMaszk = kiegeszitoMaszk.Replace('1', '0');
      kiegeszitoMaszk = kiegeszitoMaszk.Replace('a', '1');
      for (int i = 0; i < halozatiCim.Length; i++) {
        if (halozatiCim[i] == '.') {
          broadcast += '.';
        } else {
          int a = (int)Char.GetNumericValue(halozatiCim[i]);
          int b = (int)Char.GetNumericValue(kiegeszitoMaszk[i]);
          int and = a|b;
          broadcast += and;
        }
      }
      int[] broadC = binarisSzamokkal(broadcast);
      broadcastLabel.Text = broadC[0]+"."+broadC[1]+"."+broadC[2]+"."+broadC[3];

      // A hálózat terjedelmének meghatározása
      terjedelemLabel.Text = halCim[0]+"."+halCim[1]+"."+halCim[2]+"."+(halCim[3]+1)+
        " ― - "+broadC[0]+"."+broadC[1]+"."+broadC[2]+"."+(broadC[3]-1);

      // Érvényes IP címek számának meghatározása
      int ipDb = 10;
    }

    public calculateForm() {
      InitializeComponent();
    }

    private void oktett1Txt_TextChanged(object sender, EventArgs e) {
      try {
        int oktett1 = int.Parse(oktett1Txt.Text);
        if ((int) oktett1 < 0 || (int) oktett1 > 255) {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett1Txt.Text = "";
        }

        if (oktett1Txt.Text.Length == 3) {
          oktett2Txt.Focus();
        }
      } catch {
        if (oktett1Txt.Text != "") {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett1Txt.Text = "";
        }
      }
    }

    private void oktett2Txt_TextChanged(object sender, EventArgs e) {
      try {
        int oktett2 = int.Parse(oktett2Txt.Text);
        if ((int) oktett2 < 0 || (int) oktett2 > 255) {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett2Txt.Text = "";
        }

        if (oktett2Txt.Text.Length == 3) {
          oktett3Txt.Focus();
        }
      } catch {
        if (oktett2Txt.Text != "") {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett2Txt.Text = "";
        }
      }
    }

    private void oktett3Txt_TextChanged(object sender, EventArgs e) {
      try {
        int oktett3 = int.Parse(oktett3Txt.Text);
        if ((int) oktett3 < 0 || (int) oktett3 > 255) {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett3Txt.Text = "";
        }

        if (oktett3Txt.Text.Length == 3) {
          oktett4Txt.Focus();
        }
      } catch {
        if (oktett3Txt.Text != "") {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett3Txt.Text = "";
        }
      }
    }

    private void oktett4Txt_TextChanged(object sender, EventArgs e) {
      try {
        int oktett4 = int.Parse(oktett4Txt.Text);
        if ((int) oktett4 < 0 || (int) oktett4 > 255) {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett4Txt.Text = "";
        }

        if (oktett4Txt.Text.Length == 3) {
          cidrComboBox.Focus();
        }
      } catch {
        if (oktett4Txt.Text != "") {
          MessageBox.Show("0 és 255 közötti egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          oktett4Txt.Text = "";
        }
      }
    }

    private void calculateBtn_Click(object sender, EventArgs e) {
      if (oktett1Txt.Text != "" && oktett2Txt.Text != "" && oktett3Txt.Text != "" && oktett4Txt.Text != "" && cidrComboBox.Text != "") {
        calculate();
      } else {
        MessageBox.Show("Minden mező kitöltése, valamint CIDR érték kiválasztása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
