﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTSP.API.Models
{
    public partial class SPR_TbUsersProfileResult
    {
        public long UserPID { get; set; }
        public long? UserID { get; set; }
        public byte? RelationShipID { get; set; }
        public string FHName { get; set; }
        public string FcellNo { get; set; }
        public string CNIC { get; set; }
        public string CNICFPic { get; set; }
        public string CNICBPic { get; set; }
        public string Pic { get; set; }
        public DateTime? DOB { get; set; }
        public byte? Genderid { get; set; }
        public bool? MaritalStatus { get; set; }
        public short? CityID { get; set; }
        public bool? Religion { get; set; }
        public string OtherReligion { get; set; }
        public bool? isHafizQuran { get; set; }
        public bool? isDisable { get; set; }
        public bool? isCAgeRelax { get; set; }
        public bool? isLocked { get; set; }
    }
}
