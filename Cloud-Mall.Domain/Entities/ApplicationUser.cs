﻿using Microsoft.AspNetCore.Identity;

namespace Cloud_Mall.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<CustomerOrder> Orders { get; set; } = new List<CustomerOrder>();
        public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();
        public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public virtual Cart Cart { get; set; }
        public virtual DeliveryCompany DeliveryCompany { get; set; }
    }
}