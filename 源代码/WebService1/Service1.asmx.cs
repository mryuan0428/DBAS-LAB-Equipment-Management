using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;


namespace WebService1
{
	/// <summary>
	/// Service1 的摘要说明。
	/// </summary>
	
	public class Service1 : System.Web.Services.WebService
	{
		public Service1()
		{
			//CODEGEN: 该调用是 ASP.NET Web 服务设计器所必需的
			InitializeComponent();
		}
		//CSNode *p1;
		

		#region 组件设计器生成的代码
		
		//Web 服务设计器所必需的
		private IContainer components = null;
				
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{

		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		// WEB 服务示例
		// HelloWorld() 示例服务返回字符串 Hello World
		// 若要生成，请取消注释下列行，然后保存并生成项目
		// 若要测试此 Web 服务，请按 F5 键

//		[WebMethod]
//		public string HelloWorld()
//		{
//			return "Hello World";
//		}
		
		
		public CSNode CreateTree()
		{
			//DateTime d1=DateTime.Parse(start);
			//DateTime d2=DateTime.Parse(end);
			CSNode n1=new CSNode();
			CSNode n2=new CSNode();
			
			Class1 db1=new Class1();
			n1=n1.SetData("类别");
			CSNode n3=new CSNode();
			/*this.n2=n3.SetData("七喜");
			this.n1.AddChild(this.n2);
			n3=new CSNode();
			n3=n3.SetData("清华同方");
			this.n2=this.n2.AddSibling(n3);

			n3=new CSNode();
			n3=n3.SetData("方正");
			this.n2=this.n2.GetSibling();
			this.n2=this.n2.AddSibling(n3);*/
			string sql;
			sql="select * from sbname";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql);

			for(int i=0;i<db1.getdata().Tables["sbname"].Rows.Count;i++)
			{
				n3=new CSNode();
				n3=n3.SetData(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString());
				if(i==0)
				{
					n1.AddChild(n3);
					n2=n1.GetChild();
				}
				else
				{
					n2.AddSibling(n3);
					n2=n2.GetSibling();
				}
			}

			sql="select * from changjia";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql);

			n2=n1.GetChild();
			CSNode n4=new CSNode();
			CSNode n5=new CSNode();
			while(n2!=null)
			{
				for(int i=0;i<db1.getdata().Tables["changjia"].Rows.Count;i++)
				{
					n4=new CSNode();
					n5=new CSNode();
					n5=n5.SetData("0");
					n4=n4.SetData(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString());
					n4=n4.AddChild(n5);
					if(i==0)
					{
						n2.AddChild(n4);
						n3=n2.GetChild();
					}
					else if(i==1)
						n3.AddSibling(n4);
					else
					{
						n3=n3.GetSibling();
						n3.AddSibling(n4);
					}
				}
				n2=n2.GetSibling();
			}

