
using System;
using System.Collections.Generic;

using System.Globalization;
using CSEFTPC4Core3Objects.Ac4yObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CSAc4yRestServiceClientCore
{
    public partial class ODataGetResponse
    {
        [JsonProperty("@odata.context")]
        public Uri OdataContext { get; set; }

        [JsonProperty("Ac4yPersistentChild")]
        public List<Ac4yPersistentChild> Value { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ages")]
        public long Ages { get; set; }

        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("GUID")]
        public object Guid { get; set; }

        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("createdAt")]
        public object CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public object UpdatedAt { get; set; }
    }
}

