//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaManager.Data
{
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        public User()
        {
            this.TrackProperties = new HashSet<TrackProperty>();
            this.PlayLists = new HashSet<PlayList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TrackProperty> TrackProperties { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}