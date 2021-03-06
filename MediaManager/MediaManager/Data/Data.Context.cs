﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class DataEntities : DbContext
    {
        public DataEntities()
            : base("name=DataEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Band> Bands { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<PropertyOption> PropertyOptions { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<TrackProperty> TrackProperties { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MusicVideo> MusicVideos { get; set; }
        public virtual DbSet<PlayListArtist> PlayListArtists { get; set; }
        public virtual DbSet<PlayListGenre> PlayListGenres { get; set; }
        public virtual DbSet<PlayList> PlayLists { get; set; }
        public virtual DbSet<SearchCritria> SearchCritrias { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        public virtual ObjectResult<sp_GetPlayListTracks_Result> sp_GetPlayListTracks(Nullable<int> playListId, Nullable<bool> preferMisicVids, Nullable<bool> includePropertyless)
        {
            var playListIdParameter = playListId.HasValue ?
                new ObjectParameter("PlayListId", playListId) :
                new ObjectParameter("PlayListId", typeof(int));

            var preferMisicVidsParameter = preferMisicVids.HasValue ?
                new ObjectParameter("PreferMisicVids", preferMisicVids) :
                new ObjectParameter("PreferMisicVids", typeof(bool));

            var includePropertylessParameter = includePropertyless.HasValue ?
                new ObjectParameter("IncludePropertyless", includePropertyless) :
                new ObjectParameter("IncludePropertyless", typeof(bool));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetPlayListTracks_Result>("sp_GetPlayListTracks", playListIdParameter, preferMisicVidsParameter, includePropertylessParameter);
        }
    }
}
