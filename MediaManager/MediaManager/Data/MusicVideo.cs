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

    public partial class MusicVideo
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public int MusicVideoId { get; set; }

        public virtual Track Track { get; set; }
        public virtual Track Track1 { get; set; }
    }
}
