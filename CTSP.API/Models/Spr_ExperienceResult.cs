﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTSP.API.Models
{
    public partial class Spr_ExperienceResult
    {
        public long ExpID { get; set; }
        public byte? OrgTypeID { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Adv_Date { get; set; }
        public string OrgType { get; set; }
    }
}
