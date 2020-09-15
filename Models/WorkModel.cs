using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PushGithub.Models
{
    public class WorkModel
    {
        /// <summary>
        /// ID
        /// </summary>
        [DataMember]
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        /// <summary>
        /// 作品名稱
        /// </summary>
        [DataMember]
        [JsonPropertyName("WORK_NAME")]
        public string WORK_NAME { get; set; }

        /// <summary>
        /// 作品描述
        /// </summary>
        [DataMember]
        [JsonPropertyName("DESCRIPTION")]
        public string DESCRIPTION { get; set; }

        /// <summary>
        /// 作品完成日期
        /// </summary>
        [DataMember]
        [JsonPropertyName("FINISH_DATE")]
        public string FINISH_DATE { get; set; }
    }
}
