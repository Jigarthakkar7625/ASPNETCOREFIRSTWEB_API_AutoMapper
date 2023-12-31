﻿using System;
using System.Collections.Generic;

namespace ASPNETCOREFIRSTWEB_API_AutoMapper.Models;

public partial class UserAddress
{
    public int UserAddressId { get; set; }

    public int? UserId { get; set; }

    public int? AddressId { get; set; }

    

    public virtual Address? Address { get; set; }

    public virtual User? User { get; set; }
}
