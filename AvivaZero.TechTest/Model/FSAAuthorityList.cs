using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AvivaZero.TechTest.Model
{
    public class FsaAuthorityList {

        [JsonPropertyName("authorities")]
        public List<FsaAuthority> Authorities { get; set; }

        public override string ToString()
        {
            return $"FSAAuthorityList[{nameof(Authorities)}={Authorities}]";
        }
    }
}
