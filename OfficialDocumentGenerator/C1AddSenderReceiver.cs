using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficialDocumentGenerator
{
    public partial class C1AddSenderReceiver : Form
    {
        public C1AddSenderReceiver()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Check User Now Add is Sender or Receiver.
            if (radioButton1.Checked) DetailType.CrossFrom_Var1 = "Sender";
            if (radioButton2.Checked) DetailType.CrossFrom_Var1 = "Receiver";

            DetailType.CrossFrom_Var2 = textBox1.Text;
            DetailType.CrossFrom_Var3 = textBox2.Text;
            this.Close();
        }

        private void AddSenderReceiver_Load(object sender, EventArgs e)
        {
            if (DetailType.CrossFrom_Bool1 == true) radioButton1.Enabled = false; else radioButton1.Enabled = true;
            if (DetailType.CrossFrom_Bool2 == true) radioButton2.Enabled = false; else radioButton2.Enabled = true;
        }
    }
}