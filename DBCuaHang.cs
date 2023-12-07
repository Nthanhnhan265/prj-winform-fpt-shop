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
        /// Phương thức trả về DataTable thông qua tên Store Procedure 
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public static DataTable GetDataTableFromQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(sqlString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        
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
                            string propertyValue = property.GetValue(obj)?.ToString();
                            SqlDbType sqlDb = GetTypeOf(propertyValue); 
                            string parameterName = "@" + property.Name;
                            SqlParameter parameter = new SqlParameter(parameterName,sqlDb);
                            // Cắt hai ký tự đầu khỏi chuỗi khi nó không phải Char và gán cho parameter.value
                            if(sqlDb!=SqlDbType.Char)
                            {
                                parameter.Value = propertyValue.Substring(2); 
                            }
                            else
                            {
                                parameter.Value = propertyValue; 
                            }

                            sqlCommand.Parameters.Add(parameter);
                        }
                        sqlConnection.Open();
                        dong = sqlCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            SqlDbType sqlDb = GetTypeOf(propertyValue); 
                            string parameterName = "@" + property.Name;

                            SqlParameter parameter = new SqlParameter(parameterName, sqlDb);
                            // Cắt hai ký tự đầu khỏi chuỗi khi nó không phải Char và gán cho parameter.value
                            if (sqlDb != SqlDbType.Char)
                            {
                                parameter.Value = propertyValue.Substring(2);
                            }
                            else
                            {
                                parameter.Value = propertyValue;
                            }
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
        /// Tìm kiếm sản phẩm 
        /// </summary>
        /// <param name="spName">Store tìm kiếm</param>
        /// <param name="chuoiCanTim">Chuỗi cần tìm: mã, tên, thông tin .v.v.</param>
        /// <returns></returns>
        public static DataTable FindBy(string spName,string chuoiCanTim)
        {
            DataTable tb = new DataTable();
            try
            {
                using (SqlConnection sql=new SqlConnection(sqlString))
                {
                    using(SqlCommand command=new SqlCommand(spName,sql))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDbType type = GetTypeOf(chuoiCanTim);
                        SqlParameter parameter=new SqlParameter("@ChuoiCanTim", type);
                        if(chuoiCanTim.Contains("|"))
                        {
                            parameter.Value = chuoiCanTim.Substring(2); 

                        } else
                        {
                            parameter.Value = chuoiCanTim; 
                        }
                        command.Parameters.Add(parameter);
                        sql.Open(); 
                        using (SqlDataAdapter adapter =new SqlDataAdapter(command))
                        {
                            adapter.Fill(tb); 
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return tb; 
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
        /// <summary>
        /// Phương thức trả về chuỗi kiểu Date
        /// </summary>
        /// <param name="text">Chuỗi ngày tháng </param>
        /// <returns>chuỗi định dạng cho Date</returns>
        public static string ChangeToDate(string text )
        {
            return "D|" + text;
        }
        /// <summary>
        /// Lấy kiểu của giá trị truyền vào 
        /// </summary>
        /// <param name="value">Chuỗi giá trị </param>
        /// <returns>Kiểu của chuỗi trong DB</returns>
        static SqlDbType GetTypeOf(string value )
        {
            //kiểm tra nếu chuỗi là 
            if(value != null && value.StartsWith("N|")) {
                return SqlDbType.NVarChar; 
            }
            else if (value != null && value.StartsWith("D|"))
            {
                return SqlDbType.Date;
            }
            return SqlDbType.Char; 
        }
        /// <summary>
        /// Truyền vào thông tin đăng nhập và trả về toàn bộ thông tin nhân viên
        /// </summary>
        /// <param name="maNV">Mã nhân viên</param>
        /// <param name="password">Mật khẩu</param>
        /// <param name="quyenHan">Quyền hạn</param>
        /// <returns>thông tin của nhân viên hoặc null</returns>
        public static NhanVien DangNhap(string maNV, string password, string quyenHan)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(sqlString))
                {
                    using (SqlCommand cmd=new SqlCommand("sp_DangNhap",sql))
                    {
                        cmd.CommandType=CommandType.StoredProcedure;
                        SqlParameter parameterMa = new SqlParameter("@MaNV", maNV); 
                        cmd.Parameters.Add(parameterMa);
                        SqlParameter parameterPass = new SqlParameter("@Password", password);
                        cmd.Parameters.Add(parameterPass);
                        SqlParameter parameterQuyen = new SqlParameter("@QuyenHan", SqlDbType.NVarChar);
                        parameterQuyen.Value = quyenHan;
                        cmd.Parameters.Add(parameterQuyen);

                        sql.Open();
                        using (SqlDataReader dr=cmd.ExecuteReader())
                        {
                            if(dr.HasRows)
                            {
                                // Có dòng khớp, xử lý dữ liệu hoặc trả về thông tin NhanVien
                                dr.Read();
                                // Lấy giá trị từ cột nào đó trong dòng đó (ví dụ: reader["TenNhanVien"])
                                // Nếu muốn trả về một đối tượng NhanVien, bạn có thể tạo một đối tượng và gán giá trị từ reader cho các thuộc tính tương ứng
                                NhanVien nhanVien = new NhanVien();
                                nhanVien.MaNV = dr["MaNV"].ToString().Trim();
                                nhanVien.HoTen = dr["HoTen"].ToString().Trim(); 
                                nhanVien.NgaySinh= dr["NgaySinh"].ToString().Trim();
                                nhanVien.DiaChi= dr["DiaChi"].ToString().Trim();
                                nhanVien.GioiTinh= dr["GioiTinh"].ToString().Trim();
                                nhanVien.CCCD= dr["CCCD"].ToString().Trim();
                                nhanVien.SDT= dr["SDT"].ToString().Trim();
                                nhanVien.MaCH= dr["MaCH"].ToString().Trim();
                                nhanVien.QuanLy= dr["QuanLy"].ToString().Trim();
                                nhanVien.MatKhau= dr["MatKhau"].ToString().Trim();
                                nhanVien.QuyenHan= dr["QuyenHan"].ToString().Trim();
                                nhanVien.Email= dr["Email"].ToString().Trim();
                                return nhanVien;


                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }


        }
    }
}
