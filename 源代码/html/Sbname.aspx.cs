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
	/// Sbname 的摘要说明。
	/// </summary>
	public class Sbname : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button5;
	
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
			string sql1="select * from sbname";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			//this.DataGrid1.DataSource=this.dataSet11;
			//this.DataGrid1.DataBind();

			this.DataGrid1.Columns.Clear();
			BoundColumn b1=new BoundColumn();
			b1.DataField="设备名称id";
			b1.ReadOnly=true;
			b1.HeaderText="设备名称id";
			this.DataGrid1.Columns.Add(b1);

			b1=new BoundColumn();
			b1.DataField="设备名称";
			b1.HeaderText="设备名称";
			this.DataGrid1.Columns.Add(b1);

			EditCommandColumn e1=new EditCommandColumn();
			e1.ButtonType=ButtonColumnType.LinkButton;
			e1.UpdateText="更新";
			e1.CancelText="取消";
			e1.EditText="编辑";

			this.DataGrid1.Columns.Add(e1);

			ButtonColumn bc1=new ButtonColumn();
			bc1.CommandName="Delete";
			bc1.Text="删除";
			this.DataGrid1.Columns.Add(bc1);
						
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.PageCount==1)
				this.Button4.Enabled=false;
			this.Button3.Enabled=false;
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
			this.DataGrid1.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGrid1_ItemCreated);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.CancelCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_CancelCommand);
			this.DataGrid1.EditCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_EditCommand);
			this.DataGrid1.UpdateCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_UpdateCommand);
			this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			int iPos=e.NewPageIndex;
			string sql1="select * from sbname";
			db1.cleardata();
			this.DataGrid1.CurrentPageIndex=iPos;
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
		}

		private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
			this.DataGrid1.EditItemIndex=e.Item.ItemIndex;
			
			string sql1="select * from sbname";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
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
			string sql1="delete from sbname where 设备名称id="+e.Item.Cells[0].Text;
			db1.ExectueSQL("sbname",sql1);
			sql1="select * from sbname";
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string sql1="update sbname set 设备名称='"+((TextBox)e.Item.Cells[1].Controls[0]).Text+"'";
			sql1+=" where 设备名称id="+e.Item.Cells[0].Text;
			
			db1.ExectueSQL("sbname",sql1);

			sql1="select * from sbname";
			db1.cleardata();
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.EditItemIndex=-1;
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			this.DataGrid1.EditItemIndex=-1;
			
			string sql1="select * from sbname";
			db1.cleardata();
			this.DataGrid1.CurrentPageIndex=0;
			this.DataGrid1.EditItemIndex=-1;
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("add7.aspx");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			int iPos=0;
			string sql1="select * from sbname";
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			//Class1 db1=new Class1();
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.CurrentPageIndex=iPos;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			
			string sql1="select * from sbname";
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			//Class1 db1=new Class1();
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			
			string sql1="select * from sbname";
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			//Class1 db1=new Class1();
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.PageCount-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			
			string sql1="select * from sbname";
			//sql1+=Request.QueryString["name11"];
			//sql1+="'";
			//Class1 db1=new Class1();
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex+1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="sbname";
			this.DataGrid1.DataKeyField="设备名称id";
			this.DataGrid1.DataBind();
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void DataGrid1_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.Item||e.Item.ItemType==ListItemType.AlternatingItem||e.Item.ItemType==ListItemType.EditItem)
				((LinkButton)e.Item.Cells[e.Item.Cells.Count-1].Controls[0]).Attributes.Add("onclick","return confirm('确定删除吗？');");

		}
	}
}
