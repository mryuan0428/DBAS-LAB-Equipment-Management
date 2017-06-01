using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace html
{
	/// <summary>
	/// HTMLPage1 的摘要说明。
	/// </summary>
	public class HTMLPage1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected Microsoft.Web.UI.WebControls.TreeView TreeView1;
		protected Microsoft.Web.UI.WebControls.TreeView TreeView2;
	
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			Session["name"]=Session["name"];
			Session["pwd"]=Session["pwd"];
			
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Unload += new System.EventHandler(this.HTMLPage1_Unload);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void HTMLPage1_Unload(object sender, System.EventArgs e)
		{
			//Session["name"]="";
			//Session["pwd"]="";
		}
	}
}
