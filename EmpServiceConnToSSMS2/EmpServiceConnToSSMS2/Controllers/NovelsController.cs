using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmpDataAccess;

namespace EmpServiceConnToSSMS2.Controllers
{
    public class NovelsController : ApiController
    {

        public IEnumerable<Novel> Get()
        {

            using (NoveldbEntities nov = new NoveldbEntities())
            {
                return nov.Novels.ToList();
            }

        }

        public Novel  Get(int id)
        {

            using (NoveldbEntities nov = new NoveldbEntities())
            {
                return nov.Novels.FirstOrDefault(n => n.ID == id);
            }

        }


        public HttpResponseMessage Post([FromBody] Novel novel)
        {
            try
            {
                using (NoveldbEntities nov = new NoveldbEntities())
                {
                    nov.Novels.Add(novel);
                    nov.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, novel);
                    message.Headers.Location = new Uri(Request.RequestUri + novel.ID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {

              return  Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        
        }




    }
}
