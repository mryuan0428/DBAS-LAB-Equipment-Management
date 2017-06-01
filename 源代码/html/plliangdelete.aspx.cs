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
	/// plliangdelete 的摘要说明。
	/// </summary>
	public class plliangdelete : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
	
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
				this.Button1.Attributes.Add("onclick","return confirm('确定删除吗？')");
				string sql1="select * from labname";
				db1.cleardata();
				db1.ExectueSQL("labname",sql1);

				for(int i=0;i<db1.getdata().Tables["labname"].Rows.Count;i++)
				{
					this.DropDownList3.Items.Add(new ListItem(db1.getdata().Tables["labname"].Rows[i]["实验室名"].ToString()));
				}

				sql1="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.ToString()+"'";
				db1.cleardata();
				db1.ExectueSQL("labname",sql1);

				string lab=db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();

				sql1="select distinct 设备名称id from basicinfo where 实验室id="+db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();
				db1.cleardata();
				db1.ExectueSQL("basicinfo",sql1);

				this.DropDownList4.Items.Clear();
				for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
				{
					sql1="select * from sbname where 设备名称id="+db1.getdata().Tables["basicinfo"].Rows[i]["设备名称id"].ToString();
					db1.ExectueSQL("sbname",sql1);

					this.DropDownList4.Items.Add(new ListItem(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString()));
				}

				sql1="select * from sbname where 设备名称='"+this.DropDownList4.SelectedValue.ToString()+"'";
				db1.cleardata();
				db1.ExectueSQL("sbname",sql1);

				string sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

				sql1="select distinct 设备编号 from basicinfo where 设备名称id="+sb+" and 实验室id="+lab;

				db1.cleardata();
				db1.ExectueSQL("basicinfo",sql1);

				this.DropDownList1.Items.Clear();
				this.DropDownList2.Items.Clear();
				for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
					this.DropDownList2.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
				}

				sql1="select * from basicinfo where 设备名称id="+sb+" and 实验室id="+lab+" and 设备编号='"+this.DropDownList1.SelectedValue.ToString()+"'";
				db1.cleardata();
				db1.ExectueSQL("basicinfo",sql1);

				this.Label2.Text=db1.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString();

                string changjia=db1.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
				sql1="select * from changjia where 厂家id="+changjia;
				db1.cleardata();
				db1.ExectueSQL("changjia",sql1);

				this.Label1.Text=db1.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString();
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
			this.DropDownList1.SelectedIndexChanged += new System.EventHandler(this.DropDownList1_SelectedIndexChanged);
			this.DropDownList3.SelectedIndexChanged += new System.EventHandler(this.DropDownList3_SelectedIndexChanged);
			this.DropDownList4.SelectedIndexChanged += new System.EventHandler(this.DropDownList4_SelectedIndexChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DropDownList3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string sql1="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("labname",sql1);

			string lab=db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();

			sql1="select distinct 设备名称id from basicinfo where 实验室id="+db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			this.DropDownList4.Items.Clear();
			for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
			{
				sql1="select * from sbname where 设备名称id="+db1.getdata().Tables["basicinfo"].Rows[i]["设备名称id"].ToString();
				db1.ExectueSQL("sbname",sql1);

				this.DropDownList4.Items.Add(new ListItem(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString()));
			}

			sql1="select * from sbname where 设备名称='"+this.DropDownList4.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);

			string sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

			sql1="select distinct 设备编号 from basicinfo where 设备名称id="+sb+" and 实验室id="+lab;

			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			this.DropDownList1.Items.Clear();
			this.DropDownList2.Items.Clear();
			for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
			{
				this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
				this.DropDownList2.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
			}

			sql1="select * from basicinfo where 设备名称id="+sb+" and 实验室id="+lab+" and 设备编号='"+this.DropDownList1.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			this.Label2.Text=db1.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString();
			string changjia=db1.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
			sql1="select * from changjia where 厂家id="+changjia;
			db1.cleardata();
			db1.ExectueSQL("changjia",sql1);

			this.Label1.Text=db1.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString();
		}

		private void DropDownList4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string sql1="select * from sbname where 设备名称='"+this.DropDownList4.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);

			string sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

			sql1="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("labname",sql1);

			string lab=db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();

			sql1="select distinct 设备编号 from basicinfo where 设备名称id="+sb+" and 实验室id="+lab;

			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			this.DropDownList1.Items.Clear();
			this.DropDownList2.Items.Clear();
			for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
			{
				this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
				this.DropDownList2.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
			}

			sql1="select * from basicinfo where 设备名称id="+sb+" and 实验室id="+lab+" and 设备编号='"+this.DropDownList1.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			this.Label2.Text=db1.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString();
			string changjia=db1.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
			sql1="select * from changjia where 厂家id="+changjia;
			db1.cleardata();
			db1.ExectueSQL("changjia",sql1);

			this.Label1.Text=db1.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString();
		}

		private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string sql1="select * from sbname where 设备名称='"+this.DropDownList4.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);

			string sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

			sql1="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("labname",sql1);

			string lab=db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();

			sql1="select * from basicinfo where 设备名称id="+sb+" and 实验室id="+lab+" and 设备编号='"+this.DropDownList1.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			this.Label2.Text=db1.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString();
			string changjia=db1.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
			sql1="select * from changjia where 厂家id="+changjia;
			db1.cleardata();
			db1.ExectueSQL("changjia",sql1);

			this.Label1.Text=db1.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string sql1="delete from basicinfo where 设备名称id=";

			string sql2="select * from sbname where 设备名称='"+this.DropDownList4.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql2);

			string sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

			sql2="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("labname",sql2);

			string lab=db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();

			sql1+=sb+" and 实验室id="+lab+" and 设备编号 between '"+this.DropDownList1.SelectedValue.ToString()+"' and '"+this.DropDownList2.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			Response.Redirect("Basicinfo.aspx");
		}
	}
}
