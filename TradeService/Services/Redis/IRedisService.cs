﻿namespace TradeService.Services.Redis
{
    public interface IRedisService
    {
        Task<string> GetValueAsync(string key);
        Task SetValueAsync(string key, string value);
    }
}
