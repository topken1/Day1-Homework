using System;

namespace Day1_Homework
{
    /// <summary>
    /// 商品
    /// </summary>
    [Serializable]
    public class Product
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 成本
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// 營業收入
        /// </summary>
        public int Revenue { get; set; }
        /// <summary>
        /// 售價
        /// </summary>
        public int SellPrice { get; set; }
    }
}
