using System;
using System.Collections.Generic;

namespace DatabaseProjectB.Models.DB;

public partial class IndividualTruckPb
{
    public int TruckId { get; set; }

    public string Colour { get; set; } = null!;

    public string RegistrationNumber { get; set; } = null!;

    public DateTime WofexpiryDate { get; set; }

    public DateTime RegistrationExpiryDate { get; set; }

    public DateTime DateImported { get; set; }

    public int ManufactureYear { get; set; }

    public string Status { get; set; } = null!;

    public string FuelType { get; set; } = null!;

    public string Transmission { get; set; } = null!;

    public decimal DailyRentalPrice { get; set; }

    public decimal AdvanceDepositRequired { get; set; }

    public int TruckModelId { get; set; }
}
