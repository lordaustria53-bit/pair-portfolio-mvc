namespace PairPortfolioMvc.Models
{
    public class EducationItem
    {
        public string Level { get; set; } = string.Empty;       // e.g., College, Senior High School, Junior High School
        public string School { get; set; } = string.Empty;
        public string ProgramOrTrack { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
    }

    public class SocialLink
    {
        public string Platform { get; set; } = string.Empty;    // e.g., GitHub, Email, LinkedIn
        public string DisplayText { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }

    public class MemberProfile
    {
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
        public List<EducationItem> Education { get; set; } = new();
        public List<SocialLink> Contacts { get; set; } = new();
        public List<ProjectItem> PersonalProjects { get; set; } = new();
    }

    public class ProjectItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
    }

    public class PortfolioViewModel
    {
        public string TeamTagline { get; set; } = string.Empty;
        public List<MemberProfile> Members { get; set; } = new();
        public List<ProjectItem> Projects { get; set; } = new();
    }
}