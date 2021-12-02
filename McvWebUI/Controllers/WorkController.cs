using Business;
using Business.Abstrack;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Controllers
{
    public class WorkController : Controller
    {
        IStatuService _statuService;
        IWorkService _workService;
        ITeamService _teamService;
        public WorkController(IWorkService workService,ITeamService teamService,IStatuService statuService)
        {
            _workService = workService;
            _teamService = teamService;
            _statuService = statuService;
        }

        public IActionResult Index()
        {

            
        //    var model = new WorkListViewModel
        //    {
        //        Works = _workService.GetAll(),
        //        TeamName= _teamService.GetByName(1)
        //};
            return View();
        }

       
        /*  public IActionResult Index(int team)
          {
              var model = new WorkListViewModel
              {
                  Works = team > 0 ? _workService.GetByName(team) : _workService.GetAll()
              };

              return View(model);

          }*/

    }

}