using Business.Abstrack;
using Business.Concrete;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Controllers
{
    public class WorkModificationController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IWorkService _workService;


        public WorkModificationController(ILogger<HomeController> logger, IWorkService workService)
        {
            _logger = logger;
            _workService = workService;
        }

        public IActionResult Index()
        {
            WorkListViewModel workListViewModel = new WorkListViewModel();
            List<TeamWorkListModel> listOfTeamWork = new List<TeamWorkListModel>();
            workListViewModel.Teams = listOfTeamWork;

            var result = _workService.GetWorkDetailWithTeamName();
            if (result.Success && result.Data.Count > 0)
            {
                foreach (var item in result.Data)
                {
                    workListViewModel.Teams.Add(new TeamWorkListModel
                    {
                        ID = item.ID,
                        WorkID = item.WorkID,
                        Name = item.Name,
                        Effort = item.Effort,

                        TeamName = item.TeamName,

                        StatuID = item.StatuID

                    });
                }
            }

            return View(workListViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
