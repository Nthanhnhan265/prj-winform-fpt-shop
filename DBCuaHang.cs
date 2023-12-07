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
    static class DBCuaHang
    {
        public static string sqlString = null;

        /// <summary>
        /// Phương thức trả về DataTable thông qua tên Store Procedure 
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string spName)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(sqlString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlConnection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dt);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }
        /// <summary>
        /// Thêm 1 dòng vào Table trong DB 
        /// </summary>
        /// <param name="spName">Tên store procedure</param>
        /// <param name="obj">Đối tượng</param>
        /// <returns>Số dòng được thêm</returns>
        public static int AddRowData(string spName, Object obj)
        {
            int dong = 0;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(sqlString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        // Xác định kiểu của đối tượng
                        Type type = obj.GetType();
                        // Lấy danh sách các thuộc tính
                        PropertyInfo[] properties = type.GetProperties();
                        // Thêm các thuộc tính vào câu truy vấn
                        foreach (PropertyInfo property in properties)
                        {
                            //Kiểm tra xem giá trị đã đánh dấu N| được hiểu là Nvarchar 
                            string propertyValue = property.GetValue(obj)?.ToString();
                            bool isNvarchar = propertyValue != null && propertyValue.StartsWith("N|");
                            string parameterName = "@" + property.Name;
                            SqlParameter parameter = new SqlParameter(parameterName, isNvarchar ? SqlDbType.NVarChar : SqlDbType.VarChar);
                            // Thay "N|" khỏi chuỗi
                            parameter.Value = isNvarchar ? propertyValue.Replace("N|", "") : propertyValue;
                            sqlCommand.Parameters.Add(parameter);
                        }
                        sqlConnection.Open();
                        dong = sqlCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dong;
            }
        /// <summary>
        /// Phương thức xóa các bảng trong DB 
        /// </summary>
        /// <param name="spName">Tên store procedure</param>
        /// <param name="maCanXoa">Mã của bảng cần xóa, trường hợp xóa bảng tồn kho thì phải truyền 2 tham số</param>
        /// <returns>True hoặc False</returns>
        public static bool DelRowData(string spName, params string[] maCanXoa)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(sqlString))
                {
                    using (SqlCommand SqlCommand = new SqlCommand(spName, sql))
                    {
                        SqlCommand.CommandType = CommandType.StoredProcedure;
                        if (maCanXoa.Length == 1)
                        {
                            SqlCommand.Parameters.AddWithValue("@MaCanXoa", maCanXoa[0]);
                        }
                        else if (maCanXoa.Length == 2)
                        {
                            SqlCommand.Parameters.AddWithValue("@MaCHCanXoa", maCanXoa[0]);
                            SqlCommand.Parameters.AddWithValue("@MaSPCanXoa", maCanXoa[1]);

                        }
                        sql.Open();

                        SqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Phương thức cập nhật dữ liệu cho bảng trong DB 
        /// </summary>
        /// <param name="spName">Tên store procedure</param>
        /// <param name="obj">Đối tượng truyền vào có các field giống với DB</param>
        /// <returns>Số dòng ảnh hưởng</returns>
        public static int UpdateRowData(string spName, Object obj)
        {
            int soDong = 0;
            try
            {
                using (SqlConnection sql = new SqlConnection(sqlString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(spName, sql))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        // Xác định kiểu của đối tượng
                        Type type = obj.GetType();
                        // Lấy danh sách các thuộc tính
                        PropertyInfo[] properties = type.GetProperties();
                        // Thêm các thuộc tính vào câu truy vấn
                        foreach (PropertyInfo property in properties)
                        {
                            //Kiểm tra xem giá trị đã đánh dấu N| được hiểu là Nvarchar 
                            string propertyValue = property.GetValue(obj)?.ToString();
                            bool isNvarchar = propertyValue != null && propertyValue.StartsWith("N|");
                            string parameterName = "@" + property.Name;

                            SqlParameter parameter = new SqlParameter(parameterName, isNvarchar ? SqlDbType.NVarChar : SqlDbType.VarChar);
                            // Thay "N|" khỏi chuỗi
                            parameter.Value = isNvarchar ? propertyValue.Replace("N|", "") : propertyValue;
                            sqlCommand.Parameters.Add(parameter);
                        }
                        sql.Open();
                        soDong = sqlCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            return soDong;
        }

        /// <summary>
        /// Phương thức trả về chuỗi kiểu nvarchar
        /// </summary>
        /// <param name="text">Chuỗi truyền vào. ví dụ: "abc" </param>
        /// <returns>Trả về chuỗi được gắn kí tự để định dạng nvarchar, ví dụ "N|abc"</returns>
        public static string GetNvarcharText(string text)
        {
            return "N|" + text;
        }
    }
}
