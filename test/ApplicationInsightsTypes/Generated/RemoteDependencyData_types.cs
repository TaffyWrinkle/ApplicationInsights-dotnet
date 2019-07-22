
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.10.1.0
//   File : RemoteDependencyData_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace AI
{
    using System.Collections.Generic;

    [global::Bond.Attribute("Description", "An instance of Remote Dependency represents an interaction of the monitored component with a remote component/service like SQL or an HTTP endpoint.")]
    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.10.1.0")]
    public partial class RemoteDependencyData
        : Domain
    {
        [global::Bond.Attribute("Description", "Schema version")]
        [global::Bond.Id(10), global::Bond.Required]
        public int ver { get; set; }

        [global::Bond.Attribute("MaxStringLength", "1024")]
        [global::Bond.Attribute("Description", "Name of the command initiated with this dependency call. Low cardinality value. Examples are stored procedure name and URL path template.")]
        [global::Bond.Id(20), global::Bond.Required]
        public string name { get; set; }

        [global::Bond.Attribute("MaxStringLength", "128")]
        [global::Bond.Attribute("Description", "Identifier of a dependency call instance. Used for correlation with the request telemetry item corresponding to this dependency call.")]
        [global::Bond.Id(30)]
        public string id { get; set; }

        [global::Bond.Attribute("MaxStringLength", "1024")]
        [global::Bond.Attribute("Description", "Result code of a dependency call. Examples are SQL error code and HTTP status code.")]
        [global::Bond.Id(40)]
        public string resultCode { get; set; }

        [global::Bond.Attribute("CSType", "TimeSpan")]
        [global::Bond.Attribute("Description", "Request duration in TimeSpan 'G' (general long) format: d:hh:mm:ss.fffffff.")]
        [global::Bond.Attribute("ActAsRequired", "Renaming value to duration.")]
        [global::Bond.Id(61), global::Bond.Required]
        public string duration { get; set; }

        [global::Bond.Attribute("Description", "Indication of successful or unsuccessful call.")]
        [global::Bond.Id(120)]
        public bool success { get; set; }

        [global::Bond.Attribute("MaxStringLength", "8192")]
        [global::Bond.Attribute("Description", "Command initiated by this dependency call. Examples are SQL statement and HTTP URL's with all query parameters.")]
        [global::Bond.Id(151)]
        public string data { get; set; }

        [global::Bond.Attribute("MaxStringLength", "1024")]
        [global::Bond.Attribute("Description", "Target site of a dependency call. Examples are server name, host address.")]
        [global::Bond.Id(161)]
        public string target { get; set; }

        [global::Bond.Attribute("MaxStringLength", "1024")]
        [global::Bond.Attribute("Description", "Dependency type name. Very low cardinality value for logical grouping of dependencies and interpretation of other fields like commandName and resultCode. Examples are SQL, Azure table, and HTTP.")]
        [global::Bond.Id(162)]
        public string type { get; set; }

        [global::Bond.Attribute("Description", "Collection of custom properties.")]
        [global::Bond.Attribute("MaxKeyLength", "150")]
        [global::Bond.Attribute("MaxValueLength", "8192")]
        [global::Bond.Id(200)]
        public Dictionary<string, string> properties { get; set; }

        [global::Bond.Attribute("Description", "Collection of custom measurements.")]
        [global::Bond.Attribute("MaxKeyLength", "150")]
        [global::Bond.Id(300)]
        public Dictionary<string, double> measurements { get; set; }

        public RemoteDependencyData()
            : this("AI.RemoteDependencyData", "RemoteDependencyData")
        {}

        protected RemoteDependencyData(string fullName, string name)
        {
            ver = 2;
            this.name = "";
            id = "";
            resultCode = "";
            duration = "";
            success = true;
            data = "";
            target = "";
            type = "";
            properties = new Dictionary<string, string>();
            measurements = new Dictionary<string, double>();
        }
    }
} // AI
