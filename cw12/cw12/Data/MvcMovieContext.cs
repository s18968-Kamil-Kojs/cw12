﻿using Microsoft.EntityFrameworkCore;
using cw12.Models;

namespace MvcMovie.Data {

    public class MvcMovieContext :DbContext {

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options) {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}