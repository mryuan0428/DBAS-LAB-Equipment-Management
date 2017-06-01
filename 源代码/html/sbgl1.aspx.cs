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
	/// WebForm1 的摘要说明。
	/// </summary>
	public class sbgl11 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.HtmlControls.HtmlInputHidden Hidden1;
		
		Class1 db1;
		//protected html.DataSet1 dataSet12;
	
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
			string sql1;
			if(!Page.IsPostBack)
			{
				
				sql="select * from labname";
				db1.cleardata();
				db1.ExectueSQL("labname",sql);
				this.DropDownList3.Items.Clear();

				for(int i=0;i<db1.getdata().Tables["labname"].Rows.Count;i++)
				{
					this.DropDownList3.Items.Add(new ListItem(db1.getdata().Tables["labname"].Rows[i]["实验室名"].ToString()));
				}
				
				sql="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
				db1.cleardata();
				db1.ExectueSQL("labname",sql);

				sql="select distinct 设备编号 from basicinfo where 实验室id="+db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();
				db1.cleardata();
				db1.ExectueSQL("basicinfo",sql);

				this.DropDownList4.Items.Clear();
				for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
				{
					this.DropDownList4.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
				}
				this.Hidden1.Value="0";
			}
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			//this.DataGrid1.VirtualItemCount=5;
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			
			BoundColumn b1=new BoundColumn();
			b1.DataField="设备编号";
			b1.ReadOnly=true;
			b1.HeaderText="设备编号";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="厂家名称";
			b1.ReadOnly=true;
			b1.HeaderText="厂家名称";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="出厂日期";
			b1.ReadOnly=true;
			b1.HeaderText="出厂日期";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="经手人";
			b1.ReadOnly=true;
			b1.HeaderText="经手人";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="登记日期";
			b1.ReadOnly=true;
			b1.HeaderText="登记日期";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="具体时间";
			b1.ReadOnly=true;
			b1.HeaderText="具体时间";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="故障部件";
			b1.ReadOnly=true;
			b1.HeaderText="故障部件";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="故障名称";
			b1.ReadOnly=true;
			b1.HeaderText="故障名称";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="设备名称";
			b1.ReadOnly=true;
			b1.HeaderText="设备名称";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="实验室名";
			b1.ReadOnly=true;
			b1.HeaderText="实验室名";
			this.DataGrid1.Columns.Add(b1);

			HyperLinkColumn h1=new HyperLinkColumn();
			h1.DataNavigateUrlField="故障id";
			h1.DataNavigateUrlFormatString="weihu.aspx?id={0}";
			h1.DataTextField="故障id";
			h1.HeaderText="故障id";
			this.DataGrid1.Columns.Add(h1);

			//is.DataGrid1.PageCount=pagecount;
			//this.DataGrid1.Columns[13].HeaderText="1";
			//this.DataGrid1.Columns[13].DataField="设备编号";
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			
			if(this.DataGrid1.PageCount==1)
				this.Button3.Enabled=false;
			this.Button2.Enabled=false;
			//if(Request.QueryString["pwd1"]!=this.dataSet2.Tables["用户"].Rows[0]["密码"].ToString())
			//{
			//	Response.Redirect("denglu1.asp");
			//}
			//this.Label1.Text="欢迎您:"+this.dataSet2.Tables["用户"].Rows[0]["用户名"].ToString();
			if(!Page.IsPostBack)
			{
				

			}
			//if(this.DataGrid1.PageCount==1)
			//	this.ImageButton1.Enabled=false;
			//this.Imagebutton2.Enabled=false;
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
			this.DropDownList3.SelectedIndexChanged += new System.EventHandler(this.DropDownList3_SelectedIndexChanged);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		

		private void DataGrid1_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			//Response.Write(name+id);
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
					Response.Redirect("cuowu3.htm");
				else
					Response.Redirect("cuowu2.htm");
			}
			string sql1="delete from info where 故障id="+((HyperLink)e.Item.Cells[10].Controls[0]).Text;
			db1.cleardata();
			db1.ExectueSQL("info",sql1);
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			db1.cleardata();
			db1.ExectueSQL("info",sql1);

			sql1="select * from 维护";
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			this.DataGrid1.CurrentPageIndex=0;
			
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;

		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			int iPos=e.NewPageIndex;
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			this.DataGrid1.CurrentPageIndex=iPos;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int iPos=0;
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			this.DataGrid1.CurrentPageIndex=iPos;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();

			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex+1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 维护";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			
			db1.cleardata();
			db1.ExectueSQL("维护",sql1);
			
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.PageCount-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;
		}

		private void DropDownList3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string sql="select * from labname where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			db1.cleardata();
			db1.ExectueSQL("labname",sql);

			sql="select distinct 设备编号 from basicinfo where 实验室id="+db1.getdata().Tables["labname"].Rows[0]["实验室id"].ToString();
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql);

			this.DropDownList4.Items.Clear();
			for(int i=0;i<db1.getdata().Tables["basicinfo"].Rows.Count;i++)
			{
				this.DropDownList4.Items.Add(new ListItem(db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString()));
			}
			sql="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			db1.cleardata();
			db1.ExectueSQL("维护",sql);
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;
			this.Hidden1.Value="1";
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql="select * from 维护 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			sql+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			db1.cleardata();
			db1.ExectueSQL("维护",sql);
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="维护";
			this.DataGrid1.DataKeyField="故障id";
			this.DataGrid1.DataBind();
			
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button2.Enabled=false;
			else
				this.Button2.Enabled=true;
			this.Hidden1.Value="2";

		}
	}
}
