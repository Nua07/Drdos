namespace Drdos
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.DNS_TabPage = new MetroFramework.Controls.MetroTabPage();
            this.DNS_Stop_textbox = new MetroFramework.Controls.MetroButton();
            this.DNS_Start_textbox = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.DNS_Thread_textbox = new MetroFramework.Controls.MetroTextBox();
            this.DNS_PORT_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DNS_IP_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NTP_TabPage = new MetroFramework.Controls.MetroTabPage();
            this.NTP_Stop_textbox = new MetroFramework.Controls.MetroButton();
            this.NTP_Start_textbox = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.NTP_Thread_textbox = new MetroFramework.Controls.MetroTextBox();
            this.NTP_PORT_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.NTP_IP_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.None_TabPage = new MetroFramework.Controls.MetroTabPage();
            this.None_Stop_textbox = new MetroFramework.Controls.MetroButton();
            this.None_Start_textbox = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.None_Thread_textbox = new MetroFramework.Controls.MetroTextBox();
            this.None_PORT_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.None_IP_textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.DNS_TabPage.SuspendLayout();
            this.NTP_TabPage.SuspendLayout();
            this.None_TabPage.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.NTP_TabPage);
            this.metroTabControl1.Controls.Add(this.DNS_TabPage);
            this.metroTabControl1.Controls.Add(this.None_TabPage);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(19, 93);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(600, 268);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // DNS_TabPage
            // 
            this.DNS_TabPage.Controls.Add(this.metroLabel10);
            this.DNS_TabPage.Controls.Add(this.metroTextBox1);
            this.DNS_TabPage.Controls.Add(this.DNS_Stop_textbox);
            this.DNS_TabPage.Controls.Add(this.DNS_Start_textbox);
            this.DNS_TabPage.Controls.Add(this.metroLabel3);
            this.DNS_TabPage.Controls.Add(this.DNS_Thread_textbox);
            this.DNS_TabPage.Controls.Add(this.DNS_PORT_textbox);
            this.DNS_TabPage.Controls.Add(this.metroLabel2);
            this.DNS_TabPage.Controls.Add(this.DNS_IP_textbox);
            this.DNS_TabPage.Controls.Add(this.metroLabel1);
            this.DNS_TabPage.HorizontalScrollbarBarColor = true;
            this.DNS_TabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.DNS_TabPage.HorizontalScrollbarSize = 10;
            this.DNS_TabPage.Location = new System.Drawing.Point(4, 38);
            this.DNS_TabPage.Name = "DNS_TabPage";
            this.DNS_TabPage.Size = new System.Drawing.Size(592, 226);
            this.DNS_TabPage.TabIndex = 0;
            this.DNS_TabPage.Text = "DNS";
            this.DNS_TabPage.VerticalScrollbarBarColor = true;
            this.DNS_TabPage.VerticalScrollbarHighlightOnWheel = false;
            this.DNS_TabPage.VerticalScrollbarSize = 10;
            // 
            // DNS_Stop_textbox
            // 
            this.DNS_Stop_textbox.Location = new System.Drawing.Point(403, 144);
            this.DNS_Stop_textbox.Name = "DNS_Stop_textbox";
            this.DNS_Stop_textbox.Size = new System.Drawing.Size(186, 59);
            this.DNS_Stop_textbox.TabIndex = 8;
            this.DNS_Stop_textbox.Text = "정지";
            this.DNS_Stop_textbox.UseSelectable = true;
            this.DNS_Stop_textbox.Click += new System.EventHandler(this.DNS_Stop_textbox_Click);
            // 
            // DNS_Start_textbox
            // 
            this.DNS_Start_textbox.Location = new System.Drawing.Point(403, 47);
            this.DNS_Start_textbox.Name = "DNS_Start_textbox";
            this.DNS_Start_textbox.Size = new System.Drawing.Size(186, 59);
            this.DNS_Start_textbox.TabIndex = 8;
            this.DNS_Start_textbox.Text = "시작";
            this.DNS_Start_textbox.UseSelectable = true;
            this.DNS_Start_textbox.Click += new System.EventHandler(this.DNS_Start_textbox_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Thread";
            // 
            // DNS_Thread_textbox
            // 
            // 
            // 
            // 
            this.DNS_Thread_textbox.CustomButton.Image = null;
            this.DNS_Thread_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.DNS_Thread_textbox.CustomButton.Name = "";
            this.DNS_Thread_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DNS_Thread_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DNS_Thread_textbox.CustomButton.TabIndex = 1;
            this.DNS_Thread_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DNS_Thread_textbox.CustomButton.UseSelectable = true;
            this.DNS_Thread_textbox.CustomButton.Visible = false;
            this.DNS_Thread_textbox.Lines = new string[0];
            this.DNS_Thread_textbox.Location = new System.Drawing.Point(4, 193);
            this.DNS_Thread_textbox.MaxLength = 32767;
            this.DNS_Thread_textbox.Name = "DNS_Thread_textbox";
            this.DNS_Thread_textbox.PasswordChar = '\0';
            this.DNS_Thread_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DNS_Thread_textbox.SelectedText = "";
            this.DNS_Thread_textbox.SelectionLength = 0;
            this.DNS_Thread_textbox.SelectionStart = 0;
            this.DNS_Thread_textbox.ShortcutsEnabled = true;
            this.DNS_Thread_textbox.Size = new System.Drawing.Size(340, 23);
            this.DNS_Thread_textbox.TabIndex = 6;
            this.DNS_Thread_textbox.UseSelectable = true;
            this.DNS_Thread_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DNS_Thread_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DNS_PORT_textbox
            // 
            // 
            // 
            // 
            this.DNS_PORT_textbox.CustomButton.Image = null;
            this.DNS_PORT_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.DNS_PORT_textbox.CustomButton.Name = "";
            this.DNS_PORT_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DNS_PORT_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DNS_PORT_textbox.CustomButton.TabIndex = 1;
            this.DNS_PORT_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DNS_PORT_textbox.CustomButton.UseSelectable = true;
            this.DNS_PORT_textbox.CustomButton.Visible = false;
            this.DNS_PORT_textbox.Lines = new string[0];
            this.DNS_PORT_textbox.Location = new System.Drawing.Point(4, 90);
            this.DNS_PORT_textbox.MaxLength = 32767;
            this.DNS_PORT_textbox.Name = "DNS_PORT_textbox";
            this.DNS_PORT_textbox.PasswordChar = '\0';
            this.DNS_PORT_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DNS_PORT_textbox.SelectedText = "";
            this.DNS_PORT_textbox.SelectionLength = 0;
            this.DNS_PORT_textbox.SelectionStart = 0;
            this.DNS_PORT_textbox.ShortcutsEnabled = true;
            this.DNS_PORT_textbox.Size = new System.Drawing.Size(340, 23);
            this.DNS_PORT_textbox.TabIndex = 5;
            this.DNS_PORT_textbox.UseSelectable = true;
            this.DNS_PORT_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DNS_PORT_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "PORT";
            // 
            // DNS_IP_textbox
            // 
            // 
            // 
            // 
            this.DNS_IP_textbox.CustomButton.Image = null;
            this.DNS_IP_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.DNS_IP_textbox.CustomButton.Name = "";
            this.DNS_IP_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DNS_IP_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DNS_IP_textbox.CustomButton.TabIndex = 1;
            this.DNS_IP_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DNS_IP_textbox.CustomButton.UseSelectable = true;
            this.DNS_IP_textbox.CustomButton.Visible = false;
            this.DNS_IP_textbox.Lines = new string[0];
            this.DNS_IP_textbox.Location = new System.Drawing.Point(4, 37);
            this.DNS_IP_textbox.MaxLength = 32767;
            this.DNS_IP_textbox.Name = "DNS_IP_textbox";
            this.DNS_IP_textbox.PasswordChar = '\0';
            this.DNS_IP_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DNS_IP_textbox.SelectedText = "";
            this.DNS_IP_textbox.SelectionLength = 0;
            this.DNS_IP_textbox.SelectionStart = 0;
            this.DNS_IP_textbox.ShortcutsEnabled = true;
            this.DNS_IP_textbox.Size = new System.Drawing.Size(340, 23);
            this.DNS_IP_textbox.TabIndex = 3;
            this.DNS_IP_textbox.UseSelectable = true;
            this.DNS_IP_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DNS_IP_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "IP";
            // 
            // NTP_TabPage
            // 
            this.NTP_TabPage.Controls.Add(this.NTP_Stop_textbox);
            this.NTP_TabPage.Controls.Add(this.NTP_Start_textbox);
            this.NTP_TabPage.Controls.Add(this.metroLabel4);
            this.NTP_TabPage.Controls.Add(this.NTP_Thread_textbox);
            this.NTP_TabPage.Controls.Add(this.NTP_PORT_textbox);
            this.NTP_TabPage.Controls.Add(this.metroLabel5);
            this.NTP_TabPage.Controls.Add(this.NTP_IP_textbox);
            this.NTP_TabPage.Controls.Add(this.metroLabel6);
            this.NTP_TabPage.HorizontalScrollbarBarColor = true;
            this.NTP_TabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.NTP_TabPage.HorizontalScrollbarSize = 10;
            this.NTP_TabPage.Location = new System.Drawing.Point(4, 38);
            this.NTP_TabPage.Name = "NTP_TabPage";
            this.NTP_TabPage.Size = new System.Drawing.Size(592, 226);
            this.NTP_TabPage.TabIndex = 1;
            this.NTP_TabPage.Text = "NTP";
            this.NTP_TabPage.VerticalScrollbarBarColor = true;
            this.NTP_TabPage.VerticalScrollbarHighlightOnWheel = false;
            this.NTP_TabPage.VerticalScrollbarSize = 10;
            // 
            // NTP_Stop_textbox
            // 
            this.NTP_Stop_textbox.Location = new System.Drawing.Point(403, 144);
            this.NTP_Stop_textbox.Name = "NTP_Stop_textbox";
            this.NTP_Stop_textbox.Size = new System.Drawing.Size(186, 59);
            this.NTP_Stop_textbox.TabIndex = 15;
            this.NTP_Stop_textbox.Text = "정지";
            this.NTP_Stop_textbox.UseSelectable = true;
            this.NTP_Stop_textbox.Click += new System.EventHandler(this.NTP_Stop_textbox_Click);
            // 
            // NTP_Start_textbox
            // 
            this.NTP_Start_textbox.Location = new System.Drawing.Point(403, 47);
            this.NTP_Start_textbox.Name = "NTP_Start_textbox";
            this.NTP_Start_textbox.Size = new System.Drawing.Size(186, 59);
            this.NTP_Start_textbox.TabIndex = 16;
            this.NTP_Start_textbox.Text = "시작";
            this.NTP_Start_textbox.UseSelectable = true;
            this.NTP_Start_textbox.Click += new System.EventHandler(this.NTP_Start_textbox_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Thread";
            // 
            // NTP_Thread_textbox
            // 
            // 
            // 
            // 
            this.NTP_Thread_textbox.CustomButton.Image = null;
            this.NTP_Thread_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.NTP_Thread_textbox.CustomButton.Name = "";
            this.NTP_Thread_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NTP_Thread_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NTP_Thread_textbox.CustomButton.TabIndex = 1;
            this.NTP_Thread_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NTP_Thread_textbox.CustomButton.UseSelectable = true;
            this.NTP_Thread_textbox.CustomButton.Visible = false;
            this.NTP_Thread_textbox.Lines = new string[0];
            this.NTP_Thread_textbox.Location = new System.Drawing.Point(4, 180);
            this.NTP_Thread_textbox.MaxLength = 32767;
            this.NTP_Thread_textbox.Name = "NTP_Thread_textbox";
            this.NTP_Thread_textbox.PasswordChar = '\0';
            this.NTP_Thread_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NTP_Thread_textbox.SelectedText = "";
            this.NTP_Thread_textbox.SelectionLength = 0;
            this.NTP_Thread_textbox.SelectionStart = 0;
            this.NTP_Thread_textbox.ShortcutsEnabled = true;
            this.NTP_Thread_textbox.Size = new System.Drawing.Size(340, 23);
            this.NTP_Thread_textbox.TabIndex = 13;
            this.NTP_Thread_textbox.UseSelectable = true;
            this.NTP_Thread_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NTP_Thread_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NTP_PORT_textbox
            // 
            // 
            // 
            // 
            this.NTP_PORT_textbox.CustomButton.Image = null;
            this.NTP_PORT_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.NTP_PORT_textbox.CustomButton.Name = "";
            this.NTP_PORT_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NTP_PORT_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NTP_PORT_textbox.CustomButton.TabIndex = 1;
            this.NTP_PORT_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NTP_PORT_textbox.CustomButton.UseSelectable = true;
            this.NTP_PORT_textbox.CustomButton.Visible = false;
            this.NTP_PORT_textbox.Lines = new string[0];
            this.NTP_PORT_textbox.Location = new System.Drawing.Point(4, 110);
            this.NTP_PORT_textbox.MaxLength = 32767;
            this.NTP_PORT_textbox.Name = "NTP_PORT_textbox";
            this.NTP_PORT_textbox.PasswordChar = '\0';
            this.NTP_PORT_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NTP_PORT_textbox.SelectedText = "";
            this.NTP_PORT_textbox.SelectionLength = 0;
            this.NTP_PORT_textbox.SelectionStart = 0;
            this.NTP_PORT_textbox.ShortcutsEnabled = true;
            this.NTP_PORT_textbox.Size = new System.Drawing.Size(340, 23);
            this.NTP_PORT_textbox.TabIndex = 12;
            this.NTP_PORT_textbox.UseSelectable = true;
            this.NTP_PORT_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NTP_PORT_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 87);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "PORT";
            // 
            // NTP_IP_textbox
            // 
            // 
            // 
            // 
            this.NTP_IP_textbox.CustomButton.Image = null;
            this.NTP_IP_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.NTP_IP_textbox.CustomButton.Name = "";
            this.NTP_IP_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NTP_IP_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NTP_IP_textbox.CustomButton.TabIndex = 1;
            this.NTP_IP_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NTP_IP_textbox.CustomButton.UseSelectable = true;
            this.NTP_IP_textbox.CustomButton.Visible = false;
            this.NTP_IP_textbox.Lines = new string[0];
            this.NTP_IP_textbox.Location = new System.Drawing.Point(4, 47);
            this.NTP_IP_textbox.MaxLength = 32767;
            this.NTP_IP_textbox.Name = "NTP_IP_textbox";
            this.NTP_IP_textbox.PasswordChar = '\0';
            this.NTP_IP_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NTP_IP_textbox.SelectedText = "";
            this.NTP_IP_textbox.SelectionLength = 0;
            this.NTP_IP_textbox.SelectionStart = 0;
            this.NTP_IP_textbox.ShortcutsEnabled = true;
            this.NTP_IP_textbox.Size = new System.Drawing.Size(340, 23);
            this.NTP_IP_textbox.TabIndex = 10;
            this.NTP_IP_textbox.UseSelectable = true;
            this.NTP_IP_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NTP_IP_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 24);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(20, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "IP";
            // 
            // None_TabPage
            // 
            this.None_TabPage.Controls.Add(this.metroTextBox2);
            this.None_TabPage.Controls.Add(this.metroLabel11);
            this.None_TabPage.Controls.Add(this.None_Stop_textbox);
            this.None_TabPage.Controls.Add(this.None_Start_textbox);
            this.None_TabPage.Controls.Add(this.metroLabel7);
            this.None_TabPage.Controls.Add(this.None_Thread_textbox);
            this.None_TabPage.Controls.Add(this.None_PORT_textbox);
            this.None_TabPage.Controls.Add(this.metroLabel8);
            this.None_TabPage.Controls.Add(this.None_IP_textbox);
            this.None_TabPage.Controls.Add(this.metroLabel9);
            this.None_TabPage.HorizontalScrollbarBarColor = true;
            this.None_TabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.None_TabPage.HorizontalScrollbarSize = 10;
            this.None_TabPage.Location = new System.Drawing.Point(4, 38);
            this.None_TabPage.Name = "None_TabPage";
            this.None_TabPage.Size = new System.Drawing.Size(592, 226);
            this.None_TabPage.TabIndex = 2;
            this.None_TabPage.Text = "Udp(Hex)";
            this.None_TabPage.VerticalScrollbarBarColor = true;
            this.None_TabPage.VerticalScrollbarHighlightOnWheel = false;
            this.None_TabPage.VerticalScrollbarSize = 10;
            // 
            // None_Stop_textbox
            // 
            this.None_Stop_textbox.Location = new System.Drawing.Point(403, 144);
            this.None_Stop_textbox.Name = "None_Stop_textbox";
            this.None_Stop_textbox.Size = new System.Drawing.Size(186, 59);
            this.None_Stop_textbox.TabIndex = 15;
            this.None_Stop_textbox.Text = "정지";
            this.None_Stop_textbox.UseSelectable = true;
            this.None_Stop_textbox.Click += new System.EventHandler(this.None_Stop_textbox_Click);
            // 
            // None_Start_textbox
            // 
            this.None_Start_textbox.Location = new System.Drawing.Point(403, 47);
            this.None_Start_textbox.Name = "None_Start_textbox";
            this.None_Start_textbox.Size = new System.Drawing.Size(186, 59);
            this.None_Start_textbox.TabIndex = 16;
            this.None_Start_textbox.Text = "시작";
            this.None_Start_textbox.UseSelectable = true;
            this.None_Start_textbox.Click += new System.EventHandler(this.None_Start_textbox_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 168);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Thread";
            // 
            // None_Thread_textbox
            // 
            // 
            // 
            // 
            this.None_Thread_textbox.CustomButton.Image = null;
            this.None_Thread_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.None_Thread_textbox.CustomButton.Name = "";
            this.None_Thread_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.None_Thread_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.None_Thread_textbox.CustomButton.TabIndex = 1;
            this.None_Thread_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.None_Thread_textbox.CustomButton.UseSelectable = true;
            this.None_Thread_textbox.CustomButton.Visible = false;
            this.None_Thread_textbox.Lines = new string[0];
            this.None_Thread_textbox.Location = new System.Drawing.Point(4, 193);
            this.None_Thread_textbox.MaxLength = 32767;
            this.None_Thread_textbox.Name = "None_Thread_textbox";
            this.None_Thread_textbox.PasswordChar = '\0';
            this.None_Thread_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.None_Thread_textbox.SelectedText = "";
            this.None_Thread_textbox.SelectionLength = 0;
            this.None_Thread_textbox.SelectionStart = 0;
            this.None_Thread_textbox.ShortcutsEnabled = true;
            this.None_Thread_textbox.Size = new System.Drawing.Size(340, 23);
            this.None_Thread_textbox.TabIndex = 13;
            this.None_Thread_textbox.UseSelectable = true;
            this.None_Thread_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.None_Thread_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // None_PORT_textbox
            // 
            // 
            // 
            // 
            this.None_PORT_textbox.CustomButton.Image = null;
            this.None_PORT_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.None_PORT_textbox.CustomButton.Name = "";
            this.None_PORT_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.None_PORT_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.None_PORT_textbox.CustomButton.TabIndex = 1;
            this.None_PORT_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.None_PORT_textbox.CustomButton.UseSelectable = true;
            this.None_PORT_textbox.CustomButton.Visible = false;
            this.None_PORT_textbox.Lines = new string[0];
            this.None_PORT_textbox.Location = new System.Drawing.Point(4, 90);
            this.None_PORT_textbox.MaxLength = 32767;
            this.None_PORT_textbox.Name = "None_PORT_textbox";
            this.None_PORT_textbox.PasswordChar = '\0';
            this.None_PORT_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.None_PORT_textbox.SelectedText = "";
            this.None_PORT_textbox.SelectionLength = 0;
            this.None_PORT_textbox.SelectionStart = 0;
            this.None_PORT_textbox.ShortcutsEnabled = true;
            this.None_PORT_textbox.Size = new System.Drawing.Size(340, 23);
            this.None_PORT_textbox.TabIndex = 12;
            this.None_PORT_textbox.UseSelectable = true;
            this.None_PORT_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.None_PORT_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 67);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(43, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "PORT";
            // 
            // None_IP_textbox
            // 
            // 
            // 
            // 
            this.None_IP_textbox.CustomButton.Image = null;
            this.None_IP_textbox.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.None_IP_textbox.CustomButton.Name = "";
            this.None_IP_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.None_IP_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.None_IP_textbox.CustomButton.TabIndex = 1;
            this.None_IP_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.None_IP_textbox.CustomButton.UseSelectable = true;
            this.None_IP_textbox.CustomButton.Visible = false;
            this.None_IP_textbox.Lines = new string[0];
            this.None_IP_textbox.Location = new System.Drawing.Point(4, 37);
            this.None_IP_textbox.MaxLength = 32767;
            this.None_IP_textbox.Name = "None_IP_textbox";
            this.None_IP_textbox.PasswordChar = '\0';
            this.None_IP_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.None_IP_textbox.SelectedText = "";
            this.None_IP_textbox.SelectionLength = 0;
            this.None_IP_textbox.SelectionStart = 0;
            this.None_IP_textbox.ShortcutsEnabled = true;
            this.None_IP_textbox.Size = new System.Drawing.Size(340, 23);
            this.None_IP_textbox.TabIndex = 10;
            this.None_IP_textbox.UseSelectable = true;
            this.None_IP_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.None_IP_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(4, 14);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(20, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "IP";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(4, 140);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(340, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(4, 119);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(55, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Domain";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(4, 118);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(85, 19);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "Payload(Hex)";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(4, 140);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(340, 23);
            this.metroTextBox2.TabIndex = 18;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTextBox3);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroTextBox4);
            this.metroTabPage1.Controls.Add(this.metroTextBox5);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.metroTextBox6);
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(592, 226);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Tcp(Hex)";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(4, 140);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(340, 23);
            this.metroTextBox3.TabIndex = 28;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(4, 118);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(85, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Payload(Hex)";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(403, 144);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(186, 59);
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "정지";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(403, 47);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(186, 59);
            this.metroButton2.TabIndex = 26;
            this.metroButton2.Text = "시작";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(4, 168);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(50, 19);
            this.metroLabel13.TabIndex = 24;
            this.metroLabel13.Text = "Thread";
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(4, 193);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(340, 23);
            this.metroTextBox4.TabIndex = 23;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(4, 90);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(340, 23);
            this.metroTextBox5.TabIndex = 22;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(4, 67);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(43, 19);
            this.metroLabel14.TabIndex = 21;
            this.metroLabel14.Text = "PORT";
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(4, 37);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(340, 23);
            this.metroTextBox6.TabIndex = 20;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(4, 14);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(20, 19);
            this.metroLabel15.TabIndex = 19;
            this.metroLabel15.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(646, 374);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Drdos";
            this.metroTabControl1.ResumeLayout(false);
            this.DNS_TabPage.ResumeLayout(false);
            this.DNS_TabPage.PerformLayout();
            this.NTP_TabPage.ResumeLayout(false);
            this.NTP_TabPage.PerformLayout();
            this.None_TabPage.ResumeLayout(false);
            this.None_TabPage.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage DNS_TabPage;
        private MetroFramework.Controls.MetroTabPage NTP_TabPage;
        private MetroFramework.Controls.MetroTabPage None_TabPage;
        private MetroFramework.Controls.MetroButton DNS_Stop_textbox;
        private MetroFramework.Controls.MetroButton DNS_Start_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox DNS_Thread_textbox;
        private MetroFramework.Controls.MetroTextBox DNS_PORT_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox DNS_IP_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton NTP_Stop_textbox;
        private MetroFramework.Controls.MetroButton NTP_Start_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox NTP_Thread_textbox;
        private MetroFramework.Controls.MetroTextBox NTP_PORT_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox NTP_IP_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton None_Stop_textbox;
        private MetroFramework.Controls.MetroButton None_Start_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox None_Thread_textbox;
        private MetroFramework.Controls.MetroTextBox None_PORT_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox None_IP_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel15;
    }
}

