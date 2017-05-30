/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/5/18
 * 时间: 18:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO ;
using royalplot.Entity;
using  System.Diagnostics;  //调试用

namespace royalplot.UI
{
	/// <summary>
	/// Description of EventEdit.
	/// </summary>
	public partial class EventEdit : Form
	{
		public Events ev;  //当前事件
		public Plot pt;    //当前桥段
		public Clip cl;    //当前对话
		public EventEdit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			init();
		}
		
		
		void init()
		{
	   //---
	     //string filepath=Server.mapPath(@".\Events\"); 
         string filepath=(@".\Events\");	     
         string [] filenames=Directory.GetFiles(filepath);  //获取该文件夹下面的所有文件名
         this.listBox1.Items.Clear();
         foreach (string str in filenames )
         {  //只取文件名 并添加到列表
         	this.listBox1.Items.Add(Path.GetFileNameWithoutExtension(str));
         }
         
         //绑定两个下拉框
         foreach (var v in typeof(DEF.EvtType).GetFields())  
         {  
            if (v.FieldType.IsEnum == true)  
            {  
             this.comboBox1.Items.Add(v.Name);  
            }
         }  
         //this.comboBox1.SelectedIndex = 1;
         foreach (var v in typeof(DEF.EvtCommandType).GetFields())  
         {  
            if (v.FieldType.IsEnum == true)  
            {  
             this.comboBox2.Items.Add(v.Name);  
            }
         }

         
		}
		void clearEdits()
		{
		 //	this.comboBox1.SelectedIndex = miCurSel;
		  comboBox1.SelectedIndex=-1;
		  comboBox2.SelectedIndex=-1;
		  textBox1.Text="";
		  textBox2.Text="";
		}
		void getEdits()
		{
		 //把修改保存到当前clip对象
		  if (ev!=null) ev.thename=textBox3.Text;
		  if (pt!=null) pt.thename=textBox4.Text;
		  if (cl!=null){
		   cl.cliptype=comboBox1.SelectedIndex;
	       cl.sad=textBox1.Text;
		   cl.command=textBox2.Text;
		  }
		}
		//刷新 plot列表
		void getpoltlist()
		{
			
			this.listBox2.Items.Clear();
			foreach (Plot pt in ev.plotlist )
            {  //只取文件名 并添加到列表
         	this.listBox2.Items.Add(pt.thename);
			};
			if (listBox2.Items.Count>0)listBox2.SelectedIndex=0;
		}
		//刷新 clip列表
		void getcliplist()
		{
			//刷新 plot列表
			this.listBox3.Items.Clear();
			foreach (Clip clp in pt.cliplist )
            {  //只取文件名 并添加到列表
         	this.listBox3.Items.Add(clp.sad);
            }
			
		}
		//选择了event  则读进来 并刷新plotlist
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{   
			if ( listBox1.SelectedItem==null) return ;
			ev=null;
			//ev=new Events();
			string str=listBox1.SelectedItem.ToString();
			this.textBox5.Text=str;
			//Debug.WriteLine(str);
			ev= Tools.loadfromJson<Events>(str);
			this.textBox3.Text=ev.thename;
			//Debug.WriteLine(ev.thename);
			
			getpoltlist();
		}
		//选择了 plot 刷新cliplist
		void ListBox2SelectedIndexChanged(object sender, EventArgs e)
		{//
			if ( listBox2.SelectedItem==null) return ;
	       int sel=listBox2.SelectedIndex;
	       pt=ev.plotlist[sel];
	       this.textBox4.Text=pt.thename;
	       
	       getcliplist();
		}
		void ListBox3SelectedIndexChanged(object sender, EventArgs e)
		{//选择clip
			if ( listBox3.SelectedItem==null) return ;
	       int sel=listBox3.SelectedIndex;
	       cl=pt.cliplist[sel];
	       comboBox1.SelectedIndex=cl.cliptype;
	       
	       textBox1.Text=cl.sad;
	       textBox2.Text=cl.command;
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
	   //---保存所有
	      getEdits();
	    //  Debug.WriteLine(ev.thename);
	      if (ev!=null) ev.saveEvent(this.textBox5.Text);
		}
		//新建一个event
		void Button3Click(object sender, EventArgs e)
		{
			this.textBox5.Text=InputBox("输入EVENT文件名:", "", "");
			if (this.textBox5.Text!=""){
			  ev=new royalplot.Entity.Events();
			  ev.thename=this.textBox5.Text;
			  this.textBox3.Text=ev.thename;
			  //这里缺省new一个 plot??
			  pt=new Plot();
			  ev.plotlist.Add(pt);
			  
			  ev.saveEvent(this.textBox5.Text);
			  init();
			  getpoltlist();
			  MessageBox.Show("Event"+this.textBox5.Text+"创建成功!! 请添加plot","Event创建成功");
		    }
		}
		//新建一个Plot
		void Button1Click(object sender, EventArgs e)
		{
	       string plotname=InputBox("输入Plot名:", "", "");
	       if (plotname!=""){
	       	pt=new Plot(plotname);
	       	ev.plotlist.Add(pt);
	       	this.textBox4.Text=pt.thename;
	       	getpoltlist();
	       }
		}
		//新建一个 CLIP
		void Button2Click(object sender, EventArgs e)
		{
	     //new clip
	     cl=new Clip();
	     cl.sad="--------------";
	     pt.cliplist.Add(cl);
	     getcliplist();
	     
	     //清空
	     clearEdits();
	     
		}
		//批量转换到当前plot的多个clip中
		void Button5Click(object sender, EventArgs e)
		{
			string[] strTxt = this.textBox1.Text.Split("\n".ToCharArray());
			foreach (string str in strTxt)
			{
				if (str.Trim()!="" && str.Trim()!="\r" )
				{
				 // Debug.WriteLine(str);
				  cl=new Clip();
	              cl.sad=str;
	              pt.cliplist.Add(cl);
				}
			}
			getcliplist();
	
		}
		
		
		
		
	//弹出输入框	
		 private string InputBox(string Caption, string Hint, string Default)
        {
            //by 闫磊 Email:Landgis@126.com,yanleigis@21cn.com 2007.10.10
            Form InputForm = new Form();
            InputForm.MinimizeBox = false;
            InputForm.MaximizeBox = false;
            InputForm.StartPosition = FormStartPosition.CenterScreen;
            InputForm.Width = 220;
            InputForm.Height = 150;
            //InputForm.Font.Name = "宋体";
            //InputForm.Font.Size = 10;

            InputForm.Text = Caption;
            Label lbl = new Label();
            lbl.Text = Hint;
            lbl.Left = 10;
            lbl.Top = 20;
            lbl.Parent = InputForm;
            lbl.AutoSize = true;
            TextBox tb = new TextBox();
            tb.Left = 30;
            tb.Top = 45;
            tb.Width = 160;
            tb.Parent = InputForm;
            tb.Text = Default;
            tb.SelectAll();
            Button btnok = new Button();
            btnok.Left = 30;
            btnok.Top = 80;
            btnok.Parent = InputForm;
            btnok.Text = "确定";
            InputForm.AcceptButton = btnok;//回车响应

            btnok.DialogResult = DialogResult.OK;
            Button btncancal = new Button();
            btncancal.Left = 120;
            btncancal.Top = 80;
            btncancal.Parent = InputForm;
            btncancal.Text = "取消";
            btncancal.DialogResult = DialogResult.Cancel;
            try
            {
                if (InputForm.ShowDialog() == DialogResult.OK)
                {
                    return tb.Text;
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                InputForm.Dispose();
            }

        }
	
	
	
		
	}
}
