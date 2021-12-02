using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Models
{
    public class TeamListViewModel
    {
        public List<Team> Team { get; set; }
        public TeamWorkListModel Work { get; set; }
    
    }
}
