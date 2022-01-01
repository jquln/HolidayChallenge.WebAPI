using HolidayChallenge.Data;
using HolidayChallenge.Models.OrnamentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Services
{
    public class OrnamentService
    {
        private readonly Guid _userId;
        public OrnamentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateOrnament(OrnamentCreate model)
        {
            var entity =
                new Ornament()
                {
                    Description = model.Description,
                    TreeId = model.TreeId,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ornaments.Add(entity);

                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<OrnamentList> GetOrnaments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Ornaments.AsEnumerable()
                        .Select(
                        e =>
                            new OrnamentList
                            {
                                Id = e.Id,
                          
                            }).ToArray();
                return query;
            }
        }

        public OrnamentDetail GetOrnamentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Ornaments
                    .Single(e => e.Id == id);
                return
                    new OrnamentDetail
                    {
                        Id = entity.Id,
                        Description = entity.Description
                    };
                      
            }
        }
    }
}
