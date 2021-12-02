using Business.Abstrack;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        private ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }


       
        public List<Team> GetAll()
        {
            return _teamDal.GetList();

        }

        public string GetByName(int teamID)
        {
            return _teamDal.GetList().Where(x => x.ID == teamID).FirstOrDefault().Name;
        }

                 
        
    }
}
