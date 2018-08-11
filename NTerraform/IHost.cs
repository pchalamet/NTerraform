using System;
using System.Collections.Generic;
namespace NTerraform
{
    public interface IHost
    {
        string Name { get; }
        Dictionary<string, object> GetVariables();
    }
}
