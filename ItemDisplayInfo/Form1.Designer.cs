namespace ItemDisplayInfo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.button_fill_default = new System.Windows.Forms.Button();
            this.textBox_mysql_charactersDB = new System.Windows.Forms.TextBox();
            this.label_mysql_worldDB = new System.Windows.Forms.Label();
            this.textbox_mysql_worldDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_mysql_authDB = new System.Windows.Forms.TextBox();
            this.label_mysql_password = new System.Windows.Forms.Label();
            this.label_mysql_username = new System.Windows.Forms.Label();
            this.label_mysql_port = new System.Windows.Forms.Label();
            this.label_mysql_hostname = new System.Windows.Forms.Label();
            this.textbox_mysql_pass = new System.Windows.Forms.TextBox();
            this.textbox_mysql_username = new System.Windows.Forms.TextBox();
            this.textbox_mysql_port = new System.Windows.Forms.TextBox();
            this.textbox_mysql_hostname = new System.Windows.Forms.TextBox();
            this.button_mysql_connect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(375, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(361, 262);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 262);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button_clearAll);
            this.tabPage1.Controls.Add(this.button_fill_default);
            this.tabPage1.Controls.Add(this.textBox_mysql_charactersDB);
            this.tabPage1.Controls.Add(this.label_mysql_worldDB);
            this.tabPage1.Controls.Add(this.textbox_mysql_worldDB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_mysql_authDB);
            this.tabPage1.Controls.Add(this.label_mysql_password);
            this.tabPage1.Controls.Add(this.label_mysql_username);
            this.tabPage1.Controls.Add(this.label_mysql_port);
            this.tabPage1.Controls.Add(this.label_mysql_hostname);
            this.tabPage1.Controls.Add(this.textbox_mysql_pass);
            this.tabPage1.Controls.Add(this.textbox_mysql_username);
            this.tabPage1.Controls.Add(this.textbox_mysql_port);
            this.tabPage1.Controls.Add(this.textbox_mysql_hostname);
            this.tabPage1.Controls.Add(this.button_mysql_connect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "                                       Enter MySQL Info                          " +
    "               ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(75, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Select Icons Folder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "characters DB:";
            // 
            // button_clearAll
            // 
            this.button_clearAll.BackColor = System.Drawing.Color.Silver;
            this.button_clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clearAll.Location = new System.Drawing.Point(273, 195);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(54, 23);
            this.button_clearAll.TabIndex = 14;
            this.button_clearAll.Text = "Clear All";
            this.button_clearAll.UseVisualStyleBackColor = false;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // button_fill_default
            // 
            this.button_fill_default.BackColor = System.Drawing.Color.Silver;
            this.button_fill_default.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fill_default.Location = new System.Drawing.Point(285, 8);
            this.button_fill_default.Name = "button_fill_default";
            this.button_fill_default.Size = new System.Drawing.Size(25, 185);
            this.button_fill_default.TabIndex = 13;
            this.button_fill_default.Text = "fill";
            this.button_fill_default.UseVisualStyleBackColor = false;
            this.button_fill_default.Click += new System.EventHandler(this.button_fill_default_Click);
            // 
            // textBox_mysql_charactersDB
            // 
            this.textBox_mysql_charactersDB.Location = new System.Drawing.Point(100, 143);
            this.textBox_mysql_charactersDB.Name = "textBox_mysql_charactersDB";
            this.textBox_mysql_charactersDB.Size = new System.Drawing.Size(179, 20);
            this.textBox_mysql_charactersDB.TabIndex = 17;
            this.textBox_mysql_charactersDB.Text = "characters";
            // 
            // label_mysql_worldDB
            // 
            this.label_mysql_worldDB.AutoSize = true;
            this.label_mysql_worldDB.Location = new System.Drawing.Point(15, 170);
            this.label_mysql_worldDB.Name = "label_mysql_worldDB";
            this.label_mysql_worldDB.Size = new System.Drawing.Size(84, 13);
            this.label_mysql_worldDB.TabIndex = 12;
            this.label_mysql_worldDB.Text = "world Database:";
            // 
            // textbox_mysql_worldDB
            // 
            this.textbox_mysql_worldDB.Location = new System.Drawing.Point(100, 169);
            this.textbox_mysql_worldDB.Name = "textbox_mysql_worldDB";
            this.textbox_mysql_worldDB.Size = new System.Drawing.Size(179, 20);
            this.textbox_mysql_worldDB.TabIndex = 11;
            this.textbox_mysql_worldDB.Text = "world";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "auth Database:";
            // 
            // textBox_mysql_authDB
            // 
            this.textBox_mysql_authDB.Location = new System.Drawing.Point(100, 117);
            this.textBox_mysql_authDB.Name = "textBox_mysql_authDB";
            this.textBox_mysql_authDB.Size = new System.Drawing.Size(179, 20);
            this.textBox_mysql_authDB.TabIndex = 15;
            this.textBox_mysql_authDB.Text = "auth";
            // 
            // label_mysql_password
            // 
            this.label_mysql_password.AutoSize = true;
            this.label_mysql_password.Location = new System.Drawing.Point(43, 91);
            this.label_mysql_password.Name = "label_mysql_password";
            this.label_mysql_password.Size = new System.Drawing.Size(54, 13);
            this.label_mysql_password.TabIndex = 9;
            this.label_mysql_password.Text = "Pasword: ";
            // 
            // label_mysql_username
            // 
            this.label_mysql_username.AutoSize = true;
            this.label_mysql_username.Location = new System.Drawing.Point(36, 65);
            this.label_mysql_username.Name = "label_mysql_username";
            this.label_mysql_username.Size = new System.Drawing.Size(58, 13);
            this.label_mysql_username.TabIndex = 8;
            this.label_mysql_username.Text = "Username:";
            // 
            // label_mysql_port
            // 
            this.label_mysql_port.AutoSize = true;
            this.label_mysql_port.Location = new System.Drawing.Point(65, 37);
            this.label_mysql_port.Name = "label_mysql_port";
            this.label_mysql_port.Size = new System.Drawing.Size(29, 13);
            this.label_mysql_port.TabIndex = 7;
            this.label_mysql_port.Text = "Port:";
            // 
            // label_mysql_hostname
            // 
            this.label_mysql_hostname.AutoSize = true;
            this.label_mysql_hostname.Location = new System.Drawing.Point(18, 11);
            this.label_mysql_hostname.Name = "label_mysql_hostname";
            this.label_mysql_hostname.Size = new System.Drawing.Size(76, 13);
            this.label_mysql_hostname.TabIndex = 6;
            this.label_mysql_hostname.Text = "Hostname /IP:";
            // 
            // textbox_mysql_pass
            // 
            this.textbox_mysql_pass.Location = new System.Drawing.Point(100, 88);
            this.textbox_mysql_pass.Name = "textbox_mysql_pass";
            this.textbox_mysql_pass.Size = new System.Drawing.Size(179, 20);
            this.textbox_mysql_pass.TabIndex = 4;
            // 
            // textbox_mysql_username
            // 
            this.textbox_mysql_username.Location = new System.Drawing.Point(100, 62);
            this.textbox_mysql_username.Name = "textbox_mysql_username";
            this.textbox_mysql_username.Size = new System.Drawing.Size(179, 20);
            this.textbox_mysql_username.TabIndex = 3;
            this.textbox_mysql_username.Text = "root";
            // 
            // textbox_mysql_port
            // 
            this.textbox_mysql_port.Location = new System.Drawing.Point(100, 34);
            this.textbox_mysql_port.Name = "textbox_mysql_port";
            this.textbox_mysql_port.Size = new System.Drawing.Size(179, 20);
            this.textbox_mysql_port.TabIndex = 2;
            this.textbox_mysql_port.Text = "3306";
            // 
            // textbox_mysql_hostname
            // 
            this.textbox_mysql_hostname.Location = new System.Drawing.Point(100, 8);
            this.textbox_mysql_hostname.Name = "textbox_mysql_hostname";
            this.textbox_mysql_hostname.Size = new System.Drawing.Size(179, 20);
            this.textbox_mysql_hostname.TabIndex = 1;
            this.textbox_mysql_hostname.Text = "127.0.0.1";
            // 
            // button_mysql_connect
            // 
            this.button_mysql_connect.BackColor = System.Drawing.Color.DimGray;
            this.button_mysql_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mysql_connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_mysql_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mysql_connect.ForeColor = System.Drawing.Color.White;
            this.button_mysql_connect.Location = new System.Drawing.Point(100, 195);
            this.button_mysql_connect.Name = "button_mysql_connect";
            this.button_mysql_connect.Size = new System.Drawing.Size(145, 35);
            this.button_mysql_connect.TabIndex = 0;
            this.button_mysql_connect.Text = "Connect";
            this.button_mysql_connect.UseVisualStyleBackColor = false;
            this.button_mysql_connect.Click += new System.EventHandler(this.button_mysql_connect_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "item_template";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(509, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ItemDisplayInfo";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(283, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "    Search by ID or displayid";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(328, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search by Name";
            this.label4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 21);
            this.textBox3.TabIndex = 21;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(915, 352);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "Ability_Ambush";
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(943, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(915, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(214, 20);
            this.textBox5.TabIndex = 24;
            this.textBox5.Visible = false;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(666, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "coded by \r\nmindsear";
            this.label7.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 20);
            this.textBox6.TabIndex = 27;
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(131, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Item Entry";
            this.toolTip1.SetToolTip(this.label8, "http://wotlk.openwow.com/item=");
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 264);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search from ItemDisplayInfo AND item_template";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_clearAll;
        private System.Windows.Forms.Button button_fill_default;
        internal System.Windows.Forms.TextBox textBox_mysql_charactersDB;
        private System.Windows.Forms.Label label_mysql_worldDB;
        internal System.Windows.Forms.TextBox textbox_mysql_worldDB;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBox_mysql_authDB;
        private System.Windows.Forms.Label label_mysql_password;
        private System.Windows.Forms.Label label_mysql_username;
        private System.Windows.Forms.Label label_mysql_port;
        private System.Windows.Forms.Label label_mysql_hostname;
        internal System.Windows.Forms.TextBox textbox_mysql_pass;
        internal System.Windows.Forms.TextBox textbox_mysql_username;
        internal System.Windows.Forms.TextBox textbox_mysql_port;
        internal System.Windows.Forms.TextBox textbox_mysql_hostname;
        private System.Windows.Forms.Button button_mysql_connect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

