using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class OratorActivitiesModel
    {
        public OratorActivitiesModel()
        {
            QuestionAnswers = new HashSet<QuestionAnswersModel>();
        }

        public int Id { get; set; }
        public int? IdOrator { get; set; }
        public int? IdActivities { get; set; }

        public virtual ActivitiesModel IdActivitiesNavigation { get; set; }
        public virtual OratorsModel IdOratorNavigation { get; set; }
        public virtual ICollection<QuestionAnswersModel> QuestionAnswers { get; set; }
    }
}
