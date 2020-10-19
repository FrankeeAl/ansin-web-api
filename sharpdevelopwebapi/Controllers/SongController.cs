using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SharpDevelopWebApi.Models;

namespace SharpDevelopWebApi.Controllers
{
    public class SongController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetSong()
        {
            var songs = new List<Song>();

            var mySong = new Song();
            mySong.Id = 4;
            mySong.Title = "Roxanne";
            mySong.Artist = "Arizona Zervas";
            mySong.Genre = "RnB/HipHop";
            songs.Add(mySong);

            var song1 = new Song();
            song1.Id = 1;
            song1.Title = "You";
            song1.Artist = "Basil Valdez";
            song1.Genre = "Pop";
            songs.Add(song1);

            var song2 = new Song();
            song2.Id = 2;
            song2.Title = "Heaven Knows";
            song2.Artist = "Orange and Lemon";
            song2.Genre = "OPM";
            songs.Add(song2);

            var song3 = new Song();
            song3.Id = 3;
            song3.Title = "Versace on the floor";
            song3.Artist = "Bruno Mars";
            song3.Genre = "RnB";
            songs.Add(song3);

            return Ok(songs);
        }
    }
}
