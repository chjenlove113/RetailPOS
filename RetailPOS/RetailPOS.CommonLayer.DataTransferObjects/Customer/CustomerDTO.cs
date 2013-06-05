﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetailPOS.CommonLayer.DataTransferObjects.Customer
{
    public class CustomerDTO : BaseDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Type_Id { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string OpenId_Id { get; set; }
        public int OpenId_Server_Id { get; set; }
        public string Password { get; set; }
        public int Status_Id { get; set; }
        public decimal Credit_Limit { get; set; }
        public int Payment_Period { get; set; }
        public string Image_Path { get; set; }
        public long Address_Id { get; set; }
    }
}