using System;
using System.Collections.Generic;

namespace nterraform.Hosts
{
    public interface IHost
    {
        string Name { get; }
        Dictionary<string, structure> GetVariables();
    }
}
