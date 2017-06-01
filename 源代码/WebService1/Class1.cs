using System;

namespace WebService1
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	public class Class1
	{
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.DataSet dataSet11;
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
		public void ExectueSQL(string tb,string sql)
		{
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlDataAdapter1.SelectCommand.CommandText=sql;
			this.sqlConnection1.Open();
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			if(tb!="")
			this.sqlDataAdapter1.Fill(this.dataSet11,tb);
		}
		public void cleardata()
		{
			this.dataSet11.Clear();
		}
		public System.Data.DataSet getdata()
		{
			return this.dataSet11;
		}
	}
}
