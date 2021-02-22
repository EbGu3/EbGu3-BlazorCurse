using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Client.Data
{
    public struct MultipleSelectModel
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public MultipleSelectModel(string _Key, string _Value)
        {
            Key = _Key;
            Value = _Value;
        }
    }
}
