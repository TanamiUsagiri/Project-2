//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NPTReviewGame.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameCategory
    {
        public int GameCategoryID { get; set; }
        public Nullable<int> GameID { get; set; }
        public Nullable<int> CategoryID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Game Game { get; set; }
    }
}
