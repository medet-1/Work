using Business.Concrete;
using Entities.Concrete;
using Entities.Concrete.Dto.WorkDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Models
{
    public class WorkListViewModel
    {
       // public List<Work> Works { get; set; }
       // public string TeamName { get; set; }
        public List<TeamWorkListModel> Teams { get; set; }
        //public virtual ICollection< Team> kteam { get; set; }

        //private string[] _aylar;
        //public string[] Aylar {
        //    get
        //    {
        //        return this._aylar;
        //    }
        //    set
        //    {
        //        this._aylar = new string[] { "Ocak", "Subat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
        //    }
        //}
       
    //string[] Aylar = new string[] { "Ocak", "Subat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

    }

}
