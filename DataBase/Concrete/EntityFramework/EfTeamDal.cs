using Core.DataAccess.Abstrack;
using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Results;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfTeamDal : EfEntityRepositoryBase<Team, WorkContext>, ITeamDal 
    {
       /* public List<TeamDto> GetName()
        {
            WorkContext Work = new WorkContext();
            var result = from t in Work.Teams
                         join w in Work.Works on t.ID equals w.TeamID

                         select new
                         {
                             t.Name,
                             w.ID,
                             w.Beginning,
                             w.Effort,
                             w.Finish,
                             w.WorkID
                         };
            result.ToList();
            return null;
        }

        */



    }
}
