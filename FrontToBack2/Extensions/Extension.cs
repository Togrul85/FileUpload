using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FrontToBack2.Extensions
{
    public static  class Extension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool CheckImageSize(this IFormFile file,int size)
        {
            return file.ContentType.Contains("image");  
        }



    }
}
