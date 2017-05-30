/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/4/21
 * 时间: 13:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using royalplot.Entity;
using System.Xml;

using  System.Diagnostics;  //调试用

namespace test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Global globals;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	     	//globals=new Global();
	     	 
	     	Global.game=new Game();
	     	 Global.game.gameRun();
	     	 Global.game.gameTest();
	     	 
			//Global.game=new Game();
			//显示game中 user和KING的名字
			//MessageBox.Show(Global.game.userlist[0].thename+Global.game.princelist.Count+Global.game.npclist.Count+Global.game.userlist[0].Prince.thename,Global.game.king.thename);
			//debug.AppendText(Global.game.userlist[0].thename);
			
			SaveTreeNode();
		//	LoadTreeNode();
			
			SaveTreeNode2NPCMAP();
			
			showActions();
			showFollowers();
			showEvents();
			showPlaces();
			showMessage();
		}
		
		//---tree加载节点
        private void LoadTreeNode()
        {

            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            string filename = AppDomain.CurrentDomain.BaseDirectory + "111.xml";
            xmlDoc.Load(filename);
            if (xmlDoc.ChildNodes.Count > 0)
            {
                System.Xml.XmlNodeList nodes = xmlDoc.ChildNodes[0].ChildNodes;
                this.LoadNode(nodes, this.treeView1.Nodes);
            }
        }

        private void LoadNode(System.Xml.XmlNodeList nodes, TreeNodeCollection pNodes)
        {
            foreach (System.Xml.XmlElement element in nodes)
            {
                TreeNode node = new TreeNode();
                node.Text = element.GetAttribute("Value");
                pNodes.Add(node);
                LoadNode(element.ChildNodes, node.Nodes);
            }
        }
        //---保存tree节点
        private void SaveTreeNode()
        {
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            System.Xml.XmlElement rootNode = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootNode);
            this.SaveTreeNode(xmlDoc, rootNode, this.treeView1.Nodes);

            string filename = AppDomain.CurrentDomain.BaseDirectory + "111.xml";
            xmlDoc.Save(filename);
        }
        private void SaveTreeNode(System.Xml.XmlDocument xmlDoc, System.Xml.XmlElement rootNode, TreeNodeCollection nodes)
        {

            foreach (TreeNode node in nodes)
            {
                System.Xml.XmlElement pNode = xmlDoc.CreateElement("ChildNode");
                pNode.SetAttribute("Value", node.Text);
                rootNode.AppendChild(pNode);
                SaveTreeNode(xmlDoc, pNode, node.Nodes);
            }
        }
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
	
		} 
//----以下为保存的NPCMAP---------------------------------------------------
        private void SaveTreeNode2NPCMAP()
        { /*
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            System.Xml.XmlElement rootNode = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootNode);
            this.SaveTreeNode(xmlDoc, rootNode, this.treeView1.Nodes);

            string filename = AppDomain.CurrentDomain.BaseDirectory + "111.xml";
            xmlDoc.Save(filename);
            */
            
            var temps=Global.game.npcmap;
		//	Debug.WriteLine("加入入根结点：");
		    MLNode<Person> pt = new MLNode<Person>(10);
		    pt.Data = new Person();pt.Data.thename="root";
		    
		    //第一次调用 参数为 目标tree 根节点 源tree
		    this.SaveTreeNode2NPCMAP(temps, pt, this.treeView1.Nodes);
		    
		    Tools tools=new Tools();
			//tools.savetoJson(temps);
        }
        //用不同参数 重载此方法
        private void SaveTreeNode2NPCMAP(Npcmap<Person> temps,MLNode<Person> rootNode, TreeNodeCollection nodes)
        {

            foreach (TreeNode node in nodes)
            {                    
						MLNode<Person> ct = new MLNode<Person>(10); //当前设置最多10个子节点
						ct.Data =new Person();
						ct.Data.thename= node.Text;
						int i=rootNode.getchildnum();
						
					
					//	Debug.WriteLine("加入子结点：    "+ct.Data.thename+i+"   --/"+rootNode.Data.thename);
						bool ok = temps.Insert(ct, rootNode, i);
						if (ok)
						{
							//Debug.WriteLine("插入{0}成功", ct.Data);
							//Debug.WriteLine(temps.GetDepth(pt)+pt.Data.thename);
						};
						SaveTreeNode2NPCMAP(temps, ct, node.Nodes);
               
            }
        }
