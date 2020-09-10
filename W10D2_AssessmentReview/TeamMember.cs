using System;
namespace W10D2_AssessmentReview
{
    public class TeamMember
    {

        public string Name { get; set; }

        public string Job { get; set; }

        public TeamMember(string name, string job)
        {
            Name = name;
            Job = job;
        }
    }
}
