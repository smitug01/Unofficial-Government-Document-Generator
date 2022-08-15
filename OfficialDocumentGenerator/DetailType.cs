using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace OfficialDocumentGenerator
{
    public partial class DetailType : Form
    {
        public DetailType()
        {
            InitializeComponent();
        }

        // Set Up Environment Variable
        public static int SenderQuantiny = 0;
        public static int ReceiverQuantiny = 0;

        public static string CrossFrom_Var1, CrossFrom_Var2, CrossFrom_Var3, CrossFrom_Var4, CrossFrom_Var5, CrossFrom_Var6;
        public static bool CrossFrom_Bool1, CrossFrom_Bool2;
        class LetterOfDespoit // Type = C-1, 存證信函
        {
            // Save Sender Detail to an array.
            public string[] SenderName = new string[1];
            public string[] SenderAddress = new string[1];

            // Save Receiver Detail to an array.
            public string[] ReceiverName = new string[2];
            public string[] ReceiverAddress = new string[2];

            public void SenderDetailsAdd(string TSenderName, string TSenderAddress, int ID)
            {
                // Add Sender Detail to an array.
                SenderName[ID] = TSenderName;
                SenderAddress[ID] = TSenderAddress;
            }
            public void ReceiverDetailsAdd(string TReceiverName, string TReceiverAddress, int ID)
            {
                // Add Receiver Detail to an array.
                ReceiverName[ID] = TReceiverName;
                ReceiverAddress[ID] = TReceiverAddress;
            }
            public void SenderDetailsMotify(string TSenderName, string TSenderAddress, int ID)
            {
                // Modify Sender Detail to an array.
                SenderName[ID] = TSenderName;
                SenderAddress[ID] = TSenderAddress;
            }
            public void ReceiverDetailsMotify(string TReceiverName, string TReceiverAddress, int ID)
            {
                // Modify Receiver Detail to an array.
                ReceiverName[ID] = TReceiverName;
                ReceiverAddress[ID] = TReceiverAddress;
            }
            public void SenderDetailsDelete(int ID)
            {
                // Delete Sender Detail to an array.
                SenderName[ID] = "";
                SenderAddress[ID] = "";
            }
            public void ReceiverDetailsDelete(int ID)
            {
                // Delete Receiver Detail to an array.
                ReceiverName[ID] = "";
                ReceiverAddress[ID] = "";
            }
            public string SenderDetailsList()
            {
                string text = "";

                for (int i = 0; i < SenderName.Length; i++)
                {
                    if (SenderAddress[i] != null)
                    {
                        text += ("Type: Sender" + ", UserID: " + i.ToString() + ", Name: " + SenderName[i] + ", Address: " + SenderAddress[i] + ". \n");
                    }
                }

                return text;
            }
            public string ReceiverDetailsList()
            {
                string text = "";

                for (int i = 0; i < ReceiverName.Length; i++)
                {
                    if (ReceiverAddress[i] != null)
                    {
                        text += ("Type: Receiver" + ", UserID: " + i.ToString() + ", Name: " + ReceiverName[i] + ", Address: " + ReceiverAddress[i] + ". \n");
                    }
                }

                return text;
            }
        }

        private LetterOfDespoit details_c1 = new LetterOfDespoit();

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void continue_use_Click(object sender, EventArgs e)
        {
            // Check User Choosed Documets Type.
            if (Type_C1_Choose.Checked) // Type C-1, 存證信函
            {
                string program_var = @"res\doc.txt "; // Set up program variable.

                if (details_c1.SenderName[0] != null) program_var += ("--senderName " + details_c1.SenderName[0] + " --senderAddr " + details_c1.SenderAddress[0]); // Create Main Sender Details.
                if (details_c1.ReceiverName[0] != null) program_var += (" --receiverName " + details_c1.ReceiverName[0] + " --receiverAddr " + details_c1.ReceiverAddress[0]); // Create Main Receiver Details.
                if (details_c1.ReceiverName[1] != null) program_var += (" --ccName " + details_c1.ReceiverName[1] + " --ccAddr " + details_c1.ReceiverAddress[1]); // Create Sub Receiver Details.


                try { File.Delete(@"res\doc.txt"); } catch { } // Delete doc.text if it exists.
                File.WriteAllTextAsync(@"res\doc.txt", richTextBox1.Text); // Write Text to a file.

                continue_use.Text = "產製中，請稍後...";

                string program_path = @"res\c1.exe"; // Set up program path.
                Process proc = new Process(); // Ceate a new process.
                proc.StartInfo.CreateNoWindow = true; // Create a new process without window.
                proc.StartInfo.FileName = program_path; proc.StartInfo.Arguments = program_var; // Set up program path and program variable.
                proc.Start(); proc.WaitForExit(); // Start program and wait for exit.

                SaveFileDialog saveFileDialog1 = new SaveFileDialog(); // Create a new save file dialog.
                saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"; saveFileDialog1.FilterIndex = 2; // Set up save file dialog. 
                saveFileDialog1.RestoreDirectory = true; // Restore directory.

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                { // If user give's directory is a valid directory.
                    string fileName = saveFileDialog1.FileName;
                    File.Copy("output.pdf", fileName, true);
                }
                else
                {
                    MessageBox.Show("Please choose a file name."); // If user give's directory is not a valid directory.
                }

                continue_use.Text = "確定產生";
            }

            if (Type_C2_Choose.Checked) // Type C-2, 訴願書
            {

            }

        }

        private void stop_use_Click(object sender, EventArgs e)
        {
            try { File.Delete(@"output.pdf"); } catch { }
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear Environment Variable
            CrossFrom_Var1 = null; CrossFrom_Var2 = null; CrossFrom_Var3 = null;

            if (Type_C1_Choose.Checked) // Type = C-1, 存證信函
            {
                if (details_c1.SenderName[0] != null) CrossFrom_Bool1 = true; else CrossFrom_Bool1 = false;
                if (details_c1.ReceiverName[1] != null) CrossFrom_Bool2 = true; else CrossFrom_Bool2 = false;

                var form = new C1AddSenderReceiver(); form.ShowDialog();

                if (CrossFrom_Var1 == "Sender")
                {
                    details_c1.SenderDetailsAdd(CrossFrom_Var2, CrossFrom_Var3, SenderQuantiny);
                    SenderQuantiny += 1;
                }

                if (CrossFrom_Var1 == "Receiver")
                {
                    details_c1.ReceiverDetailsAdd(CrossFrom_Var2, CrossFrom_Var3, ReceiverQuantiny);
                    ReceiverQuantiny += 1;
                }
            }

            if (Type_C2_Choose.Checked) // Type = C-2, 訴願書
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear Environment Variable
            CrossFrom_Var1 = null; CrossFrom_Var2 = null; CrossFrom_Var3 = null; CrossFrom_Var4 = null; CrossFrom_Var5 = null; CrossFrom_Var6 = null;

            if (Type_C1_Choose.Checked)
            {
                // Check if there is any sender or receiver, and keep the user in another env.
                if (details_c1.SenderName[0] != null)
                {
                    CrossFrom_Var1 = details_c1.SenderName[0];
                    CrossFrom_Var2 = details_c1.SenderAddress[0];
                }
                if (details_c1.ReceiverName[0] != null)
                {
                    CrossFrom_Var3 = details_c1.ReceiverName[0];
                    CrossFrom_Var4 = details_c1.ReceiverAddress[0];
                }
                if (details_c1.ReceiverName[1] != null)
                {
                    CrossFrom_Var5 = details_c1.ReceiverName[1];
                    CrossFrom_Var6 = details_c1.ReceiverAddress[1];
                }

                var form = new C1ModifySenderReceiver(); form.ShowDialog(); // Show C1ModifySenderReceiver Form.

                if (CrossFrom_Var1 != null)
                {
                    details_c1.SenderName[0] = CrossFrom_Var1;
                    details_c1.SenderAddress[0] = CrossFrom_Var2;
                }
                else
                {
                    details_c1.SenderName[0] = null;
                    details_c1.SenderAddress[0] = null;
                }

                if (CrossFrom_Var3 != null)
                {
                    details_c1.ReceiverName[0] = CrossFrom_Var3;
                    details_c1.ReceiverAddress[0] = CrossFrom_Var4;
                }
                else
                {
                    details_c1.ReceiverName[0] = null;
                    details_c1.ReceiverAddress[0] = null;
                }

                if (CrossFrom_Var5 != null)
                {
                    details_c1.ReceiverName[1] = CrossFrom_Var5;
                    details_c1.ReceiverAddress[1] = CrossFrom_Var6;
                }
                else
                {
                    details_c1.ReceiverName[1] = null;
                    details_c1.ReceiverAddress[1] = null;
                }
            }
        }
    }
}
