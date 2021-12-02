using Business.Abstrack;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.ViewComponents
{
    public class WorkListViewComponent :ViewComponent
    {
        private IWorkService _workService;
        public WorkListViewComponent(IWorkService workService)
        {
            _workService = workService;
        }

        public ViewViewComponentResult Invoke()
        {
            //var model = new WorkListViewModel
            //{
            //    Works = _workService.GetAll(),
                
            //};
            return View();
        }
    }
}
