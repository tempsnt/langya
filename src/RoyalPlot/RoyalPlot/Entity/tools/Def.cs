/*
 * 常量定义类
 * 用户： Administrator
 * 日期: 2017/5/9
 * 时间: 16:37
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of Def.
	/// </summary>
	public static class DEF
	{ /*
	  //示例	
      public const double Pi = 3.14159;
      public const int SpeedOfLight = 300000; // km per sec.
   
      public const int EV_describe  = 0;
      public const int EV_dialog  = 1;
      public const int EV_menus  = 2;
      public const int EV_monologue =3;
      public const int EV_imagechange =4;
      */      
     
     //cliptype 定义 对话类型 系列常量  用来标识 一个clip的种类 并决定如何执行它
      public enum EvtType
       {
      	对白=1,
      	场景描述=0,
      	菜单=2,
      	内心独白=3,
      	场景切换=4,
      	命令=5,
      	跳转标签=6     //可供跳转到的标签位置 类似GOTO到	那里 如命令是 goto dance  就跳转到标签是 dance的地方 
        //describe  = 0, //0 场景描述
        //dialog  = 1,   //1 人物对话
        //menus  = 2,    //2 菜单选项
        //monologue =3,  //3 内心独白
        //imagechange =4 //4 场景切换 (一般来说 一个PLOT 不切换场景 如需要切换就用这个 单独做成一个切换clip)
       };
      public enum EvtCommand
       {
        跳转  = 0, //0 场景描述
        结束  = 1,   //1 人物对话
        menus  = 2,    //2 菜单选项
        monologue =3,  //3 内心独白
        imagechange =4 //4 场景切换 (一般来说 一个PLOT 不切换场景 如需要切换就用这个 单独做成一个切换clip)
       };
      public enum MessType
       {
        Moning = 0,
        Afternoon = 1,
        Evening = 2,
       };
	}
}
