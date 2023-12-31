﻿using System;
using System.Collections.Generic;

namespace ASPNETCOREFIRSTWEB_API_AutoMapper.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();
}
