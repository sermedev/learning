﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.Models;

public partial class Beer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Style { get; set; } = null!;
}
