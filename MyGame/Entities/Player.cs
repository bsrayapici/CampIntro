using MyGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Entities
{
    /// <summary>
    /// This the gamers customer entity
    /// </summary>
    public class Player : EntityBase<int>
    {
        /// <summary>
        /// Turkish National ıd of customer
        /// </summary>
        public long TurkishNationalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => ($"{FirstName} {LastName}").Trim();

        public string NickName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
