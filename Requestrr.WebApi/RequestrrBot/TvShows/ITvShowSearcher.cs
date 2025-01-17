﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Requestrr.WebApi.RequestrrBot.TvShows
{
    public interface ITvShowSearcher
    {
        Task<IReadOnlyList<SearchedTvShow>> SearchTvShowAsync(string tvShowName);
        Task<TvShow> GetTvShowDetailsAsync(int tvDbId);
        Task<IReadOnlyList<TvShow>> GetTvShowDetailsAsync(HashSet<int> tvShows, System.Threading.CancellationToken token);
        Task<SearchedTvShow> SearchTvShowAsync(int tvDbId);
    }
}