﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class MedicalService
    {
        public string ServicesId { get; set; }

        public string ServicesName { get; set; }

        public decimal CurrentPrice { get; set; }

        public int ServiceActive { get; set; } = 1; // 1: active, 0: inactive

    }
}
