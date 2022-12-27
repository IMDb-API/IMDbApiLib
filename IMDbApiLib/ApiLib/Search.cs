﻿using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<SearchData> SearchAsync(string expression)
        {
            try
            {
                expression = PrepareExpression(expression);
                string url = $"{BaseUrl}/en/API/Search/{_apiKey}/{expression}";
                return await ApiUtils.GetObjectAsync<SearchData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new SearchData() { ErrorMessage = ex.Message };
            }
        }
    }
}
