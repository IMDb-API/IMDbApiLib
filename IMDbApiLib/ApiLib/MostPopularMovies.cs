﻿using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<MostPopularData> MostPopularMoviesAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/MostPopularMovies/{_apiKey}";
                return await Utils.DownloadObjectAsync<MostPopularData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new MostPopularData() { ErrorMessage = ex.Message };
            }
        }
    }
}
