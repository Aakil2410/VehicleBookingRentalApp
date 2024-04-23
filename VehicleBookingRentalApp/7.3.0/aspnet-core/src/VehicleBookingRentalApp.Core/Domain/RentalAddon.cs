using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingRentalApp.Domain
{
    public class RentalAddon : FullAuditedEntity<Guid>
    {
        public virtual string Option { get; set; }

        public virtual string Details { get; set; }

        public virtual decimal Cost { get; set; }

    }
}
