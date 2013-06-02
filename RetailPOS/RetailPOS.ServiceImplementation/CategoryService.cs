﻿#region Using directives

using System.Collections.Generic;
using RetailPOS.BusinessLayer.Service.Admin;
using RetailPOS.CommonLayer.DataTransferObjects;
using RetailPOS.CommonLayer.Unity;

#endregion

namespace RetailPOS.ServiceImplementation
{
    public partial class RetailPOSService
    {
        #region Public Methods

        /// <summary>
        /// Products: This service implementation class is used to get the product list by category from repository
        /// </summary>
        /// <returns>return list of product by category</returns>
        /// <remarks></remarks>
        public IList<ProductCategoryDTO> GetCategories()
        {
            return CategoryService.GetCategories();
        }

        #endregion
    }
}