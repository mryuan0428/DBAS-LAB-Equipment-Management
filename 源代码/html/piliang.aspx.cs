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
	/// piliang 的摘要说明。
	/// </summary>
	public class piliang : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Web.UI.WebControls.Button Button1;
	
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			//Response.Write(name+id);
			db1=new Class1();
			string sql="select * from admin where username='";
			sql+=name;
			
			sql+="' and password='";
			sql+=id;
			sql+="'";
			db1.cleardata();
			db1.ExectueSQL("admin",sql);

			if(db1.getdata().Tables["admin"].Rows.Count==0)
			{
				sql="select * from userid where name='"+name+"' and password='"+id+"'";
				db1.cleardata();
				db1.ExectueSQL("userid",sql);
				if(db1.getdata().Tables["userid"].Rows.Count==0)
					Response.Redirect("cuowu1.htm");
			}
			if(!Page.IsPostBack)
			{
				this.Button1.Attributes.Add("onclick","return confirm('确定添加吗？')");
				string sql1="select * from sbname";
				db1.cleardata();
				db1.ExectueSQL("sbname",sql1);

				this.DropDownList1.Items.Clear();
				for(int i=0;i<db1.getdata().Tables["sbname"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString());
				}

				sql1="select * from labname";
				db1.cleardata();
				db1.ExectueSQL("labname",sql1);

				this.DropDownList2.Items.Clear();
				for(int i=0;i<db1.getdata().Tables["labname"].Rows.Count;i++)
				{
					this.DropDownList2.Items.Add(db1.getdata().Tables["labname"].Rows[i]["实验室名"].ToString());
				}

				sql1="select * from changjia";
				db1.cleardata();
				db1.ExectueSQL("changjia",sql1);

				this.DropDownList3.Items.Clear();
				for(int i=0;i<db1.getdata().Tables["changjia"].Rows.Count;i++)
				{
					this.DropDownList3.Items.Add(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString());
				}
			}
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			//string sql1="insert into basicinfo values('" + this.TextBox1.Text+"',";
			string sb;
			string lab;
			string cj;
			string sql2="select * from sbname where 设备名称='" + this.DropDownList1.SelectedValue.ToString()+"'";

			db1.cleardata();
			db1.ExectueSQL("sbname",sql2);

			sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();
			
			sql2="select * from changjia where 厂家名称='"+this.DropDownList3.SelectedValue.ToString()+"'";

			db1.cleardata();
			db1.ExectueSQL("changjia",sql2);

			cj=db1.getdata().Tables["changjia"].Rows[0]["厂家id"].ToString();
			
			sql2="select * from labname where 实验室名='" + this.DropDownList2.SelectedValue.ToString()+"'";

			db1.cleardata();
			db1.ExectueSQL("labname",sql2);

			lab=db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();
			
			int num=Int32.Parse(this.TextBox2.Text.ToString());
			int first=0;
			for(int i=0;i<9;i++)
			{
				if(this.TextBox1.Text.IndexOf(i.ToString(),0,this.TextBox1.Text.Length)!=-1)
				{
					first=i;
					break;
				}
			}
			string firstid=this.TextBox1.Text.Substring(this.TextBox1.Text.Length-2,2);
			string letter=this.TextBox1.Text.Substring(0,this.TextBox1.Text.Length-2);
			for(int i=0;i<num;i++)
			{
				int j=Int32.Parse(firstid)+i;
				string s;
				if(j<10)
					s="0"+j.ToString();
				else
					s=j.ToString();
				string biaohao=letter+s;
				string sql1="insert into basicinfo values('"+biaohao+"',"+sb+","+cj+",'"+this.TextBox3.Text+"',"+lab+")";

				db1.ExectueSQL("",sql1);
			}
			Response.Redirect("Basicinfo.aspx");
		}
	}
}
