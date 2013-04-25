using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TheMailer.Models;
using TheMailer.Models.Repositories;

namespace TheMailer.Api
{
    public class InboxController : ApiController
    {
        private readonly EmailsRepository _emailRepository;

        public InboxController()
        {
            _emailRepository = new EmailsRepository();
        }

        public IEnumerable<Email> GetEmails()
        {
            return _emailRepository.All;
        }

        public HttpResponseMessage PostEmail(Email message)
        {
            _emailRepository.Save(message);
            return Request.CreateResponse(HttpStatusCode.Created, message);
        }
    }
}
