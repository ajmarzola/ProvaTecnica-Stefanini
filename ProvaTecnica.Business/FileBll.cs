using System.IO;

namespace ProvaTecnica.Business
{
    public class FileBll
    {
        /// <summary>
        /// Check File Existence
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns>File Existence</returns>
        public static bool Exists(string pPath)
        {
            if (string.IsNullOrWhiteSpace(pPath))
                return false;

            try
            {
                return File.Exists(pPath);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// GetText
        /// </summary>
        /// <param name="pPath">Text File Path</param>
        /// <returns>Text File Content</returns>
        public static string GetText(string pPath)
        {
            string retorno = string.Empty;

            if (Exists(pPath))
            {
                try
                {
                    retorno = File.ReadAllText(pPath);
                }
                catch
                {
                    retorno = string.Empty;
                }
            }

            return retorno;
        }
    }
}