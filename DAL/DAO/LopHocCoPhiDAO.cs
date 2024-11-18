﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.DAO
{
    public class LopHocCoPhiDAO
    {
        private static LopHocCoPhiDAO instance;
        public static LopHocCoPhiDAO Instance
        {
            get { if (instance == null) instance = new LopHocCoPhiDAO(); return instance; }
            private set { instance = value; }
        }
        public LopHocCoPhiDAO() { }
    
    }
}
