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
                    Slug = "lean",
                    Name = "Lean",
                    Role = "Passionate Artist | Aspiring UI/UX Designer",
                    Bio = "Architect for creating visually appealing and user-friendly interfaces.",
                    Summary = "Welcome to Lean's personal portfolio, where art meets technology and creativity that turns imagination into reality.",
                    Skills = new List<string> { "Java", "C", "Figma", "Adobe Photoshop", "Adobe Illustrator" },
                    Education = new List<EducationItem> {
                        new EducationItem {
                            Level = "College (Current Student)",
                            School = "Polytechnic University of the Philippines (PUP) — Sta. Mesa, Manila",
                            ProgramOrTrack = "Bachelor of Science in Computer Science (BSCS)",
                            Period = "Present"
                        },
                        new EducationItem {
                            Level = "Senior High School",
                            School = "Quirino High School",
                            ProgramOrTrack = "Academic Track / Science, Technology, Engineering, and Mathematics (STEM)",
                            Period = "Graduated (School year: 2023 - 2025)"
                        },
                        new EducationItem {
                            Level = "Junior High School",
                            School = "Quirino High School",
                            ProgramOrTrack = "Secondary Education",
                            Period = "Completed (School year: 2019-2023)"
                        }
                    },
                    Contacts = new List<SocialLink> {
                        new SocialLink {
                            Platform = "GitHub",
                            DisplayText = "github.com/ainoselemae-lab",
                            Url = "https://github.com/ainoselemae-lab"
                        },
                        new SocialLink {
                            Platform = "Email",
                            DisplayText = "ainoelemae@gmail.com",
                            Url = "mailto:ainoelemae@gmail.com"
                        },
                        new SocialLink {
                            Platform = "LinkedIn",
                            DisplayText = "Lean Marie Ainos Dumlao",
                            Url = "https://www.linkedin.com/in/lean-marie-ainos-dumlao-7152013a6/"
                        }
                    },
                    PersonalProjects = new List<ProjectItem> {
                        new ProjectItem {
                            Title = "Pair Portfolio Web App",
                            Description = "Built the MVC structure, view cards, and Git workflow baseline.",
                            TechStack = "C#, ASP.NET Core MVC",
                            Owner = "Lean & Ares"
                        },
                        new ProjectItem {
                            Title = "Inquiries, Investigations, and Immersion: PhysX Prototype",
                            Description = "Gamified learning application developed, designed to motivate student to " +
                            "learn and understand physics concepts through an engaging and interactive experience.",
                            TechStack = "C#, uGUI, Adobe Illustrator",
                            Owner = "Team"
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
                        Description = "Built the MVC structure, view cards, and Git workflow baseline",
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
                return RedirectToAction(nameof(Index)) ;
            }

            return View(member);
        }
    }
}