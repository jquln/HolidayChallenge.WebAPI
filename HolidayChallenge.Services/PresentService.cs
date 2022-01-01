using HolidayChallenge.Data;
using HolidayChallenge.Models.PresentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HolidayChallenge.Services
{

    public class PresentService
    {
        private readonly Guid _userId;
        public PresentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePresent(PresentCreate model)
        {
            var entity =
                new Present()
                {
                    Wrapping = model.Wrapping,
                    Contains = model.Contains,
                    Hints = model.Hints,
                    TimeShaken = model.TimeShaken,
                    IsWrapped = model.IsWrapped,
                    TreeId = model.TreeId
                };
            using (var ctx = new ApplicationDbContext())
            {
                return false;
            }
        }

        public IEnumerable<PresentList> GetPresents()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Presents.ToArray();
                return query.Select(
                    e =>
                    new PresentList
                    {
                        Id = e.Id,
                        Wrapping = e.Wrapping,
                        Contains = e.Contains,
                        Hints = e.Hints,
                        TimeShaken = e.TimeShaken,
                        IsWrapped = e.IsWrapped,
                        TreeId = e.TreeId

                    }).ToArray();
            }

        }

        public PresentDetail GetPresentByID(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Presents
                    .Single(e => e.Id == id);
                return
                    new PresentDetail
                    {
                        Id = entity.Id,
                        Wrapping = entity.Wrapping,
                        Contains = entity.Contains,
                        Hints = entity.Hints,
                        TimesShaken = entity.TimeShaken,
                        IsWrapped = entity.IsWrapped,
                        TreeId = entity.TreeId,
                       
                    };
            }
        }
    }



}
