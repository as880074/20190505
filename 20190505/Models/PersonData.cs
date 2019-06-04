using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20190505.Models
{
    /// <summary>
    /// 輸入人資料
    /// </summary>
    public class PersonData
    {
        /// <summary>
        /// 使用者姓名
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 使用者性別
        /// </summary>
        public string PersonSex { get; set; }
        /// <summary>
        /// 使用者電話號碼
        /// </summary>
        public string PersonMobile { get; set; }
    }
}