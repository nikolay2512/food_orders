﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HWOrderFood.Enums;

namespace HWOrderFood.Services.Rest
{
    public interface IRestService
    {
        Task<T> GetAsyncWithCashe<T>(string resource, TimeSpan experation, StorageType storageType, Dictionary<string, string> additioalHeaders = null);

        Task<T> GetAsync<T>(string resource, Dictionary<string, string> additioalHeaders = null);

        Task<T> PutAsync<T>(string resource, object requestBody, Dictionary<string, string> additioalHeaders = null);

        Task<T> DeleteAsync<T>(string resource, Dictionary<string, string> additioalHeaders = null);

        Task<T> DeleteAsync<T>(string resource, object requestBody, Dictionary<string, string> additioalHeaders = null);

        Task<T> PostAsync<T>(string resource, object requestBody, Dictionary<string, string> additioalHeaders = null);
    }
}
