﻿using System.Collections.Generic;
using System.Linq;

namespace Common.Result
{
  public class DataCollection<T>
  {
    public bool HasItems
    {
      get => Items != null && Items.Any();
    }

    public IEnumerable<T> Items { get; set; }
    public int Total { get; set; }
    public int Page { get; set; }
    public int Pages { get; set; }
  }
}
