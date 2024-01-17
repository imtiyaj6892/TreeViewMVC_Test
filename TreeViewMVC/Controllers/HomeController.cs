using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeViewMVC.Models;

namespace TreeViewMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {

            var db = new context();
            var defaultValue = new NodeViewModel();
            defaultValue.NodeList = db.Node.Select(o => new SelectListItem { Value = o.NodeId.ToString(), Text = o.NodeName }).ToList();
            defaultValue.NodeList.Insert(0, (new SelectListItem { Text = "Select Parent Node", Value = "0" }));
            return View(defaultValue);
        }
        [HttpPost]
        public ActionResult Create(NodeViewModel model)
        {
            var db = new context();
            Node newNode = new Node();
            newNode.IsActive = model.IsActive;
            var nw = new Node();
            if (model.ParentNodeId > 0)
            {
             
                newNode.ParentNodeId = model.ParentNodeId.Value;// model.NodeId>0? model.NodeId:null;
            }

            newNode.NodeName = model.NodeName;
            db.Node.Add(newNode);
            db.SaveChanges();
            return RedirectToAction("TreeView", "Home");
        }



        public ActionResult TreeView()
        {
            var db = new context();
            var list = db.Node.Where(x => !x.ParentNodeId.HasValue && x.IsActive == true).ToList();

            return View(list);
        }

       

    }
}