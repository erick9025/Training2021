using System;
using System.Collections.Generic;

namespace Inheritance.Exercise1
{
    public class Man : Human
    {
        bool isHandsome;

        //Constructor
        public Man(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// From here we have methods/behaviors
        /// </summary>

        public void WatchFootball(int gamesWatched, List<string> teamsWatched = null)
        {
            int minutesWatched = gamesWatched * 90;

            //Print minutes watched

            //if list provided, print teams
        }

        public new void Move()
        {
            //Do something
        }

        public new void Breath()
        {
            //Do something
        }
    }
}
