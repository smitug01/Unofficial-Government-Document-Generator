using System;
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
    public partial class C1ModifySenderReceiver : Form
    {
        void ReloadList()
        {
            // If 
            if (DetailType.CrossFrom_Var5 != null || DetailType.CrossFrom_Var6 != null)
            {
                if (DetailType.CrossFrom_Var3 == null && DetailType.CrossFrom_Var4 == null)
                {
                    DetailType.CrossFrom_Var3 = DetailType.CrossFrom_Var5;
                    DetailType.CrossFrom_Var4 = DetailType.CrossFrom_Var6;

                    DetailType.CrossFrom_Var5 = null;
                    DetailType.CrossFrom_Var6 = null;
                }
            }
            
            listBox1.Items.Clear();
            if (DetailType.CrossFrom_Var1 != null) listBox1.Items.Add("類型: 發函者, 姓名: " + DetailType.CrossFrom_Var1 + ", 地址: " + DetailType.CrossFrom_Var2);
            if (DetailType.CrossFrom_Var3 != null) listBox1.Items.Add("類型: 收件者, 姓名: " + DetailType.CrossFrom_Var3 + ", 地址: " + DetailType.CrossFrom_Var4);
            if (DetailType.CrossFrom_Var5 != null) listBox1.Items.Add("類型: 副本收件者, 姓名: " + DetailType.CrossFrom_Var5 + ", 地址: " + DetailType.CrossFrom_Var6);

        }
        public C1ModifySenderReceiver()
        {
            InitializeComponent();
        }
        
        private void C1ModifySenderReceiver_Load(object sender, EventArgs e)
        {
            if (DetailType.CrossFrom_Var1 != null) listBox1.Items.Add("類型: 發函者, 姓名: " + DetailType.CrossFrom_Var1 + ", 地址: " + DetailType.CrossFrom_Var2);
            if (DetailType.CrossFrom_Var3 != null) listBox1.Items.Add("類型: 收件者, 姓名: " + DetailType.CrossFrom_Var3 + ", 地址: " + DetailType.CrossFrom_Var4);
            if (DetailType.CrossFrom_Var5 != null) listBox1.Items.Add("類型: 副本收件者, 姓名: " + DetailType.CrossFrom_Var5 + ", 地址: " + DetailType.CrossFrom_Var6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            if (listBox1.SelectedItems[0].ToString().Contains("發函者"))
            {
                DetailType.CrossFrom_Var1 = Interaction.InputBox("請輸入新的發函者姓名", "發函者姓名", null);
                DetailType.CrossFrom_Var2 = Interaction.InputBox("請輸入新的發函者地址", "發函者地址", null);

            }
            else if (listBox1.SelectedItems[0].ToString().Contains("收件者"))
            {
                DetailType.CrossFrom_Var3 = Interaction.InputBox("請輸入新的收件者姓名", "收件者姓名", null);
                DetailType.CrossFrom_Var4 = Interaction.InputBox("請輸入新的收件者地址", "收件者地址", null);
            }
            else if (listBox1.SelectedItems[0].ToString().Contains("副本收件者"))
            {
                DetailType.CrossFrom_Var5 = Interaction.InputBox("請輸入新的副本收件者姓名", "副本收件者姓名", null);
                DetailType.CrossFrom_Var6 = Interaction.InputBox("請輸入新的副本收件者地址", "副本收件者地址", null);
            }

            ReloadList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems[0].ToString().Contains("發函者"))
            {
                DetailType.CrossFrom_Var1 = null;
                DetailType.CrossFrom_Var2 = null;
                DetailType.SenderQuantiny -= 1;
            }
            else if (listBox1.SelectedItems[0].ToString().Contains("收件者"))
            {
                DetailType.CrossFrom_Var3 = null;
                DetailType.CrossFrom_Var4 = null;
                DetailType.ReceiverQuantiny -= 1;
            }
            else if (listBox1.SelectedItems[0].ToString().Contains("副本收件者"))
            {
                DetailType.CrossFrom_Var5 = null;
                DetailType.CrossFrom_Var6 = null;
                DetailType.ReceiverQuantiny -= 1;
            }
            listBox1.Items.Remove(listBox1.SelectedItems[0]);
            
            ReloadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
