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