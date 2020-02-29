using System;
using System.Collections.Generic;

namespace ICAP_API.Models
{
    public partial class QuestionAnswersModel
    {
        public int Id { get; set; }
        public int IdConfOrator { get; set; }
        public string NamePerson { get; set; }
        public string QuestionText { get; set; }

        public virtual OratorActivitiesModel IdConfOratorNavigation { get; set; }
    }
}
