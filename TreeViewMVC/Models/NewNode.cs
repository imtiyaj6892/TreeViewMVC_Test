using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreeViewMVC.Models
{
    public class NodeViewModel
    {
        public int NodeId { get; set; }
        public string NodeName { get; set; }
        public bool IsActive { get; set; }
        public int? ParentNodeId { get; set; }
        public List<SelectListItem> NodeList { get; set; }
    }
}