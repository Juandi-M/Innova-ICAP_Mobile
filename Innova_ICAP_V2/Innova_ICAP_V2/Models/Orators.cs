using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class OratorsModel
    {
        public OratorsModel()
        {
            OratorActivities = new HashSet<OratorActivitiesModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Institute { get; set; }
        public string Description { get; set; }

        public virtual ImagesModel Images { get; set; }
        public virtual ICollection<OratorActivitiesModel> OratorActivities { get; set; }
    }
}
