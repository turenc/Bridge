﻿using Bridge.Contract;
namespace Bridge.NET
{
    public class ModuleDependency : IModuleDependency
    {
        public string DependencyName
        {
            get;
            set;
        }

        public string VariableName
        {
            get;
            set;
        }
    }
}
