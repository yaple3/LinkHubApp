using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using LinkHubApp.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LinkHubApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LinkHubAppContext(
                               serviceProvider.GetRequiredService<DbContextOptions<LinkHubAppContext>>()))
            {
                // Make sure context is not null
                if (context == null || context.LinkResources == null)
                {
                    throw new ArgumentNullException("Null LinkHubAppContext");
                }

                // Look for any resources/ensure database isn't empty
                if (context.LinkResources.Any())
                {
                    return;   // DB has been seeded
                }

                // Seed the database
                context.LinkResources.AddRange(
                    new Links
                    {
                        LinkName = "Intro to Web Design",
                        LinkUrl = "https://www.introtoweb.design/?utm_source=webflow-inspo&utm_medium=email&utm_campaign=feb-14-2024",
                        LinkDescription = "Master web design principles and build a portfolio-ready landing page in Figma from start to finish.",
                        LinkType = "Web Design",
                        Date = DateTime.Parse("2024-2-27"),
                    },

                    new Links
                    {
                        LinkName = "WePresent | Stuff They Don't Tell You: Practical creative advice",
                        LinkUrl = "https://wepresent.wetransfer.com/series/stuff-they-dont-tell-you",
                        LinkDescription = "Our practical creative advice series Stuff They Don’t Tell you offers tips to navigate all those things that... well... they don't tell you.",
                        LinkType = "Career",
                    },

                    new Links
                    {
                        LinkName = "Coolors",
                        LinkUrl = "https://coolors.co/",
                        LinkDescription = "The super fast color palettes generator!",
                        LinkType = "Color",
                    },

                    new Links
                    {
                        LinkName = "Career Myths",
                        LinkUrl = "https://wepresent.wetransfer.com/series/lecture-in-progress-career-myths",
                        LinkDescription = "Lecture in Progress debunk the myths around the creative industry",
                        LinkType = "Career",
                    },

                    new Links
                    {
                        LinkName = "Five Future Roles for Designers",
                        LinkUrl = "https://jarango.com/2024/01/21/five-future-roles-for-designers/?utm_source=webflow-inspo&utm_medium=email&utm_campaign=feb-14-2024",
                        LinkDescription = "Possible career directions for designers working in an AI-driven world.",
                        LinkType = "Career",
                        Date = DateTime.Parse("2024-1-21"),
                    },

                    new Links
                    {
                        LinkName = "The Power of Design",
                        LinkUrl = "https://wepresent.wetransfer.com/series/power-of-design-99designs-vistaprint",
                        LinkDescription = "How type, color and form can change our overall perception of a brand's identity",
                        LinkType = "Design",
                    },

                    new Links
                    {
                        LinkName = "How to Stay Focused While Studying",
                        LinkUrl = "https://www.canva.com/learn/17-study-tips-to-help-you-stay-focused/",
                        LinkDescription = "17 Study Tips to Help You Stay Focused",
                        LinkType = "ADHD, Learn",
                    },

                    new Links
                    {
                        LinkName = "Why You Should Design Something New Every Day",
                        LinkUrl = "https://www.canva.com/learn/design-new-every-day/",
                        LinkDescription = "20 awesome case studies to inspire you",
                        LinkType = "Design",
                    },

                    new Links
                    {
                        LinkName = "Emphasize Career Highlights on Your Resume by Using Color Strategically",
                        LinkUrl = "https://www.canva.com/learn/accent-color-resume/",
                        LinkDescription = "20 Rules for Using Color Strategically on Your Resume.",
                        LinkType = "Career, Color, Design",
                        Date = DateTime.Parse("2024-2-12"),
                    },

                    new Links
                    {
                        LinkName = "Don't Just Set goals. Build Systems",
                        LinkUrl = "https://medium.com/swlh/dont-just-set-goals-build-systems-8158ac541df",
                        LinkDescription = "The Secret To Happiness And Achieving More",
                        LinkType = "Growth",
                        Date = DateTime.Parse("2022-12-20"),
                    },

                    new Links
                    {
                        LinkName = "20 Graphic Design Resources the Pros Swear By",
                        LinkUrl = "https://www.rasmussen.edu/degrees/design/blog/graphic-design-resources/",
                        LinkDescription = "We did the legwork and vetted the options to bring you this list of the best graphic design resources.",
                        LinkType = "Design",
                        Date = DateTime.Parse("2021-3-22"),
                    },

                    new Links
                    {
                        LinkName = "Avoid These 12 Mistakes When Pricing Your Design Work",
                        LinkUrl = "https://creative-boost.com/pricing-mistakes/",
                        LinkDescription = "Do you know what to consider when pricing design work? Are you charging enough? Avoid these 12 mistakes.",
                        LinkType = "Career, Design",
                        Date = DateTime.Parse("2019-4-10"),
                    },

                    new Links
                    {
                        LinkName = "The Law on Fonts and Typefaces in Design and Marketing",
                        LinkUrl = "https://www.crowdspring.com/blog/font-law-licensing/",
                        LinkDescription = "Here's everything you want to know about the law on fonts and typefaces.",
                        LinkType = "Legal, Fonts, Career",
                        Date = DateTime.Parse("2024-2-12"),
                    },

                    new Links
                    {
                        LinkName = "The 8 Types of Graphic Design You Need To Know",
                        LinkUrl = "https://99designs.com/blog/tips/types-of-graphic-design/",
                        LinkDescription = "From packaging to motion graphics, the graphic design industry is huge.Whether you are an aspiring designer or seeking design services for your business, understanding the 8 types of graphic design will help you find the right skills for the job.",
                        LinkType = "Design, Career",
                    },

                    new Links
                    {
                        LinkName = "Blending Modes: A Complete Guide for Graphic and Web Design",
                        LinkUrl = "https://www.elegantthemes.com/blog/design/blending-modes",
                        LinkDescription = "Blending modes are a great way to digitally enhance your images and designs. There are several ways to use blend modes as a graphic designer (using design software) or as a web designer (using CSS or Divi). In this post, we’re going to cover everything you need to know about blend modes, including a detailed breakdown of each, as well as how to use them in Photoshop and on your website.",
                        LinkType = "Design, Create",
                        Date = DateTime.Parse("2024-4-24"),
                    },

                    new Links
                    {
                        LinkName = "9 Best Design Tools for 2024 (Ranked & Compared)",
                        LinkUrl = "https://www.elegantthemes.com/blog/design/best-design-tools",
                        LinkDescription = "Whether you’re a new designer or a seasoned professional, choosing the best design tools for your needs is a big decision. Considerations such as skill level, options, and price all come into play. Thankfully, we’ve done a deep dive into the most popular and highly-rated design tools on the market to help you decide. In this post, we’ll showcase our top picks for the best design tools and outline their pros and cons so you can rest easy knowing you’re selecting the best design tools for your needs.",
                        LinkType = "Design",
                        Date = DateTime.Parse("2024-4-24"),
                    },

                    new Links
                    {
                        LinkName = "Drawing Basics - Construction",
                        LinkUrl = "https://thevirtualinstructor.com/blog/drawing-basics-construction",
                        LinkDescription = "Learn how to draw anything in the world through the process of construction. Use basic shapes to draw any object.",
                        LinkType = "Create",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}