using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs.ApiDTOs
{
    public abstract class BaseDto
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
