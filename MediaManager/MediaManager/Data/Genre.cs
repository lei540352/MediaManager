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

    public partial class Genre
    {
        public Genre()
        {
            this.Albums = new HashSet<Album>();
            this.PlayListGenres = new HashSet<PlayListGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<PlayListGenre> PlayListGenres { get; set; }
    }
}
