using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class ImagesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int IdOrator { get; set; }
        public int IdActivites { get; set; }
        public int IdEvents { get; set; }

        public virtual EventsModel Id1 { get; set; }
        public virtual OratorsModel Id2 { get; set; }
        public virtual ActivitiesModel IdNavigation { get; set; }
    }
}
