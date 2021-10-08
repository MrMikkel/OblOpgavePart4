using System;

namespace Football
{
    public class FootballPlayer
    {
        //Id, et tal
        //Name, tekst-streng, min 4 tegn langt
        //Price, tal, price > 0
        //ShirtNumber, 1 <= ShirtNumber<= 100

        static int idnr = 0;
        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;

        public FootballPlayer(string name, int price, int shirtnumber)
        {
            _id = FootballPlayer.idnr;
            FootballPlayer.idnr++;
            Name = name;
            Price = price;
            ShirtNumber = shirtnumber;
        }

        //public FootballPlayer(int id, string name, int price, int shirtnumber)
        //{
        //    Id = id;
        //    Name = name;
        //    Price = price;
        //    ShirtNumber = shirtnumber;
        //} backup

        public int Id
        {
            get => _id;
            set
            {
                if (value == 0) throw new ArgumentException();
                _id = value;
            }
        }
        //backup
        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value == 0 || value < 0) throw new ArgumentOutOfRangeException();
                
                _price = value;
            }
        }
        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value >= 1 && value <= 100)
                _shirtNumber = value;
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        
    }
}
