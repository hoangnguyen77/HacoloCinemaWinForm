using System;
using System.Collections.Generic;

namespace BussinessObject;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Email { get; set; }

    public string? CustomerName { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Wallet? Wallet { get; set; }
}
