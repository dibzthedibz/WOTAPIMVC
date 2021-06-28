﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTAPI.Data;
using WOTAPI.Models.Nation;

namespace WOTAPI.Services
{
    public class NationService
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        private readonly Guid _userId;
        public NationService(Guid userId)
        {
            _userId = userId;
        }

        public IEnumerable<NationListItem> GetNations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Nations.Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new NationListItem
                        {
                            NationId = e.NationId,
                            NationName = e.NationName,
                            Terrain = e.Terrain,
                            Trades = e.Trades
                        }
                    );
                return query.ToArray();
            }
        }
        public bool CreateNation(NationCreate model)
        {
            var entity = new Nation()
            {
                OwnerId = _userId,
                NationName = model.NationName,
                Terrain = model.Terrain,
                Trades = model.Trades
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Nations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
