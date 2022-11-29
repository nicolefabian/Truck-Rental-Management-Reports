using System;
using System.Collections.Generic;

namespace DatabaseProjectB.Models.DB;

public partial class TruckModelPb
{
    public int ModelId { get; set; }

    public string Model { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public string Size { get; set; } = null!;

    public int Seats { get; set; }

    public int Doors { get; set; }
}
