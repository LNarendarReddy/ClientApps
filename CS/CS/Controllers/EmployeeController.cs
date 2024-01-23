using DL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View("EmployeeList");
        }

        // GET: Employee
        public JsonResult EmployeeList()
        {
            try
            {
                DUser ObjDUser = new DUser();
                List<EmployeeModel> all  = ObjDUser.GetUser();
                return new JsonResult { Data = all, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            catch (Exception ex){ throw ex; }
        }

        public ActionResult Save(int id = 0)
        {
            DUser ObjDUser = new DUser();
            List<RoleModel> Roles = ObjDUser.GetRole();
            List<DesignationModel> Designations = ObjDUser.GetDesignation();
            List<ReportingLeadModel> ReportingLeads = ObjDUser.GetReportingLead();
            if (id > 0)
            { 
                var e = ObjDUser.GetUserDetails(id);
                if (e != null)
                {
                    ViewBag.Roles = new SelectList(Roles, "RoleID", "RoleName");
                    ViewBag.Designations = new SelectList(Designations,"DesignationID","DesignationName");
                    ViewBag.ReportingLeads = new SelectList(ReportingLeads, "ReportingLeadID", "ReportingLead");
                }
                else
                {
                    return HttpNotFound();
                }
                return PartialView("Save", e);
            }
            else
            {
                ViewBag.Roles = new SelectList(Roles, "RoleID", "RoleName");
                ViewBag.Designations = new SelectList(Designations, "DesignationID", "DesignationName");
                ViewBag.ReportingLeads = new SelectList(ReportingLeads, "ReportingLeadID", "ReportingLead");
                return PartialView("Save");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(EmployeeModel E)
        {
            string message = "";
            bool status = false;
            try
            {
                DUser ObjDUser = new DUser();
                ObjDUser.SaveUser(E);
                status = true;
                message = "Data Is Successfully Saved.";
            }
            catch (Exception ex)
            {
                message = "Error! Please try again.";
            }
            return new JsonResult { Data = new { status = status, message = message } };
        }

        public ActionResult Update(int id = 0)
        {
             DUser ObjDUser = new DUser();
            List<RoleModel> Roles = ObjDUser.GetRole();
            List<DesignationModel> Designations = ObjDUser.GetDesignation();
            List<ReportingLeadModel> ReportingLeads = ObjDUser.GetReportingLead();
            if (id > 0)
            {
                var e = ObjDUser.GetUserDetails(id);
                if (e != null)
                {
                    ViewBag.Roles = new SelectList(Roles, "RoleID", "RoleName");
                    ViewBag.Designations = new SelectList(Designations, "DesignationID", "DesignationName");
                    ViewBag.ReportingLeads = new SelectList(ReportingLeads, "ReportingLeadID", "ReportingLead");
                }
                else
                {
                    return HttpNotFound();
                }
                return PartialView("Update", e);
            }
            else
            {
                ViewBag.Roles = new SelectList(Roles, "RoleID", "RoleName");
                ViewBag.Designations = new SelectList(Designations, "DesignationID", "DesignationName");
                ViewBag.ReportingLeads = new SelectList(ReportingLeads, "ReportingLeadID", "ReportingLead");
                return PartialView("Update");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(EmployeeModel E)
        {
            string message = "";
            bool status = false;
            try
            {
                DUser ObjDUser = new DUser();
                ObjDUser.SaveUser(E);
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
            DUser ObjDUser = new DUser();
            var e = ObjDUser.GetUserDetails(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            return PartialView(e);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmployeeModel E)
        {
            string message = "";
            bool status = false;
            try
            {
                DUser ObjDUser = new DUser();
                ObjDUser.DeleteEmployee(E);
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