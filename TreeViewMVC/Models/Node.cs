using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TreeViewMVC.Models
{
    public class Node
    {
        public Node()
        {
            StartDate = DateTime.Now;
        }
        //Cat Id
        [Key]
        public int NodeId { get; set; }

        //Cat Name
        public string NodeName { get; set; }

        //represnts Parent ID and it's nullable
        public int? ParentNodeId { get; set; }
        [ForeignKey("ParentNodeId")]
        public virtual Node Parent { get; set; }
        public virtual ICollection<Node> Childs { get; set; }

        public bool IsActive { get; set; }

        public DateTime StartDate { get; set; }


    }

}