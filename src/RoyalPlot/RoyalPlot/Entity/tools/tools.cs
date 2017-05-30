/*
 * 工具类 如对象序列化反序列化 方法
 * 用户： Administrator
 * 日期: 2017/4/26
 * 时间: 9:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

using System.Collections.Generic; //应用泛型
using Newtonsoft.Json;  //引用了 第三方JOSN包
using System.Text;
using  System.Diagnostics;  //调试用

namespace royalplot.Entity
{
	/// <summary>
	/// Description of tools.
	/// </summary>
	///  
	/*
	public class Student
    {
     public int ID { get; set; }
     public string Name { get; set; }
     public int Age { get; set; }
     public string Sex { get; set; }
    }
    */
   
   //给listbox用的列表项对象 为了同时添加 文本和对象
   public class ListItem
    {   private string _Text;
        public string Text
        {   get { return _Text; }
            set { _Text = value; }
        }
        private object _Value;
        public object Value
        {   get { return _Value; }
            set { _Value = value; }
        }
        public ListItem(string text, object value)
        {   _Text = text;
            _Value = value;
        }
    }
/*
    //获得对象myClass的所有属性组成的集合 propertys  可遍历生成WEB编辑器 编辑 事件 行动等
    myClass myobj=new myClass();  
    PropertyInfo[] propertys = myobj.GetType().GetProperties();  
    foreach (PropertyInfo pinfo in propertys)  
    {  
        Response.Write("<br>"+pinfo.Name+","+pinfo.GetValue(myobj,null));  
    }  
  */ 
	public class Tools
	{
		public Tools()
		{
		}
		//把对象直接序列化成JSON保存 使用第三方 Newtonsoft组件
		public static int savetoJson<T>(T t,string filename,string thepath="Events")
        
 		{
			Debug.WriteLine("SaveFile<T>");
			string jsonData = JsonConvert.SerializeObject(t);
 
            //Debug.WriteLine(jsonData);
            savetoFile(filename,jsonData,thepath);
			return 1;
		}
		//从JSON中读出对象
		public static T loadfromJson<T> (string filename,string thepath="Events")
 		{  Debug.WriteLine("loadfile:  "+thepath+"/"+filename);
		 	string jsonData=loadfromFile(filename,thepath);
		 //	Debug.WriteLine(jsonData);
		 	T obj= JsonConvert.DeserializeObject<T>(jsonData);
		 	return obj;
/*		 	
   //Json.NET反序列化
   string json = @"{ 'Name':'C#','Age':'3000','ID':'1','Sex':'女'}";
   Student descJsonStu = JsonConvert.DeserializeObject<Student>(json);//反序列化
   Console.WriteLine(string.Format("反序列化： ID={0},Name={1},Sex={2},Sex={3}", descJsonStu.ID, descJsonStu.Name, descJsonStu.Age, descJsonStu.Sex));
   Console.ReadKey(); 
*/		 	
		}
		 public static int savetoFile(string filename,string str,string thepath="Events")
 		{
		 
            System.IO.File.WriteAllText(@".\"+thepath+@"\"+filename+".txt", str, Encoding.UTF8);
            
		 	/*
		 	//如果文件不存在，则创建；存在则覆盖
            //该方法写入字符数组换行显示
            string[] lines = { "first line", "second line", "third line","第四行" };
          //  System.IO.File.WriteAllLines(@"C:\testDir\test.txt", lines, Encoding.UTF8);
            System.IO.File.WriteAllLines(@".\Events\test.txt", lines, Encoding.UTF8);

            //如果文件不存在，则创建；存在则覆盖
            string strTest = "该例子测试一个字符串写入文本文件。";
            System.IO.File.WriteAllText(@".\Events\test1.txt", strTest, Encoding.UTF8);

            //在将文本写入文件前，处理文本行
            //StreamWriter一个参数默认覆盖
            //StreamWriter第二个参数为false覆盖现有文件，为true则把文本追加到文件末尾
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\Events\test2.txt",true))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("second"))
                    {
                        file.Write(line);//直接追加文件末尾，不换行
                        file.WriteLine(line);// 直接追加文件末尾，换行   
                    }
                }
            }
		 	
		 	*/
        	
        	return 1;
		}
		 public static string loadfromFile(string filename,string thepath="Events")
 		{
		 	try{
		 	string text = System.IO.File.ReadAllText(@".\"+thepath+@"\"+filename+".txt");
		 	return text;
		 	}
		 	catch{
		 		Debug.WriteLine("读取文件错误:  "+filename);
		 		return "";
		 	}
		 		
		 	/*
        	 //直接读取出字符串
            string text = System.IO.File.ReadAllText(@"C:\testDir\test1.txt");
            Console.WriteLine(text);

            //按行读取为字符串数组
            string[] lines = System.IO.File.ReadAllLines(@"C:\testDir\test.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            //从头到尾以流的方式读出文本文件
            //该方法会一行一行读出文本
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\testDir\test.txt"))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                                       
                	Console.WriteLine(str);
                }
            }
            Console.Read();
        	*/
		}
		 //字符串切分 返回字符串数组
		 public static string[] cut(string str,char str0='/')
 		 { 
		   string[] sArray=str.Split(str0);
		   return sArray;
		 }
		 //产生随机数
		 public static int rnd()
 		 { 
		   Random ro = new Random();
		  		   
		   int iResult;
           int iUp=100;
           iResult=ro.Next(iUp);
           Debug.WriteLine("rnd=:  "+iResult.ToString());
           return iResult;
		 }
		 
		 
		 //测试TREE类的 正确性 最终版
		 public string testtree0()
 		{
		 	MLTree<string> tree = new MLTree<string>();
		 	//插入节点
		 	            Debug.WriteLine("输入父结点：");
						string str ="根节点";
						MLNode<string> pt = new MLNode<string>(4);
						pt.Data = str;
						Debug.WriteLine("输入子结点：");
						str = "子节点0";
						MLNode<string> ct = new MLNode<string>(4);
						ct.Data = str;
						Debug.WriteLine("输入插入子结点的位置：");
						int i = 0;
						bool ok = tree.Insert(ct, pt, i);
						Debug.WriteLine(i);
						Debug.WriteLine(ok);
						if (ok)
						{
							Debug.WriteLine("插入{0}成功", ct.Data);
							Debug.WriteLine(tree.GetDepth(pt));
						}
						savetoJson(tree,"treetest");
			  //遍历节点
                   tree.Traverse(2);
                   //得到根节点
                   MLNode<string> theroot=tree.Root();
                   Debug.WriteLine("root="+theroot.Data);
                   //得到第0个子节点
                   MLNode<string> thechild=tree.Child(theroot,0);
                   Debug.WriteLine("child0="+thechild.Data);
			  
		 	return "";
	    }
		//测试TREE类的 正确性 
		public string testtree()
 		{
        	MLTree<string> tree = new MLTree<string>();
        	char ch; int z=0;
			do
			{ z++;
				//Debug.WriteLine("1.添加结点");
				//Debug.WriteLine("2.删除结点");
				//Debug.WriteLine("3.遍历树");
				//Debug.WriteLine("4.添加子结点");
				//Debug.WriteLine("5.退出");
				//Debug.WriteLine();
				//ch = Convert.ToChar(Debug.ReadLine());
				ch = Convert.ToChar(z);
			
				switch (ch)
				{
					case '1':
						Debug.WriteLine("输入父结点：");
						string str = Convert.ToString(ch);
						MLNode<string> pt = new MLNode<string>(4);
						pt.Data = str;
						Debug.WriteLine("输入子结点：");
						str = Convert.ToString(ch);
						MLNode<string> ct = new MLNode<string>(4);
						ct.Data = str;
						Debug.WriteLine("输入插入子结点的位置：");
						int i = Convert.ToInt32(ch);
						bool ok = tree.Insert(ct, pt, i);
						Debug.WriteLine(i);
						Debug.WriteLine(ok);
						if (ok)
						{
							Debug.WriteLine("插入{0}成功", ct.Data);
							Debug.WriteLine(tree.GetDepth(pt));
						}
						savetoJson(tree,"treetest");
						
						break;
					case '2':
						Debug.WriteLine("输入要删除的结点：");
						str = Convert.ToString(ch);
						pt = new MLNode<string>(4);
						pt.Data = str;
						tree.Delete(pt, 0);
						break;
					case '3':
						tree.Traverse(2);
						break;
				}
				
			} while (ch != '5');
		
        	return "";
		}
         
		 /*
        public int savetoJson()
        
 		{
         Debug.WriteLine("开始保存");
     	 List<Student> lstStuModel = new List<Student>() 
        {
        new Student(){ID=1,Name="张飞",Age=250,Sex="男"},
        new Student(){ID=2,Name="潘金莲",Age=300,Sex="女"}
        };
       
        //Json.NET序列化
        string jsonData = JsonConvert.SerializeObject(lstStuModel);
 
        Debug.WriteLine(jsonData);
        Debug.WriteLine("成功");
        //Debug.WriteLine.ReadKey();
      
      
        //Json.NET反序列化
        string json = @"{ 'Name':'C#','Age':'3000','ID':'1','Sex':'女'}";
        Student descJsonStu = JsonConvert.DeserializeObject<Student>(json);//反序列化
        Debug.WriteLine(string.Format("反序列化： ID={0},Name={1},Sex={2},Sex={3}", descJsonStu.ID, descJsonStu.Name, descJsonStu.Age, descJsonStu.Sex));
        // Console.ReadKey(); 
        return 1;
 
		}
		*/
       
		
		
	}
}
