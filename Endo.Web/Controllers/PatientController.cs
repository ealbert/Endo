using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Endo.Web.Controllers
{
  using BusinessProcessors;
  using Models;

  [Authorize]
  public class PatientController : Controller
  {

    public PatientController()
    {
      _patientProcessor = new PatientProcessor();
    }

    private readonly PatientProcessor _patientProcessor;


    [HttpGet]
    public ActionResult Create()
    {
      return View(new PatientModel());
    }

    [HttpPost]
    public ActionResult Create(PatientModel model)
    {
      if (ModelState.IsValid)
      {
        _patientProcessor.CreatePatient(model);
        return  RedirectToAction( "Index", "Home");
      }
      return View(model);
    }

  }
}
