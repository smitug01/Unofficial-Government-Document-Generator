namespace OfficialDocumentGenerator
{
    partial class DetailType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Type_C2_Choose = new System.Windows.Forms.RadioButton();
            this.Type_C1_Choose = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.continue_use = new System.Windows.Forms.Button();
            this.stop_use = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Type_C2_Choose);
            this.groupBox1.Controls.Add(this.Type_C1_Choose);
            this.groupBox1.Location = new System.Drawing.Point(41, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件類型選取";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Type_C2_Choose
            // 
            this.Type_C2_Choose.AutoSize = true;
            this.Type_C2_Choose.Enabled = false;
            this.Type_C2_Choose.Location = new System.Drawing.Point(29, 68);
            this.Type_C2_Choose.Name = "Type_C2_Choose";
            this.Type_C2_Choose.Size = new System.Drawing.Size(92, 19);
            this.Type_C2_Choose.TabIndex = 1;
            this.Type_C2_Choose.TabStop = true;
            this.Type_C2_Choose.Text = "[C-2] 訴願書";
            this.Type_C2_Choose.UseVisualStyleBackColor = true;
            // 
            // Type_C1_Choose
            // 
            this.Type_C1_Choose.AutoSize = true;
            this.Type_C1_Choose.Location = new System.Drawing.Point(29, 33);
            this.Type_C1_Choose.Name = "Type_C1_Choose";
            this.Type_C1_Choose.Size = new System.Drawing.Size(104, 19);
            this.Type_C1_Choose.TabIndex = 0;
            this.Type_C1_Choose.TabStop = true;
            this.Type_C1_Choose.Text = "[C-1] 存證信函";
            this.Type_C1_Choose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(295, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "函文者及受文者資料編輯";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "資料異動";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "資料新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(43, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 392);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件主文編(撰)寫";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(524, 364);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // continue_use
            // 
            this.continue_use.Location = new System.Drawing.Point(58, 575);
            this.continue_use.Name = "continue_use";
            this.continue_use.Size = new System.Drawing.Size(223, 47);
            this.continue_use.TabIndex = 3;
            this.continue_use.Text = "確定產生";
            this.continue_use.UseVisualStyleBackColor = true;
            this.continue_use.Click += new System.EventHandler(this.continue_use_Click);
            // 
            // stop_use
            // 
            this.stop_use.Location = new System.Drawing.Point(341, 575);
            this.stop_use.Name = "stop_use";
            this.stop_use.Size = new System.Drawing.Size(223, 47);
            this.stop_use.TabIndex = 4;
            this.stop_use.Text = "關閉程式";
            this.stop_use.UseVisualStyleBackColor = true;
            this.stop_use.Click += new System.EventHandler(this.stop_use_Click);
            // 
            // DetailType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 646);
            this.Controls.Add(this.stop_use);
            this.Controls.Add(this.continue_use);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailType";
            this.Text = "非官方公文書產生器 - 文件類型選取暨內容選填";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton Type_C2_Choose;
        private RadioButton Type_C1_Choose;
        private GroupBox groupBox3;
        private Button continue_use;
        private Button stop_use;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}