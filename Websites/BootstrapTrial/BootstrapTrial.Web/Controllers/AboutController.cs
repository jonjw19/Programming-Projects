using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTrial.Web.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public FileResult Resume()
        {
            return File("~/Content/Documents/Wilson, Jonathan.docx","msword","Wilson, Jonathan.docx");
        }

    }
}
