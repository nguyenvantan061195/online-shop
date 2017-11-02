using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Helper
{
    /// <summary>
    /// Đối tượng đóng gói các thông báo khi thêm, sửa, xóa...
    /// </summary>
    /// <modified>
    /// Author				    created date					comments
    /// TanNV					02/11/2017  			        Tạo mới
    ///</modified>
    ///
    [Serializable]
    public class JMessage
    {
        /// <summary>
        /// ID của bản ghi được thêm, sửa, xóa
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Thông báo
        /// </summary>
        public string Title { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// Có lỗi hay không có lỗi
        /// </summary>
        public bool Error { get; set; }
        /// <summary>
        /// Đối tượng attach kèm theo thông báo
        /// </summary>
        public object Object { get; set; }
        public JMessage(int id, string title, bool error, object obj)
        {
            ID = id; Title = title; Error = error; Object = obj;
        }
        public JMessage()
        {

        }
    }
}
