﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailPOS.CommonLayer.DataTransferObjects.Order;

namespace RetailPOS.BusinessLayer.Service.Order
{
   public interface IOrderService
    {
        /// <summary>
        /// Save Order details in database
        /// </summary>
        /// <param name="orderDetails">ordermaster object to be saved</param>
        /// <returns>returns boolean value indicating if the records are saved in database</returns>
       bool SaveOrderDetail(OrderMasterDTO orderDetail);
     
    }
}
