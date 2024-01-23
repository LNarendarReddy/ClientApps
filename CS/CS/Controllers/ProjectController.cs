using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EL;

namespace CS.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        [HttpGet]
        public ActionResult Index()
        {
            DProject ObjDProject = new DProject();
            var Project = ObjDProject.GetProject();
            return View(Project);
        }
        public ActionResult NewProject()
        {
            ProjectModel  p = new  ProjectModel();
            return View(p);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(ProjectModel p)
        {
            string message = "";
            bool status = false;
            try
            {
                DProject ObjDProject = new DProject();
                ObjDProject.SaveProject(p);
                status = true;
                message = "Data Is Successfully Saved.";
            }
            catch (Exception ex)
            {
                message = "Error! Please try again.";
            }
            return new JsonResult { Data = new { status = status, message = message } };
        }

        public ActionResult Edit(int id = 0)
        {
            DProject objDProject = new DProject();

            var project = objDProject.GetProjectDetails(id);
            if (project != null)
            {
                return View(project);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ProjectModel p)
        {
            string message = "";
            bool status = false;
            try
            {
                DProject objDProject = new DProject();
                objDProject.SaveProject(p);
                status = true;
                message = "Data Is Successfully Saved.";
            }
            catch (Exception ex)
            {
                message = "Error! Please try again.";
            }
            return new JsonResult { Data = new { status = status, message = message } };
        }

        public ActionResult Delete(int id = 0)
        {
            DProject objDProject = new DProject();

            var project = objDProject.GetProjectDetails(id);
            if (project != null)
            {
                return View(project);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProjectModel p)
        {
             string message = "";
            bool status = false;
            try
            {
                DProject objDProject = new DProject();
                objDProject.DeleteProject(p);
                status = true;
                message = "Data Is Successfully Deleted.";
            }
            catch (Exception ex)
            {
                message = "Error! Please try again.";
            }
            return new JsonResult { Data = new { status = status, message = message } };
        }
    }
}