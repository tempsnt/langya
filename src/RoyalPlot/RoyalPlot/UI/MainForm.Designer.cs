/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/4/21
 * 时间: 13:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox picBackground;
		private System.Windows.Forms.ListBox listAction;
		private System.Windows.Forms.ListBox listFollower;
		private System.Windows.Forms.ListBox listEvents;
		private System.Windows.Forms.ListBox listPlaces;
		private System.Windows.Forms.ListBox listMessage;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox speak;
		private System.Windows.Forms.PictureBox picleft;
		private System.Windows.Forms.PictureBox picright;
		private System.Windows.Forms.Panel panelAsk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox listBoxAsk;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("太后");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("皇后");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("贵妃");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("妃");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("嫔");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("冷宫");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("后宫系统", new System.Windows.Forms.TreeNode[] {
			treeNode1,
			treeNode2,
			treeNode3,
			treeNode4,
			treeNode5,
			treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("尚书");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("侍郎");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("侍郎");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("吏部", new System.Windows.Forms.TreeNode[] {
			treeNode8,
			treeNode9,
			treeNode10});
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("户部");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("兵部");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("礼部");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("刑部");
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("工部");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("丞相", new System.Windows.Forms.TreeNode[] {
			treeNode11,
			treeNode12,
			treeNode13,
			treeNode14,
			treeNode15,
			treeNode16});
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("文官系统", new System.Windows.Forms.TreeNode[] {
			treeNode17});
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("武将系统");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("情报系统");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("继承系统");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("宗族勋贵");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("总管大太监");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("秉笔");
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("司礼");
			System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("御马");
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("内监系统", new System.Windows.Forms.TreeNode[] {
			treeNode23,
			treeNode24,
			treeNode25,
			treeNode26});
			System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("皇帝", new System.Windows.Forms.TreeNode[] {
			treeNode7,
			treeNode18,
			treeNode19,
			treeNode20,
			treeNode21,
			treeNode22,
			treeNode27});
			System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("江湖");
			System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("佛");
			System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("道");
			System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("白莲");
			System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("宗教", new System.Windows.Forms.TreeNode[] {
			treeNode30,
			treeNode31,
			treeNode32});
			System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("东林");
			System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("岳麓");
			System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("文人", new System.Windows.Forms.TreeNode[] {
			treeNode34,
			treeNode35});
			System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("护卫");
			System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("情报");
			System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("红颜(指针)");
			System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("朋友(指针)");
			System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("军师", new System.Windows.Forms.TreeNode[] {
			treeNode37,
			treeNode38,
			treeNode39,
			treeNode40});
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.speak = new System.Windows.Forms.RichTextBox();
			this.panelAsk = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listBoxAsk = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.picleft = new System.Windows.Forms.PictureBox();
			this.picright = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listMessage = new System.Windows.Forms.ListBox();
			this.listPlaces = new System.Windows.Forms.ListBox();
			this.listEvents = new System.Windows.Forms.ListBox();
			this.listAction = new System.Windows.Forms.ListBox();
			this.listFollower = new System.Windows.Forms.ListBox();
			this.picBackground = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panelAsk.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picleft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picright)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1016, 573);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.speak);
			this.tabPage1.Controls.Add(this.panelAsk);
			this.tabPage1.Controls.Add(this.picleft);
			this.tabPage1.Controls.Add(this.picright);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.listMessage);
			this.tabPage1.Controls.Add(this.listPlaces);
			this.tabPage1.Controls.Add(this.listEvents);
			this.tabPage1.Controls.Add(this.listAction);
			this.tabPage1.Controls.Add(this.listFollower);
			this.tabPage1.Controls.Add(this.picBackground);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1008, 547);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// speak
			// 
			this.speak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.speak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.speak.Font = new System.Drawing.Font("方正兰亭超细黑简体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.speak.ForeColor = System.Drawing.SystemColors.Highlight;
			this.speak.Location = new System.Drawing.Point(297, 381);
			this.speak.Name = "speak";
			this.speak.ReadOnly = true;
			this.speak.Size = new System.Drawing.Size(438, 163);
			this.speak.TabIndex = 9;
			this.speak.Text = "";
			this.speak.Visible = false;
			this.speak.Click += new System.EventHandler(this.SpeakClick);
			// 
			// panelAsk
			// 
			this.panelAsk.BackColor = System.Drawing.SystemColors.Desktop;
			this.panelAsk.Controls.Add(this.panel2);
			this.panelAsk.Controls.Add(this.label1);
			this.panelAsk.ForeColor = System.Drawing.Color.Gold;
			this.panelAsk.Location = new System.Drawing.Point(234, 23);
			this.panelAsk.Name = "panelAsk";
			this.panelAsk.Size = new System.Drawing.Size(545, 361);
			this.panelAsk.TabIndex = 10;
			this.panelAsk.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.listBoxAsk);
			this.panel2.Location = new System.Drawing.Point(32, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(486, 289);
			this.panel2.TabIndex = 1;
			// 
			// listBoxAsk
			// 
			this.listBoxAsk.BackColor = System.Drawing.SystemColors.Desktop;
			this.listBoxAsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxAsk.Font = new System.Drawing.Font("方正兰亭超细黑简体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBoxAsk.ForeColor = System.Drawing.Color.Yellow;
			this.listBoxAsk.FormattingEnabled = true;
			this.listBoxAsk.ItemHeight = 32;
			this.listBoxAsk.Location = new System.Drawing.Point(3, 19);
			this.listBoxAsk.Name = "listBoxAsk";
			this.listBoxAsk.Size = new System.Drawing.Size(480, 256);
			this.listBoxAsk.TabIndex = 5;
			this.listBoxAsk.Click += new System.EventHandler(this.ListBoxAskClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(30, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(512, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "选项:";
			// 
			// picleft
			// 
			this.picleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picleft.Image = ((System.Drawing.Image)(resources.GetObject("picleft.Image")));
			this.picleft.Location = new System.Drawing.Point(68, 169);
			this.picleft.Name = "picleft";
			this.picleft.Size = new System.Drawing.Size(223, 378);
			this.picleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picleft.TabIndex = 8;
			this.picleft.TabStop = false;
			this.picleft.Visible = false;
			// 
			// picright
			// 
			this.picright.Location = new System.Drawing.Point(741, 186);
			this.picright.Name = "picright";
			this.picright.Size = new System.Drawing.Size(226, 353);
			this.picright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picright.TabIndex = 7;
			this.picright.TabStop = false;
			this.picright.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(937, 521);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "事件编辑器";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listMessage
			// 
			this.listMessage.FormattingEnabled = true;
			this.listMessage.ItemHeight = 12;
			this.listMessage.Location = new System.Drawing.Point(832, 7);
			this.listMessage.Name = "listMessage";
			this.listMessage.Size = new System.Drawing.Size(125, 208);
			this.listMessage.TabIndex = 5;
			this.listMessage.SelectedIndexChanged += new System.EventHandler(this.ListMessageSelectedIndexChanged);
			// 
			// listPlaces
			// 
			this.listPlaces.FormattingEnabled = true;
			this.listPlaces.ItemHeight = 12;
			this.listPlaces.Location = new System.Drawing.Point(90, 6);
			this.listPlaces.Name = "listPlaces";
			this.listPlaces.Size = new System.Drawing.Size(89, 208);
			this.listPlaces.TabIndex = 4;
			this.listPlaces.SelectedIndexChanged += new System.EventHandler(this.ListPlaceSelectedIndexChanged);
			// 
			// listEvents
			// 
			this.listEvents.FormattingEnabled = true;
			this.listEvents.ItemHeight = 12;
			this.listEvents.Location = new System.Drawing.Point(705, 6);
			this.listEvents.Name = "listEvents";
			this.listEvents.Size = new System.Drawing.Size(120, 208);
			this.listEvents.TabIndex = 3;
			this.listEvents.SelectedIndexChanged += new System.EventHandler(this.ListEventsSelectedIndexChanged);
			// 
			// listAction
			// 
			this.listAction.FormattingEnabled = true;
			this.listAction.ItemHeight = 12;
			this.listAction.Location = new System.Drawing.Point(621, 6);
			this.listAction.Name = "listAction";
			this.listAction.Size = new System.Drawing.Size(78, 208);
			this.listAction.TabIndex = 2;
			this.listAction.SelectedIndexChanged += new System.EventHandler(this.ListActionSelectedIndexChanged);
			// 
			// listFollower
			// 
			this.listFollower.FormattingEnabled = true;
			this.listFollower.ItemHeight = 12;
			this.listFollower.Location = new System.Drawing.Point(6, 3);
			this.listFollower.Name = "listFollower";
			this.listFollower.Size = new System.Drawing.Size(78, 208);
			this.listFollower.TabIndex = 1;
			this.listFollower.SelectedIndexChanged += new System.EventHandler(this.ListFollowerSelectedIndexChanged);
			// 
			// picBackground
			// 
			this.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
			this.picBackground.InitialImage = null;
			this.picBackground.Location = new System.Drawing.Point(3, 3);
			this.picBackground.Name = "picBackground";
			this.picBackground.Size = new System.Drawing.Size(1002, 541);
			this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBackground.TabIndex = 0;
			this.picBackground.TabStop = false;
			this.picBackground.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.treeView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1008, 547);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "人物关系编辑器";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node25";
			treeNode1.Tag = "111111";
			treeNode1.Text = "太后";
			treeNode1.ToolTipText = "22222";
			treeNode2.Name = "Node26";
			treeNode2.Text = "皇后";
			treeNode3.Name = "Node27";
			treeNode3.Text = "贵妃";
			treeNode4.Name = "Node28";
			treeNode4.Text = "妃";
			treeNode5.Name = "Node29";
			treeNode5.Text = "嫔";
			treeNode6.Name = "Node30";
			treeNode6.Text = "冷宫";
			treeNode7.Name = "Node1";
			treeNode7.Text = "后宫系统";
			treeNode8.Name = "Node21";
			treeNode8.Text = "尚书";
			treeNode9.Name = "Node22";
			treeNode9.Text = "侍郎";
			treeNode10.Name = "Node23";
			treeNode10.Text = "侍郎";
			treeNode11.Name = "Node14";
			treeNode11.Text = "吏部";
			treeNode12.Name = "Node16";
			treeNode12.Text = "户部";
			treeNode13.Name = "Node17";
			treeNode13.Text = "兵部";
			treeNode14.Name = "Node18";
			treeNode14.Text = "礼部";
			treeNode15.Name = "Node19";
			treeNode15.Text = "刑部";
			treeNode16.Name = "Node20";
			treeNode16.Text = "工部";
			treeNode17.Name = "Node13";
			treeNode17.Text = "丞相";
			treeNode18.Name = "Node2";
			treeNode18.Text = "文官系统";
			treeNode19.Name = "Node3";
			treeNode19.Text = "武将系统";
			treeNode20.Name = "Node4";
			treeNode20.Text = "情报系统";
			treeNode21.Name = "Node5";
			treeNode21.Text = "继承系统";
			treeNode22.Name = "Node24";
			treeNode22.Text = "宗族勋贵";
			treeNode23.Name = "Node32";
			treeNode23.Text = "总管大太监";
			treeNode24.Name = "Node33";
			treeNode24.Text = "秉笔";
			treeNode25.Name = "Node34";
			treeNode25.Text = "司礼";
			treeNode26.Name = "Node35";
			treeNode26.Text = "御马";
			treeNode27.Name = "Node31";
			treeNode27.Text = "内监系统";
			treeNode28.Name = "Node0";
			treeNode28.Text = "皇帝";
			treeNode29.Name = "Node6";
			treeNode29.Text = "江湖";
			treeNode30.Name = "Node38";
			treeNode30.Text = "佛";
			treeNode31.Name = "Node39";
			treeNode31.Text = "道";
			treeNode32.Name = "Node40";
			treeNode32.Text = "白莲";
			treeNode33.Name = "Node7";
			treeNode33.Text = "宗教";
			treeNode34.Name = "Node36";
			treeNode34.Text = "东林";
			treeNode35.Name = "Node37";
			treeNode35.Text = "岳麓";
			treeNode36.Name = "Node8";
			treeNode36.Text = "文人";
			treeNode37.Name = "Node10";
			treeNode37.Text = "护卫";
			treeNode38.Name = "Node11";
			treeNode38.Text = "情报";
			treeNode39.Name = "Node12";
			treeNode39.Text = "红颜(指针)";
			treeNode40.Name = "Node41";
			treeNode40.Text = "朋友(指针)";
			treeNode41.Name = "Node9";
			treeNode41.Text = "军师";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode28,
			treeNode29,
			treeNode33,
			treeNode36,
			treeNode41});
			this.treeView1.Size = new System.Drawing.Size(146, 541);
			this.treeView1.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1008, 547);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Event编辑器";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 573);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panelAsk.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picleft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picright)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
