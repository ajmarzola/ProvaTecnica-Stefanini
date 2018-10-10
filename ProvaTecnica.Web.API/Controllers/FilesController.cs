using ProvaTecnica.Business;
using System.Web.Mvc;

namespace ProvaTecnica.Web.API.Controllers
{
    public class FilesController : Controller
    {
        /// <summary>
        /// Check File Existence
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns>File Existence</returns>
        public bool Exists(string pPath) => FileBll.Exists(pPath);

        /// <summary>
        /// GetText
        /// </summary>
        /// <param name="pPath">Text File Path</param>
        /// <returns>Text File Content</returns>
        public string GetText(string pPath)
        {
            if (FileBll.Exists(pPath))
                return FileBll.GetText(pPath);

            return string.Empty;
        }
    }
}