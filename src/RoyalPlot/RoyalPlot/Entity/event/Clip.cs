/*
 * 单句对话单元  存储单句对话 或者单次选择 或者单个展示
 * 用户： Administrator
 * 日期: 2017/5/3
 * 时间: 15:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of Clip.
	/// </summary>
	public class Clip
	{   
		//对话种类 0.场景描述 1.对话  2.选项菜单 3.内心独白 4.场景切换命令
		public int cliptype=-1;
		//对话内容 用分隔符 分开谈话者 和谈话内容 用{}来表达可替换的人物变量
		public string sad;
		//控制命令字符串 用于输入一堆有分割的字串执行命令 便于未来扩展 
		public string command;
		
		//头像种类 立像 头像等
		//头像名称
		//头像位置
		
		//对话节奏 一次说完 还是需要用户点几次说完
		public Clip()
		{
		}
		public Clip(int typ,string str)
		{
			cliptype=typ; 
			sad=str;
		}
		public int execute()
		{  //执行事件 
			//Debug.WriteLine("CLIP执行: "+sad);
			//循环顺序执行clip 因为PLOT 内部是不许跳转的 所以不用担心跳转问题
			//int selid= cliplist[0].execute(); //最后返回 PLOT 最后一个问题的 选项答案 决定跳转到个PLOT
			
			return 1;
				
		}
		public string getpicfilename()
		{  
			//这里把中英文冒号统一换成英文的 方便下面按:分割 并加上换行
			sad=sad.Replace(":",":/r/n    ");
			sad=sad.Replace("：",":\r\n    ");
		
			
			//目前采用 直接从对话中提取图像名字的办法  以后可以 如果COMMAND中没有注明 才到对话中提取
			string[] s=Tools.cut(sad,':');  
			//string[] s=Tools.cut(str,'：');
			//这里图像路径 先硬性规定死 按道理是要读配置的
			string imgfile=@".\images\stand\"+s[0].Trim()+".png";
			
			return imgfile;
				
		}
	}
}
