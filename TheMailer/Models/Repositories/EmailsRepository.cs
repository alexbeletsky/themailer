using System.Collections.Generic;
using TheMailer.Api;

namespace TheMailer.Models.Repositories
{
    public class EmailsRepository
    {
        private static List<Email> _container;

        static EmailsRepository()
        {
            _container = new List<Email>
                             {
                                 new Email
                                     {
                                         Subject = "Hello, I'm first message",
                                         Message = "Message body",
                                         Priority = "",
                                         SentDate = "04/25/2013"
                                     },
                                 new Email
                                     {
                                         Subject = "Invitation to MSSWIT conference",
                                         Message = "Invitation to MSSWIT conference",
                                         Priority = "High",
                                         SentDate = "04/25/2013"
                                     },
                                 new Email
                                     {
                                         Subject = "[SPAM] Such pretty kitties!!!",
                                         Message = "A lot of LOL cats inside",
                                         Priority = "High",
                                         SentDate = "04/24/2013"
                                     },
                                 new Email
                                     {
                                         Subject = "Youtube: Checkout new videos in channel",
                                         Message = "Links, Links, Links",
                                         SentDate = "04/24/2013"
                                     },
                                 new Email
                                     {
                                         Subject = "Disqus: New comments in beletsky.net blog",
                                         Message = "Checkout, a@.com left comment in your blog...",
                                         SentDate = "04/23/2013"
                                     },
                                new Email
                                     {
                                         Subject = "O'Reilly Media",
                                         Message = "Deal/Day: Discover out 5 books and SAVE 50%",
                                         SentDate = "04/23/2013"
                                     },
                                new Email
                                     {
                                         Subject = "Github: You started to watch repository",
                                         Priority = "High",
                                         Message = "Repository: http://github.com/alexanderbeletsky/themailer",
                                         SentDate = "04/22/2013"
                                     },
                                new Email
                                     {
                                         Subject = "Twitter: New follower in twitter",
                                         Message = "@coolguy started to follow you!",
                                         SentDate = "04/22/2013"
                                     },
                                new Email
                                     {
                                         Subject = "ASP.NET MVC News",
                                         Message = "Links, Links, Links",
                                         SentDate = "04/21/2013"
                                     }
                             };
        }

        public IEnumerable<Email>  All
        {
            get { return _container; }
        }

        public void Save(Email message)
        {
            _container.Insert(0, message);
        }
    }
}