//-------------------------------------------------------------------------
     //显示行动列表 
    public void showActions()
		{
 //ListItem item = new ListItem("我是值", "我是名字");
 //this.listAction.Items.Add(item);
 this.listAction.DisplayMember = "Text";
 this.listAction.ValueMember = "Value";
  //  this.listAction.Items.Add( Global.game.userlist[0].activemenu[0].thename);
  //  this.listAction.Items.Add( Global.game.userlist[0].activemenu[1].thename);
  //  this.listAction.Items.Add( Global.game.userlist[0].activemenu[2].thename);
  //  this.listAction.Items.Insert(0,new ListItem(Global.game.userlist[0].activemenu[0].thename,Global.game.userlist[0].activemenu[0]));
 
 this.listAction.Items.Add(new ListItem(Global.game.userlist[0].activemenu[0].thename,Global.game.userlist[0].activemenu[0]));
 this.listAction.Items.Add(new ListItem(Global.game.userlist[0].activemenu[1].thename,Global.game.userlist[0].activemenu[1]));
 this.listAction.Items.Add(new ListItem(Global.game.userlist[0].activemenu[2].thename,Global.game.userlist[0].activemenu[2]));

		} 
     //显示属下列表     
	public void showFollowers()
		{
         this.listFollower.DisplayMember = "Text";
         this.listFollower.ValueMember = "Value";
         this.listFollower.Items.Add(new ListItem(Global.game.userlist[0].follower[0].thename,Global.game.userlist[0].follower[0]));
         this.listFollower.Items.Add(new ListItem(Global.game.userlist[0].follower[1].thename,Global.game.userlist[0].follower[1]));
         this.listFollower.Items.Add(new ListItem(Global.game.userlist[0].follower[2].thename,Global.game.userlist[0].follower[2]));
	
   
		}
	  //显示今日事件列表     
	public void showEvents()
		{
         this.listEvents.DisplayMember = "Text";
         this.listEvents.ValueMember = "Value";
         this.listEvents.Items.Add(new ListItem(Global.game.events[0].thename,Global.game.events[0]));
            this.listEvents.Items.Add(new ListItem(Global.game.events[1].thename,Global.game.events[1]));
               this.listEvents.Items.Add(new ListItem(Global.game.events[2].thename,Global.game.events[2]));
                  this.listEvents.Items.Add(new ListItem(Global.game.events[3].thename,Global.game.events[3]));
     
   
		}
	
	  //显示可到达地点列表     
	public void showPlaces()
		{
         this.listPlaces.DisplayMember = "Text";
         this.listPlaces.ValueMember = "Value";
         
         //注此地的添加 应该由文件读入 包括 地点的 关联事件 做个地点编辑器先
         this.listPlaces.Items.Add(new ListItem(Global.game.places[0].thename,Global.game.places[0]));
         this.listPlaces.Items.Add(new ListItem(Global.game.places[1].thename,Global.game.places[1]));
         this.listPlaces.Items.Add(new ListItem(Global.game.places[2].thename,Global.game.places[2]));
         this.listPlaces.Items.Add(new ListItem(Global.game.places[3].thename,Global.game.places[3]));
   
		}
	  //显示消息列表     
	public void showMessage()
		{
         this.listMessage.DisplayMember = "Text";
         this.listMessage.ValueMember = "Value";
         this.listMessage.Items.Add(new ListItem(Global.game.messages[0].thename,Global.game.messages[0]));
        
   
		}
	//当选中行动时
		void ListActionSelectedIndexChanged(object sender, EventArgs e)
		{
			if ( listAction.SelectedItem==null) return ;
			MessageBox.Show(((ListItem)listAction.SelectedItem).Text);
			MessageBox.Show(((Actions)((ListItem)listAction.SelectedItem).Value).thename.ToString());

		}
	 //当选中属下时
		void ListFollowerSelectedIndexChanged(object sender, EventArgs e)
		{
			if ( listFollower.SelectedItem==null) return ;
		    MessageBox.Show(((ListItem)listFollower.SelectedItem).Text);
			MessageBox.Show(((Person)((ListItem)listFollower.SelectedItem).Value).thename.ToString());
		}
	 //选中事件
		void ListEventsSelectedIndexChanged(object sender, EventArgs e)
		{
	       // MessageBox.Show(((ListItem)listEvents.SelectedItem).Text);
		   //	MessageBox.Show(((Events)((ListItem)listEvents.SelectedItem).Value).thename.ToString());
			
		   if (listEvents.SelectedItem==null) return ;
		   
		   
			//下面就是如何展开事件了 .应该是一段小动画 过场 目前可以先用文字做过场..或者用对话的方式 ...............................................
			Events theev=((Events)((ListItem)listEvents.SelectedItem).Value);
			//MessageBox.Show(theev.thename);
			foreach (Plot plot in theev.plotlist)
			{
			 foreach (Clip clip in plot.cliplist)
			 {
			 	MessageBox.Show(clip.sad);
			 }
			}
		}
		//选中地点
		void ListPlaceSelectedIndexChanged(object sender, EventArgs e)
		{
			if ( listPlaces.SelectedItem==null) return ;
	      //选中了地点
	      //MessageBox.Show(((ListItem)listPlaces.SelectedItem).Text);
		//	MessageBox.Show(((Place)((ListItem)listPlaces.SelectedItem).Value).thename.ToString()+"  将触发事件!");
			((Place)((ListItem)listPlaces.SelectedItem).Value).actByRND();
			
			showevent();
		}
		//选中了 消息 
		void ListMessageSelectedIndexChanged(object sender, EventArgs e)
		{
	     if ( listMessage.SelectedItem==null) return ;
	     string title=(( royalplot.Entity.Message)((ListItem)listMessage.SelectedItem).Value).thename.ToString();
	     string body=(( royalplot.Entity.Message)((ListItem)listMessage.SelectedItem).Value).thebody.ToString();
	     
	     MessageBox.Show(body,title);
	     
		}
		void PictureBox1Click(object sender, EventArgs e)
		{if (this.listFollower.Visible==true)
			{
			this.listFollower.Hide();
	      	this.listEvents.Hide();
	      	this.listAction.Hide();
	      	this.listMessage.Hide();
	      	this.listPlaces.Hide();
			}else{
		    this.listFollower.Show();
	      	this.listEvents.Show();
	      	this.listAction.Show();
	      	this.listMessage.Show();
	      	this.listPlaces.Show();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			royalplot.UI.EventEdit ev=new royalplot.UI.EventEdit();
			ev.Show();
		} 
		
		void showevent()
		{    
			//得到当前内容 感觉结构化做的不好 先实现吧 回头再优化
			if (Global.game.currentEvent==null) return;
			Clip cl=Global.game.currentEvent.getCurrentClip();
			//先隐藏所有控件
			hideall();
			
			//如果是对话
			if (cl.cliptype==0){
			string str=cl.sad;
			
		
			
			/*
			//见 冒号: 换行
			str=str.Replace(":","::/r/n    ");
			str=str.Replace("：",":\r\n    ");
			
			string[] s=Tools.cut(str,':');
			//string[] s=Tools.cut(str,'：');
			string imgfile=@".\images\stand\"+s[0].Trim()+".png";
			Debug.WriteLine(imgfile);
			*/
			string imgfile=cl.getpicfilename();
			speak.Text=str;
				
			/*
			this.speak.Clear();
			 foreach(string name in s){
                this.speak.AppendText(name+"\n");
            }*/
			
			//用currentClip的奇偶 来判断左右显示
			//暂时用 说话人的名字 来判别 立绘 只是暂时
			
			//背景透明
			if (Global.game.currentEvent.leftorright()==0)
			{
			    picright.Visible=false;
			    picleft.BackColor=Color.Transparent;
			    picleft.Parent=this.picBackground;
			    picleft.Image=Image.FromFile(imgfile); 
			    picleft.Visible=true;
			}else{
				picleft.Visible=false;
		        picright.BackColor=Color.Transparent;
			    picright.Parent=this.picBackground;
			    picright.Image=Image.FromFile(imgfile); 
			    picright.Visible=true;
			}
			
			speak.Multiline = true ;
			speak.Visible=true;
			}
			
			//如果是选项
			if (cl.cliptype==2){
				
				
				string[] s=Tools.cut(cl.sad);  
				listBoxAsk.Items.AddRange(s);
				panelAsk.Visible=true;
			}
			//如果是场景描述
			if (cl.cliptype==1){
	    
			}
			//如果是场景切换命令
			if (cl.cliptype==4){
				picBackground.Image=Image.FromFile(@".\images\background\"+cl.sad+".jpg"); 
				//马上下一条
	            showevent();
			}
			//如果是命令
			if (cl.cliptype==5){
	    
			}
		}
		
		void hideall()
		{
			picleft.Visible=false;
			picright.Visible=false;
			speak.Visible=false;
			panelAsk.Visible=false;	
		
		}
		void SpeakClick(object sender, EventArgs e)
		{//点击 到下一条
			
			//得有个地方存 当前event 当前plot 当前 clip
			showevent();
		}
		
	
		void ListBoxAskClick(object sender, EventArgs e)
		{
		  //如何执行命令	
			
	      hideall();
		}
		
		
    	
	}
}
