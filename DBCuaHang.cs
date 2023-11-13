using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop
{
    internal class DBCuaHang
    {
        public static string sqlString=null; 
        public DBCuaHang(string sql)
        {
            if(sqlString==null)
            {
                sqlString = sql;
            }
        }
        public DBCuaHang()
        {

        }
        /// <summary>
        /// Phương thức trả về DataTable thông qua tên Store Procedure 
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string spName)
        {
            DataTable dt = new DataTable() ;
            using (SqlConnection sqlConnection = new SqlConnection(sqlString))
            {
                using (SqlCommand sqlCommand=new SqlCommand(spName,sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure; 

                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có Lỗi xảy ra: \n{ex}","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                    }
                }

            }
            return dt; 
        }
        /// <summary>
        /// Thêm 1 dòng vào Table trong DB 
        /// </summary>
        /// <param name="spName">Tên store procedure</param>
        /// <param name="obj">Đối tượng</param>
        /// <returns>Số dòng được thêm</returns>
        public int AddRowData(string spName,Object obj)
        {
            int dong = 0;
            using (SqlConnection sqlConnection = new SqlConnection(sqlString))
            {
                using (SqlCommand sqlCommand=new SqlCommand(spName,sqlConnection))
                {
                    try
                    {
                        sqlCommand.CommandType=CommandType.StoredProcedure; 
                        // Xác định kiểu của đối tượng
                        Type type = obj.GetType();
                        // Lấy danh sách các thuộc tính
                        PropertyInfo[] properties = type.GetProperties();
                        // Thêm các thuộc tính vào câu truy vấn
                        foreach (PropertyInfo property in properties)
                        {
                            SqlParameter parameter = new SqlParameter("@" + property.Name, property.GetValue(obj));
                            sqlCommand.Parameters.Add(parameter);
                        }
                        sqlConnection.Open();
                        dong = sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                   
                }
            }
            return dong;
        }  
    }
}
