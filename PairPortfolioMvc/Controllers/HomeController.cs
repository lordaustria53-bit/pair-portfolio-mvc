using Microsoft.AspNetCore.Mvc;
using PairPortfolioMvc.Models;

namespace PairPortfolioMvc.Controllers
{
    public class HomeController : Controller
    {
        private List<MemberProfile> GetMembers()
        {
            return new List<MemberProfile>
            {
                new MemberProfile
                {
                    Slug = "ares",
                    Name = "Ares",
                    Role = "Developer & UI Designer",
                    Bio = "Focused on clean architecture, responsive interfaces, and user-centered web apps.",
                    Summary = "Welcome to Ares's personal portfolio page. Here you can highlight your background, focus areas, and individual builds.",
                    Skills = new List<string> { "C#", "ASP.NET Core MVC", "HTML/CSS", "Git" },
                    Education = new List<EducationItem>
                    {
                        new EducationItem
                        {
                            Level = "College (Current Student)",
                            School = "Polytechnic University of the Philippines (PUP) — Sta. Mesa, Manila",
                            ProgramOrTrack = "Bachelor of Science in Computer Science",
                            Period = "Present"
                        },
                        new EducationItem
                        {
                            Level = "Senior High School",
                            School = "Your Senior High School Name",
                            ProgramOrTrack = "Academic Track / Strand",
                            Period = "Graduated"
                        },
                        new EducationItem
                        {
                            Level = "Junior High School",
                            School = "Your Junior High School Name",
                            ProgramOrTrack = "Secondary Education",
                            Period = "Completed"
                        }
                    },
                    Contacts = new List<SocialLink>
                    {
                        new SocialLink
                        {
                            Platform = "GitHub",
                            DisplayText = "github.com/lordaustria53-bit",
                            Url = "https://github.com/lordaustria53-bit"
                        },
                        new SocialLink
                        {
                            Platform = "Email",
                            DisplayText = "your.email@example.com",
                            Url = "mailto:your.email@example.com"
                        },
                        new SocialLink
                        {
                            Platform = "LinkedIn",
                            DisplayText = "LinkedIn Profile",
                            Url = "https://linkedin.com"
                        }
                    },
                    PersonalProjects = new List<ProjectItem>
                    {
                        new ProjectItem
                        {
                            Title = "Pair Portfolio Web App",
                            Description = "Built the MVC structure, view cards, and Git workflow baseline.",
                            TechStack = "C#, ASP.NET Core MVC, Bootstrap",
                            Owner = "Ares"
                        }
                    }
                },
                new MemberProfile
                {
                    Slug = "partner",
                    Name = "Partner Name",
                    Role = "Developer",
                    Bio = "Partner bio placeholder — ready to be updated via Pull Request.",
                    Summary = "Welcome to your partner's personal portfolio page—ready for them to customize on their own branch.",
                    Skills = new List<string> { "C#", "SQL", "JavaScript" },
                    Education = new List<EducationItem>
                    {
                        new EducationItem
                        {
                            Level = "College (Current Student)",
                            School = "Partner's University Name",
                            ProgramOrTrack = "Degree Program",
                            Period = "Present"
                        },
                        new EducationItem
                        {
                            Level = "Senior High School",
                            School = "Partner's Senior High School",
                            ProgramOrTrack = "Track / Strand",
                            Period = "Graduated"
                        },
                        new EducationItem
                        {
                            Level = "Junior High School",
                            School = "Partner's Junior High School",
                            ProgramOrTrack = "Secondary Education",
                            Period = "Completed"
                        }
                    },
                    Contacts = new List<SocialLink>
                    {
                        new SocialLink
                        {
                            Platform = "GitHub",
                            DisplayText = "github.com/partner-username",
                            Url = "https://github.com"
                        },
                        new SocialLink
                        {
                            Platform = "Email",
                            DisplayText = "partner.email@example.com",
                            Url = "mailto:partner.email@example.com"
                        },
                        new SocialLink
                        {
                            Platform = "LinkedIn",
                            DisplayText = "LinkedIn Profile",
                            Url = "https://linkedin.com"
                        }
                    },
                    PersonalProjects = new List<ProjectItem>
                    {
                        new ProjectItem
                        {
                            Title = "Partner Showcase Project",
                            Description = "Add your own project details here via a Pull Request.",
                            TechStack = "C#, ASP.NET Core MVC",
                            Owner = "Partner Name"
                        }
                    }
                }
            };
        }

        public IActionResult Index()
        {
            var model = new PortfolioViewModel
            {
                TeamTagline = "Designing & Building Meaningful Web Solutions",
                Members = GetMembers(),
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Pair Portfolio Web App",
                        Description = "A collaborative ASP.NET Core MVC portfolio built using GitHub feature branches and Pull Requests.",
                        TechStack = "C#, ASP.NET Core MVC, Bootstrap",
                        Owner = "Team"
                    }
                }
            };

            return View(model);
        }

        public IActionResult Profile(string id)
        {
            var members = GetMembers();
            var member = members.FirstOrDefault(m =>
                string.Equals(m.Slug, id, StringComparison.OrdinalIgnoreCase));

            if (member == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }
    }
}