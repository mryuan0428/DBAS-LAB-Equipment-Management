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
	/// Basicinfo 的摘要说明。
	/// </summary>
	public class Basicinfo1 : System.Web.UI.Page
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
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			
			db1=new Class1();
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
			}
			string sql1="";
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
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			
			BoundColumn b1=new BoundColumn();
			b1.DataField="设备id";
			b1.ReadOnly=true;
			b1.HeaderText="设备id";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="设备编号";
			b1.ReadOnly=true;
			b1.HeaderText="设备编号";
			this.DataGrid1.Columns.Add(b1);
			b1=new BoundColumn();
			b1.DataField="设备名称";
			b1.ReadOnly=true;
			b1.HeaderText="设备名称";
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
			b1.DataField="实验室名";
			b1.ReadOnly=true;
			b1.HeaderText="实验室名";
			this.DataGrid1.Columns.Add(b1);
					
			//this.DataGrid1.PageCount=pagecount;
			//this.DataGrid1.Columns[13].HeaderText="1";
			//this.DataGrid1.Columns[13].DataField="设备编号";
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
			this.DataGrid1.DataBind();
			
			if(this.DataGrid1.PageCount==1)
				this.Button3.Enabled=false;
			this.Button2.Enabled=false;
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
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			int iPos=e.NewPageIndex;
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			this.DataGrid1.CurrentPageIndex=iPos;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
			this.DataGrid1.DataBind();
		}

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
			string sql1="delete from basicinfo where 设备id="+e.Item.Cells[0].Text;
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1);

			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			this.DataGrid1.CurrentPageIndex=0;
			
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int iPos=0;
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")
			{
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			this.DataGrid1.CurrentPageIndex=iPos;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex+1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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
				sql1="select * from 基本信息";
			}
			else if(this.Hidden1.Value.Trim()=="1")
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			}
			else
			{
				sql1="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
				sql1+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			}
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.PageCount-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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
			sql="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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
			string sql="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			sql+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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
