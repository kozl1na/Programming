using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Категории статуса заказов.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Заказ в процессе выполнения.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается.
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ выслан.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Заказ возвращен.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ Отменён.
        /// </summary>
        Abandoned 
    }
}
