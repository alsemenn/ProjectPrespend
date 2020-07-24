using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrespend.Common.Model
{
    /// <summary>
    /// Represents a budget item
    /// </summary>
    public class Budget
    {
        public long Id { get; }
        
        public string Name { get; }

        public decimal Value { get; }

        public Budget(long id, string name, decimal value)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
        }
    }
}
