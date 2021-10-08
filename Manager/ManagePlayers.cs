using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football;
//using ModelLib.model;


namespace RestService.Manager
{
    public class ManagePlayers:IManagePlayers
    {
        private static List<FootballPlayer> list = new List<FootballPlayer>()
        {
            new FootballPlayer("knud",123,23),
            new FootballPlayer("knud",312,12),
            new FootballPlayer("knud",231,7),
            new FootballPlayer("knud",321,44),

        };

        public ManagePlayers()
        {
            //_data.Add(new Pizza());

            // dårlig ide flydes på hver gang der laves et objekt
        }


        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(list);
        }

        public FootballPlayer Get(int id)
        {
            if (list.Exists(p => p.Id == id))
            {
                return list.Find(p => p.Id == id);
            }

            throw new KeyNotFoundException($"Id {id} findes ikke");
        }


        

        public bool Create(FootballPlayer player)
        {
            // todo check for duplicates
            list.Add(player);
            return true;
        }

        public bool Update(int id, FootballPlayer player)
        {
            if (Get(id) != null)
            {
                Get(id).Id = id;
                Get(id).Name = player.Name;
                Get(id).Price = player.Price;
                Get(id).ShirtNumber = player.ShirtNumber;
            }
            else
            {
                throw new KeyNotFoundException($"Id {id} findes ikke");
            }

            return true;
            
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer p = Get(id);
            list.Remove(p);
            return p;
        }
    }
}
