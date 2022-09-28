using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs.ApiDTOs
{
    public abstract class BaseDto
    {
        [JsonIgnore]
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
