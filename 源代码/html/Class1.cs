using System;

namespace html
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	public class Class1
	{
		protected System.Data.SqlClient.SqlConnection sqlConnection1;  //表示sql server数据库的一个打开的连接
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;  //表示用于填充System.Data.DataSet和更新SQL Server的一组数据库命令和数据库连接。
		protected System.Data.DataSet dataSet11;  //表示数据在内存中的缓存。
		public Class1()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
			string sqlconn; 
			sqlconn="server=4CJF-ZUOYE;uid=db1;pwd=123;database=jfgl";
			this.sqlConnection1=new System.Data.SqlClient.SqlConnection(sqlconn);
            this.sqlDataAdapter1=new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDataAdapter1.SelectCommand=new System.Data.SqlClient.SqlCommand();
			this.dataSet11=new System.Data.DataSet();
		}
		public void ExectueSQL(string tb,string sql)   //执行SQL语句
		{
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlDataAdapter1.SelectCommand.CommandText=sql;
			this.sqlConnection1.Open();  //打开数据库连接。
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();  //对连接执行T-SQL语句并返回受影响的函数。
			this.sqlConnection1.Close(); //关闭与数据库的连接。

			if(tb!="")
			this.sqlDataAdapter1.Fill(this.dataSet11,tb);
		}
		public void cleardata()    //清除记录集
		{
			this.dataSet11.Clear();  //通过移除所有表中的所有行来清除数据System.Data.DataSet.
		}
		public System.Data.DataSet getdata()   //获取记录集函数，想获取保护成员DataSet，所以必须建立一个对外的借口可以取到
		{
			return this.dataSet11;  
		}
		public System.Data.SqlClient.SqlConnection getsql()
		{
			return this.sqlConnection1;
		}
	}
}
