using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemcubeLibrary
{
    public class LibraryClass
    {
        public string GetDateTimeFromLibrary()
        {
            return "result from library: " + DateTime.Now.ToLongTimeString();
        }
    }
}
