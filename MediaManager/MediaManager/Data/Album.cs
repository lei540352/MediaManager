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

    public partial class Album
    {
        public Album()
        {
            this.Tracks = new HashSet<Track>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreID { get; set; }
        public int BandID { get; set; }

        public virtual Band Band { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
