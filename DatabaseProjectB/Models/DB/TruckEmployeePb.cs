using System;
using System.Collections.Generic;

namespace DatabaseProjectB.Models.DB;

public partial class TruckEmployeePb
{
    public int EmployeeId { get; set; }

    public string OfficeAddress { get; set; } = null!;

    public string PhoneExtensionNumber { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;
}