			return n1;
		}
		[WebMethod]
		public string guzhangtime(string sb,string cj)
		{
			string s;
			CSNode n1=new CSNode();
			CSNode n2=new CSNode();
			CSNode n3=new CSNode();
			CSNode n4=new CSNode();
			Class1 db1=new Class1();
			Class1 db2=new Class1();
			n1=CreateTree();
			n2=n1.GetChild();
			string sql="select * from info where 设备id is not null order by 设备id,登记日期";
			db1.cleardata();
			db1.ExectueSQL("info",sql);

			int num1=0;
			string sbid="";
			sbid=db1.getdata().Tables["info"].Rows[0]["设备id"].ToString();
			for(int i=0;i<db1.getdata().Tables["info"].Rows.Count;i++)
			{
				string sbid1=db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				if(i!=0&&sbid1==sbid)
					continue;
				sql="select * from basicinfo where 设备id="+db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				db2.cleardata();
				db2.ExectueSQL("basicinfo",sql);

				sql="select * from changjia where 厂家id="+db2.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
				db2.ExectueSQL("changjia",sql);

				sql="select * from sbname where 设备名称id="+db2.getdata().Tables["basicinfo"].Rows[0]["设备名称id"].ToString();
				db2.ExectueSQL("sbname",sql);

				n4=Traverse1(n2,db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim());
				n4=n4.GetChild();
				n3=Traverse1(n4,db2.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString().Trim());
				n3=n3.GetChild();
				/*DateTime dt1=DateTime.Parse(db1.getdata().Tables["info"].Rows[i]["登记日期"].ToString());
				DateTime dt2=DateTime.Parse(db2.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString());
				int year=dt1.Year-dt2.Year;
				int month=dt1.Month-dt2.Month;
				int day=dt1.Day-dt2.Day;*/
				
				int num=Int32.Parse(n3.GetData().ToString());
				TimeSpan t=DateTime.Parse(db1.getdata().Tables["info"].Rows[i]["登记日期"].ToString())-DateTime.Parse(db2.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString());

				num=num+Int32.Parse(t.TotalDays.ToString());

				n3=n3.SetData(num.ToString());
				if(db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim()==sb.Trim()&&db2.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString().Trim()==cj.Trim())
					num1++;
				sbid=db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
			}
			//s=Traverse1(this.n2,"七喜");
			
			n2=this.Traverse1(n2,sb);
			n2=n2.GetChild();

			n2=Traverse1(n2,cj);
			if(num1!=0)
			{
				int pass=Int32.Parse(n2.GetChild().GetData())/num1;
				int year=pass/365;
				int month=(pass%365)/31;
				int day=pass-year*365-month*31;
				s=year.ToString()+"年"+month.ToString()+"月"+day.ToString()+"日";
			}
			else
				s="";
			//s=bit.ToString();
			return s;

		}
		[WebMethod]
		public string gzttwo(string sb,string cj,string cishu)
		{
			string s;
			CSNode n1=new CSNode();
			CSNode n2=new CSNode();
			CSNode n3=new CSNode();
			CSNode n4=new CSNode();
			Class1 db1=new Class1();
			Class1 db2=new Class1();
			n1=CreateTree();
			n2=n1.GetChild();
			string sql="select * from info where 设备id in (select 设备id from info group by 设备id having count(*)>"+cishu+") order by 设备id,登记日期";

			db1.cleardata();
			db1.ExectueSQL("info",sql);

			int num1=0;
			int num2=0;
			DateTime t2=new DateTime(1900,1,1);
			string sbid="";
			string sbid1="";
			sbid=db1.getdata().Tables["info"].Rows[0]["设备id"].ToString();
			for(int i=0;i<db1.getdata().Tables["info"].Rows.Count;i++)
			{
				sbid1=db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				if(sbid!=sbid1)
				{
					num2=0;
					sbid=db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				}
				num2++;
				
				if(num2==Int32.Parse(cishu))
					t2=DateTime.Parse(db1.getdata().Tables["info"].Rows[i]["登记日期"].ToString());
				if(num2!=Int32.Parse(cishu)+1)
					continue;
				sql="select * from basicinfo where 设备id="+db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				db2.cleardata();
				db2.ExectueSQL("basicinfo",sql);

				sql="select * from changjia where 厂家id="+db2.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
				db2.ExectueSQL("changjia",sql);

				sql="select * from sbname where 设备名称id="+db2.getdata().Tables["basicinfo"].Rows[0]["设备名称id"].ToString();
				db2.ExectueSQL("sbname",sql);

				n4=Traverse1(n2,db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim());
				n4=n4.GetChild();
				n3=Traverse1(n4,db2.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString().Trim());
				n3=n3.GetChild();
				/*DateTime dt1=DateTime.Parse(db1.getdata().Tables["info"].Rows[i]["登记日期"].ToString());
				DateTime dt2=DateTime.Parse(db2.getdata().Tables["basicinfo"].Rows[0]["出厂日期"].ToString());
				int year=dt1.Year-dt2.Year;
				int month=dt1.Month-dt2.Month;
				int day=dt1.Day-dt2.Day;*/
				
				int num=Int32.Parse(n3.GetData().ToString());
				TimeSpan t=DateTime.Parse(db1.getdata().Tables["info"].Rows[i]["登记日期"].ToString())-t2;

				num=num+Int32.Parse(t.TotalDays.ToString());

				n3=n3.SetData(num.ToString());
				if(db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim()==sb.Trim()&&db2.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString().Trim()==cj.Trim())
					num1++;
			}
			//s=Traverse1(this.n2,"七喜");
			
			n2=this.Traverse1(n2,sb);
			n2=n2.GetChild();

			n2=Traverse1(n2,cj);
			if(num1!=0)
			{
				int pass=Int32.Parse(n2.GetChild().GetData())/num1;
				int year=pass/365;
				int month=(pass%365)/31;
				int day=pass-year*365-month*31;
				s=year.ToString()+"年"+month.ToString()+"月"+day.ToString()+"日";
			}
			else
				s="";
			//s=bit.ToString();
			return s;

		}
		[WebMethod]
		public string guzhanglv(string sb,string start,string end)
		{
			string s;
			CSNode n1=new CSNode();
			CSNode n2=new CSNode();
			CSNode n3=new CSNode();
			CSNode n4=new CSNode();
			Class1 db1=new Class1();
			Class1 db2=new Class1();
			n1=CreateTree();
			n2=n1.GetChild();
			string sql="select 设备id from info where 登记日期 between '"+start+"' and '"+end+"' and 设备id is not null";
			db1.cleardata();
			db1.ExectueSQL("info",sql);

			int num1=0;
			for(int i=0;i<db1.getdata().Tables["info"].Rows.Count;i++)
			{
				sql="select * from basicinfo where 设备id="+db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				db2.cleardata();
				db2.ExectueSQL("basicinfo",sql);

				sql="select * from changjia where 厂家id="+db2.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
				db2.ExectueSQL("changjia",sql);

				sql="select * from sbname where 设备名称id="+db2.getdata().Tables["basicinfo"].Rows[0]["设备名称id"].ToString();
				db2.ExectueSQL("sbname",sql);

				if(db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim()==sb)
					num1++;
				n4=Traverse1(n2,db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim());
				n4=n4.GetChild();
				n3=Traverse1(n4,db2.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString().Trim());
				n3=n3.GetChild();
				int num=Int32.Parse(n3.GetData().ToString());
				num++;
				n3=n3.SetData(num.ToString());
			}
			//s=Traverse1(this.n2,"七喜");
			
			n2=this.Traverse1(n2,sb);
			n2=n2.GetChild();
			//this.n2=this.Traverse1(this.n2,cj);
			//this.n2=this.n2.GetChild();

			/*sql="select * from basicinfo where 设备名称id=";
			string sql1="select * from sbname where 设备名称='"+sb+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);

			sql+=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();
			//sql+=" and 厂家id=";
					
			/*sql1="select * from changjia where 厂家名称='"+cj+"'";
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlDataAdapter1.SelectCommand.CommandText=sql1;
			this.sqlConnection1.Open();
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			this.dataSet11.Clear();
			this.sqlDataAdapter1.Fill(this.dataSet11,"changjia");

			sql+=this.dataSet11.Tables["changjia"].Rows[0]["厂家id"].ToString();

			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql);*/

			double bit=0.0;
			s="";
			if(num1!=0)
			{
				while(n2!=null)
				{
					s+=n2.GetData()+":";
					bit=Double.Parse(n2.GetChild().GetData().ToString())/num1*100.0;
					s+=string.Format("{0:F2}",bit)+"%\n";
					n2=n2.GetSibling();
				}
			}
			else
				bit=0.0;
			//s=bit.ToString();
			return s;
		}
		[WebMethod]
		public string bilv(string sb,string start,string end)
		{
			string s;
			CSNode n1=new CSNode();
			CSNode n2=new CSNode();
			CSNode n3=new CSNode();
			CSNode n4=new CSNode();
			Class1 db1=new Class1();
			Class1 db2=new Class1();
			n1=CreateTree();
			n2=n1.GetChild();
			string sql="select distinct 设备id from info where 登记日期 between '"+start+"' and '"+end+"' and 设备id is not null";
			db1.cleardata();
			db1.ExectueSQL("info",sql);

			int num1=0;
			for(int i=0;i<db1.getdata().Tables["info"].Rows.Count;i++)
			{
				sql="select * from basicinfo where 设备id="+db1.getdata().Tables["info"].Rows[i]["设备id"].ToString();
				db2.cleardata();
				db2.ExectueSQL("basicinfo",sql);

				sql="select * from changjia where 厂家id="+db2.getdata().Tables["basicinfo"].Rows[0]["厂家id"].ToString();
				db2.ExectueSQL("changjia",sql);

				sql="select * from sbname where 设备名称id="+db2.getdata().Tables["basicinfo"].Rows[0]["设备名称id"].ToString();
				db2.ExectueSQL("sbname",sql);

				if(db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim()==sb)
					num1++;
				n4=Traverse1(n2,db2.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString().Trim());
				n4=n4.GetChild();
				n3=Traverse1(n4,db2.getdata().Tables["changjia"].Rows[0]["厂家名称"].ToString().Trim());
				n3=n3.GetChild();
				int num=Int32.Parse(n3.GetData().ToString());
				num++;
				n3=n3.SetData(num.ToString());
			}
			//s=Traverse1(this.n2,"七喜");
			
			n2=this.Traverse1(n2,sb);
			n2=n2.GetChild();

			double bit=0.0;
			s="";

			while(n2!=null)
			{
				sql="select * from 基本信息 where 厂家名称='"+n2.GetData()+"'";
				sql+=" and 设备名称='"+sb+"'";
				db1.cleardata();
				db1.ExectueSQL("changjia",sql);

				s+=n2.GetData()+":";
				num1=db1.getdata().Tables["changjia"].Rows.Count;
				if(num1!=0)
                    bit=float.Parse(n2.GetChild().GetData().ToString())/num1*100.0;
				else
					bit=0.0;
				
				s+=String.Format("{0:F2}",bit)+"%\n";
				n2=n2.GetSibling();
			}
			//s=bit.ToString();
			return s;
		}
		//[WebMethod]
		public CSNode Traverse1(CSNode n1,String e)
		{
			if(n1!=null)
			{
				while(n1.GetData().Trim()!=e.Trim()&&n1.GetSibling()!=null)
				{
					//this.label1.Text=this.n1.GetData().ToString();
					n1=n1.GetSibling();
				}
			}
			if(n1.GetData().Trim()==e.Trim())
			return n1;
			else
				return null;
		}
		[WebMethod]
		public LinkList Time(string sb)
		{
			Class1 db1=new Class1();
			LinkList l=new LinkList();
			DateTime dt=DateTime.Now;
			int year=Int32.Parse(dt.Year.ToString())-1;
			int month=Int32.Parse(dt.Month.ToString());
			int num=0;
			string sql="select * from changjia";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql);

