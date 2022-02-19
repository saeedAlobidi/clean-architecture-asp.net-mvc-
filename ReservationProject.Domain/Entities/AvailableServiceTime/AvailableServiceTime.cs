﻿using ReservationProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReservationProject.Domain.Entities.AvailableServiceTime
{
    public class AvailableServiceTime : Entity<long>, ISoftDelete, IAuditableEntity, ICreationEntity
    {
        
        public string day { get; set; }
        public string fromTime { get; set; }
        public string toTime { get; set; }

        [ForeignKey("availableService")]
        public long availableServiceId { get; set; }
        public AvailableService.AvailableService availableService { get; set; }

        // ICreationEntity
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        // IAuditableEntity
        public virtual string LastModifiedBy { get; set; }
        public virtual DateTime? LastModifiedOn { get; set; }
        // ISoftDelete
        public virtual bool Is_Deleted { get; set; }
        public virtual DateTime deleteTime { get; set; }
        public virtual string UserId { get; set; }
    }
}
