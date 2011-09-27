using System.Web.Mvc;
namespace My.Web.Application.Controllers
{
    public abstract class BaseController : Controller
    {
        public ActionResult Http404 {
            get {
                Response.StatusCode = 404;
                return View("Http404");
            }
        }

        public RedirectResult RedirectToActionWithHash(string action, object routeValues, string hash)
        {
            return Redirect(
                Url.Action(action, routeValues) + "#" + hash
            );
        }

        public RedirectResult RedirectToActionWithHash(string action, string hash)
        {
            return Redirect(
                Url.Action(action) + "#" + hash
            );
        }

        protected byte[] ReadPostedFile(string key, out string mime)
        {
            var file = Request.Files[key];

            if (file == null)
            {
                mime = null;
                return null;
            }
            else
            {
                mime = file.ContentType;

                var buffer = new byte[file.ContentLength];
                file.InputStream.Read(buffer, 0, file.ContentLength);
                return buffer;
            }
        }
    }
}
