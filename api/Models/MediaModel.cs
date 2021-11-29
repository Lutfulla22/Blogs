using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace api.Models
{
    public class MediaModel
    {
        public IEnumerable<IFormFile> Data { get; set; }
    }
}