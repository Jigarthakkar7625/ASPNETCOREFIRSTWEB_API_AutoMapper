﻿using System;
using System.Collections.Generic;

namespace ASPNETCOREFIRSTWEB_API_AutoMapper.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string? AddressName { get; set; }

    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();
}
