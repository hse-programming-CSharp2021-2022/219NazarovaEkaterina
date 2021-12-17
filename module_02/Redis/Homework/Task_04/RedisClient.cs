using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace TaskSetSolution
{
    public static class RedisClient
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString = "localhost")
        {
            redis = ConnectionMultiplexer.Connect("redis-13906.c100.us-east-1-4.ec2.cloud.redislabs.com:13906, password=OkHUU3wYW2sXlMlvsDGq3z9wCQ8U5Ahx, ConnectTimeout=10000, allowAdmin=true");
            database = redis.GetDatabase();
            database = redis.GetDatabase();
            Console.WriteLine("Connected!");
        }

        public static void Add(string key, string value)
        {
            //if (Exist(key))
            //{
                database.SetAdd(key, value);
            //}
            //else
            //{
            //    Console.WriteLine("Storage does not exist");
            //}
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static bool ExistProduct(string key, string productName)
        {
            return database.SetContains(key, productName);
        }

        public static List<string> GetProducts(string key)
        {
            RedisValue[] values = database.SetMembers(key);
            return values.ToStringArray()
                .ToList();
        }
    }
}