using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WaterProject.Models
{
    public partial class Projects
    {
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public long? ProjectRegionalProgram { get; set; }
        public long? ProjectImpact { get; set; }
        public string ProjectPhase { get; set; }
        public string ProjectFunctionalityStatus { get; set; }
    }
}