			int max=db1.getdata().Tables["changjia"].Rows.Count;
			string []cjname=new string[max];
            
			for(int i=0;i<max;i++)
			{
				cjname[i]=db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString();
			}
			
			int month1=month;
			int year1=year;
			bool ifadd=false;
			int num1=0;
			int first=0;

			for(int i=0;i<max;i++)
			{
				year=year1;
				ifadd=false;
				num1=0;
				for(int j=0;j<12;j++)
				{
					num=0;
					
					month=month1+j;
					if(month>12)
					{
						month=month-12;
						if(!ifadd)
						{
							year=year+1;
							ifadd=true;
						}
					}
					string date1;
					string date=year.ToString()+"-"+month.ToString()+"-1";
					if(month==1||month==3||month==5||month==7||month==8||month==10||month==12)
						date1=year.ToString()+"-"+month.ToString()+"-31";
					else if(month==4||month==6||month==9||month==11)
						date1=year.ToString()+"-"+month.ToString()+"-30";
					else if((year%4==0&&year%100!=0)||(year%400==0))
						date1=year.ToString()+"-"+month.ToString()+"-29";
					else
						date1=year.ToString()+"-"+month.ToString()+"-28";
					sql="select * from 维护 where 登记日期 between '"+date+"' and '"+date1+"' and 设备名称='"+sb+"' and 厂家名称='"+cjname[i].Trim()+"'";
					db1.cleardata();
					db1.ExectueSQL("维护",sql);

					if(db1.getdata().Tables["维护"].Rows.Count!=0)
						num=db1.getdata().Tables["维护"].Rows.Count;
					if(j==6)
						first=num;
					if(j>=6)
					num1+=num;
					LNode p=new LNode();
					p.SetData(num.ToString());
					l=l.Add(p);
				}
				LNode p1=new LNode();
				p1.SetData((num1/6).ToString());
				l=l.Add(p1);
				p1=new LNode();
				p1.SetData(((num1-first+num1/6)/6).ToString());
				l=l.Add(p1);
			}
			return l;
		}

		
		
	}
	public class CSNode
	{
		String data;
		CSNode firstchild;
		CSNode nextsibling;

		public CSNode()
		{
			firstchild=null;
			nextsibling=null;
		}
		public CSNode AddChild(CSNode n2)
		{
			firstchild=n2;
			return this;
		}
		public CSNode AddSibling(CSNode n2)
		{
			nextsibling=n2;
			return this;
		}
		public CSNode SetData(String e)
		{
			data=e;
			return this;
		}
		public String GetData()
		{
			return this.data;
		}
		public CSNode GetChild()
		{
			return this.firstchild;
		}
		public CSNode GetSibling()
		{
			return this.nextsibling;
		}
	}
	public class LNode
	{
		public string data;
		public LNode next;
		public LNode()
		{}
		public LNode SetData(string e)
		{
			data=e;
			return this;
		}
		public string GetData()
		{
			return this.data;
		}
		public LNode GetNext()
		{
			return this.next;
		}
	}
	public class LinkList
	{
		public LNode first;
		public LinkList()
		{
			first=new LNode();
			first.data="";
			first.next=null;
		}
		public LinkList Add(LNode p)
		{
			p.next=first.next;
			first.next=p;
			return this;
		}
	}
}
