using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MenuE : BaseE
    {
        public int ID { get; set; }
        public int IDP_ROLE { get; set; }
        public string PARENT_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string ICON { get; set; }
        public string CONTROLLER { get; set; }
        public string ACTION { get; set; }
        public bool STATUS_Menu { get; set; }
        public bool Creeate_Menu { get; set; }
        public bool Edit_Menu { get; set; }
        public bool View_Menu { get; set; }
        public bool Send_Menu { get; set; }
        public bool Permisson_Status { get; set; }
        public bool Permisson_Create { get; set; }
        public bool Permisson_Edit { get; set; }
        public bool Permisson_View { get; set; }
        public bool Permisson_Send { get; set; }
    }
}

