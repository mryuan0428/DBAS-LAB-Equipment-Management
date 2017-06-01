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
	public class Basicinfo : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;  //数据绑定列表控件，在表中显示来自数据源的项
		protected System.Web.UI.WebControls.Button Button1;      //在web页上显示的普通按钮
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button5;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;  //下拉列表框
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;   //显示图像并对图像上的鼠标单击有响应
		protected System.Web.UI.HtmlControls.HtmlInputHidden Hidden1;  //允许编程访问服务器上的〈input type=hidden〉项，hidden用于记录该执行那条SQL语句的值，若用变量，总会初始化为最初的值。
			
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			
			db1=new Class1();       //连接数据库,调用数据库连接类
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			string sql="select * from admin where username='";
			sql+=name;
			sql+="' and password='";
			sql+=id;
			sql+="'";
			db1.cleardata();
			db1.ExectueSQL("admin",sql);

			if(db1.getdata().Tables["admin"].Rows.Count==0)    //判断用户权限
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
			
			BoundColumn b1=new BoundColumn(); //绑定到数据源中的字段DataGrid控件的列类型
			b1.DataField="设备id";    //获取或设置要绑定到BoundColumn的数据源的名称。
			b1.ReadOnly=true;         //获取一个设置的值，该值指示是否可编辑BoundColumn中的项
			b1.HeaderText="设备id";   //获取在列的页眉中显示的文本。
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
			
			HyperLinkColumn h1=new HyperLinkColumn();  //DataGrid的列类型，包含列中每一项的超级链接
			h1.DataNavigateUrlField="设备id";   //获取数据源中要绑定到HyperLinkColumn中的超级链接的URL的字段，此处为设id字段。
			h1.DataNavigateUrlFormatString="edit2.aspx?id={0}"; //获取或设置当 URL 数据绑定到数据源中的字段时，HyperLinkColumn 中的超链接的 URL 的显示格式。 

			h1.Text="修改";  
			this.DataGrid1.Columns.Add(h1);

			ButtonColumn bc1=new ButtonColumn();
			bc1.Text="删除";
			bc1.CommandName="Delete";
			this.DataGrid1.Columns.Add(bc1);
				
			//this.DataGrid1.PageCount=pagecount;
			//this.DataGrid1.Columns[13].HeaderText="1";
			//this.DataGrid1.Columns[13].DataField="设备编号";
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
			this.DataGrid1.DataBind();      //将控件绑定到DataSource属性指定的数据源
			
			if(this.DataGrid1.PageCount==1)   //如果分页页码为最后一页，则下一页和尾页为不可用
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
			this.DropDownList3.SelectedIndexChanged += new System.EventHandler(this.DropDownList3_SelectedIndexChanged);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.DataGrid1.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGrid1_ItemCreated);
			this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)   //添加新的设备按钮
		{
			Response.Redirect("add3.aspx");
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)  //页码改变后所触发的事件
		{
			int iPos=e.NewPageIndex;  //获取用户在datagrid页选择元素中选定的页索引
			string sql1;
			if(this.Hidden1.Value.Trim()=="0")     //去掉字符串左右两端的空格符
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
			this.DataGrid1.DataSource=db1.getdata();  //返回或设置一个数据源，通过该数据源用于填充控件中的项的值列表
			this.DataGrid1.DataMember="基本信息";     //获取或设置多成员数据源中要绑定到数据列表控件中的特定数据成员
			this.DataGrid1.DataKeyField="设备id";     //获取由DataSource属性指定的数据源中的键字段。
			this.DataGrid1.DataBind();
		}

		private void DataGrid1_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)  //DataGrid中删除数据的函数
		{
			string name=Session["name"].ToString(); //获取ASP.NET提供的当前Session对象
			string id=Session["pwd"].ToString();

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
					Response.Redirect("cuowu3.htm");           //未登录
				else
					Response.Redirect("cuowu2.htm");           //用户，没有删除数据权限
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
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void Button2_Click(object sender, System.EventArgs e)    //首页按钮
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
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
		}

		private void Button3_Click(object sender, System.EventArgs e)     //上一页按钮
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
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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

		private void Button4_Click(object sender, System.EventArgs e)      //下一页按钮
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
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.CurrentPageIndex+1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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

		private void Button5_Click(object sender, System.EventArgs e)     //尾页按钮
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
			
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql1);
			
			this.DataGrid1.CurrentPageIndex=this.DataGrid1.PageCount-1;
			
			//this.DataGrid1.Load;
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
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

		private void DropDownList3_SelectedIndexChanged(object sender, System.EventArgs e)    //实验室名称
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
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			this.Hidden1.Value="1";
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)    //设备编号
		{
			string sql="select * from 基本信息 where 实验室名='"+this.DropDownList3.SelectedValue.Trim()+"'";
			
			sql+=" and 设备编号='"+this.DropDownList4.SelectedValue.Trim()+"'";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);
			this.DataGrid1.CurrentPageIndex=0;   //获取当前显示页的索引项
			this.DataGrid1.DataSource=db1.getdata();
			this.DataGrid1.DataMember="基本信息";
			this.DataGrid1.DataKeyField="设备id";
			this.DataGrid1.DataBind();
			
			if(this.DataGrid1.CurrentPageIndex==this.DataGrid1.PageCount-1)
				this.Button4.Enabled=false;
			else
				this.Button4.Enabled=true;
			if(this.DataGrid1.CurrentPageIndex==0)
				this.Button3.Enabled=false;
			else
				this.Button3.Enabled=true;
			this.Hidden1.Value="2";
		}

		private void DataGrid1_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)  //弹出确认删除对话框
		{
			if(e.Item.ItemType==ListItemType.Item||e.Item.ItemType==ListItemType.AlternatingItem||e.Item.ItemType==ListItemType.EditItem)
				((LinkButton)e.Item.Cells[e.Item.Cells.Count-1].Controls[0]).Attributes.Add("onclick","return confirm('确定删除吗？');");

		}
	}
}
