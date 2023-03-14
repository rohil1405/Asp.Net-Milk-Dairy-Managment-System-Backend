using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PageGrid.Controllers
{
    public class GridViewModel
    {
        public IEnumerable<String> Page { get; set; }
        public int PageNumber { get; set; }
    }
    public class ValuesController : ApiController
    {
        public IList<String> Page
        {
            get { return new List<String> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" }; }
        }
        public GridViewModel Get(int page, int pagesize)
        {
            return new GridViewModel
            {
                Page = (0 == page ? null : Page.Skip((page - 1) * pagesize).Take(pagesize).ToArray())
                ,
                PageNumber = ((int)Math.Ceiling((double)Page.Count / pagesize))
            };
        }
    } 
}
