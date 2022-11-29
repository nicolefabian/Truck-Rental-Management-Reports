using System;
using System.Collections.Generic;

namespace DatabaseProjectB.Models.DB;

public partial class TruckCustomerPb
{
    public int CustomerId { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public int Age { get; set; }

    public DateTime LicenseExpiryDate { get; set; }
}
