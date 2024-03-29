﻿using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<byte[]> ResizeImageAsync(string size, string url)
        {
            try
            {
                url = ResizeImageUrl(size, url);
                return await ApiUtils.GetBytesAsync(url, webProxy: WebProxy);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ResizeImageSaveFileAsync(string size, string url, string filePath)
        {
            try
            {
                url = ResizeImageUrl(size, url);
                await ApiUtils.SaveFileAsync(url,filePath, webProxy: WebProxy);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ResizeImageUrl(string size, string url)
        {
            try
            {
                url = $"{BaseUrl}/API/ResizeImage?apiKey={_apiKey}&size={size}&url={url}";
                return url;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}