namespace VehicleBookingRentalApp.Domain
{
    public class Employee : Person
    {
        public virtual string EmployeeNumber { get; set; }

        public virtual string Department { get; set;}
    }
}
