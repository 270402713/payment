using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataRetailDmQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataRetailDmQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 店面DM营销数据，包括商品的PV、UV、曝光。
        /// </summary>
        [JsonProperty("dm_marketing_datas")]
        public List<DmActivityShopData> DmMarketingDatas { get; set; }

        /// <summary>
        /// 商品码
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }
    }
}