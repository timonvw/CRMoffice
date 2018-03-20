using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Office.Controller
{
    public class Datalayer
    {
        private static Datalayer _instance;
        public static Datalayer Instance => _instance ?? (_instance = new Datalayer());

    }
}
