using Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestService.Manager
{
    public interface IManagePlayers
    {
        IEnumerable<FootballPlayer> Get();

        FootballPlayer Get(int id);


        bool Create(FootballPlayer pizza);

        bool Update(int id, FootballPlayer pizza);

        FootballPlayer Delete(int id);

    }
}
