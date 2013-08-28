﻿using Abp.Entities.NHibernate.Mappings;

namespace ExamCenter.Entities.NHibernate.Mappings
{
    public class QuestionMap : EntityMap<Question>
    {
        public QuestionMap()
            : base("EcQuestions")
        {
            References(x => x.Tenant).Column("TenantId");
            Map(x => x.QuestionText);
            Map(x => x.AnsweringType).CustomType<AnsweringType>();
            Map(x => x.EstimatedAnsweringTime);
            Map(x => x.ExperienceDegree).CustomType<ExperienceDegree>();
            Map(x => x.RightAnswerText);
        }
    }
}
