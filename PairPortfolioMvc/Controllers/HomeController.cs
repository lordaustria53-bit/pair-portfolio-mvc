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
                    Name = "Lord Ares Austria",
                    Role = "College Student",
                    Bio = "Second-year Computer Science student at Polytechnic University of the Philippines.",
                    Summary = "Have a strong foundation in programming and hands-on experience working with various development tools.",
                    Skills = new List<string> { "C", "C#", "Java", "ASP.NET Core MVC", "HTML", "Git" },
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
                            School = "Olivarez College - Paranaque",
                            ProgramOrTrack = "Science, Technology, Engineering, and Mathematics (STEM)",
                            Period = "Graduated"
                        },
                        new EducationItem
                        {
                            Level = "Junior High School",
                            School = "Las Piñas North National High School",
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
                            DisplayText = "lordaustria53@gmail.com",
                            Url = "mailto:lordaustria53@gmail.com"
                        },
                        new SocialLink
                        {
                            Platform = "LinkedIn",
                            DisplayText = "Lord Ares Austria",
                            Url = "https://www.linkedin.com/in/lord-ares-austria-272467370/"
                        }
                    },
                    PersonalProjects = new List<ProjectItem>
                    {
                        new ProjectItem
                        {
                            Title = "School Website",
                            Description = "Built a school website using HTML.",
                            TechStack = "HTML",
                            Owner = "Ares"
                        },
                        new ProjectItem
                        {
                            Title = "Concert Ticketing System",
                            Description = "Built a concert ticketing system using C language.",
                            TechStack = "C",
                            Owner = "Ares, Helena, and Loreign"
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