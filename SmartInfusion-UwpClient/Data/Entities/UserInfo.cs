﻿using System;
using SmartInfusion_UwpClient.Data.Entities.Base;
using SmartInfusion_UwpClient.Data.Entities.Identity;

namespace SmartInfusion_UwpClient.Data.Entities
{
    public class UserInfo : BaseEntity
    {
        public int UserInfoId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Notes { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
