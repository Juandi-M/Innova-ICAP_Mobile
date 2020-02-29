using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class ActivitiesModel
    {
        public ActivitiesModel()
        {
            OratorActivities = new HashSet<OratorActivitiesModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public int IdEvent { get; set; }

        public virtual EventsModel IdEventNavigation { get; set; }
        public virtual ImagesModel Images { get; set; }
        public virtual ICollection<OratorActivitiesModel> OratorActivities { get; set; }
    }
}
