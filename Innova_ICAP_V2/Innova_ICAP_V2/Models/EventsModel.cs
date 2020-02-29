using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class EventsModel
    {
        public EventsModel()
        {
            Activities = new HashSet<ActivitiesModel>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }

        public virtual GalleryModel Gallery { get; set; }
        public virtual ImagesModel Images { get; set; }
        public virtual ICollection<ActivitiesModel> Activities { get; set; }
    }
}
