using HolidayChallenge.Data;
using HolidayChallenge.Models.TreeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Services
{
    public class TreeService
    {
        private readonly Guid _userId;
        public TreeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTree(TreeCreate model)
        {
            var entity =
                new Tree()
                {
                    Description = model.Description
                    
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Trees.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TreeList> GetTrees()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Trees.AsEnumerable()
                        .Select(
                        e =>
                            new TreeList
                            {
                                Id = e.Id,
                                Description = e.Description
                            }).ToArray();
                return query;
            }
        }

    }
}
