using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace OwinBlog
{
    public class BlogController : ApiController
    {
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult<User> GetUser(User user)
        {
            return Json<User>(user);
            
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "linezero", "owin linezero blog" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return string.Format("owin {0} by:linezero", id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
