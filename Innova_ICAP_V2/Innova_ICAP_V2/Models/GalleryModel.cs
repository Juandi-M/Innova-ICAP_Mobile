using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class GalleryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }

        public virtual EventsModel IdNavigation { get; set; }
    }
}
