//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlayerSelector
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerInSeasons
    {
        public int Id { get; set; }
        public int numberOfGoals { get; set; }
        public int numberOfGames { get; set; }
        public Nullable<int> player_Id { get; set; }
        public Nullable<int> season_Id { get; set; }
    
        public virtual Players Players { get; set; }
        public virtual Seasons Seasons { get; set; }
    }
}
