using System;
using System.Collections.Generic;
using StackExchange.Redis;

namespace TaskListSolution
{
    public static class RedisClient
    {
        /// <summary>
        /// Maximum number of versions to store
        /// </summary>
        public const uint MaxCount = 5;

        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString = "localhost")
        {
            //string connection = "redis-13906.c100.us-east-1-4.ec2.cloud.redislabs.com:13906";
            redis = ConnectionMultiplexer.Connect("redis-13906.c100.us-east-1-4.ec2.cloud.redislabs.com:13906, password=OkHUU3wYW2sXlMlvsDGq3z9wCQ8U5Ahx, ConnectTimeout=10000, allowAdmin=true");
            database = redis.GetDatabase();
            //IServer se = redis.GetServer(connection, 13906);
            database = redis.GetDatabase();
            Console.WriteLine("Connected!");
        }

        public static string Get(string key)
        {
            if (!Exist(key))
            {
                Console.WriteLine("Application not found");
                return "";
            }
            else
            {
                return database.ListGetByIndex(key, database.ListLength(key) - 1);
            }
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static void Add(string key, string value)
        {
            if (Exist(key))
            {
                if (database.ListLength(key) <= MaxCount)
                    database.ListRightPush(key, value);
                else
                    Console.WriteLine("Too much versions");
            }
            else
            {
                database.ListRightPush(key, value);
            }
        }

        public static string Back(string key)
        {
            if (database.ListLength(key) == 0)
            {
                Console.WriteLine("No active versions. This application was deleated");
                database.KeyDelete(key);
                return "";
            }
            else
            {
                long len = database.ListLength(key);
                database.ListRemove(key, database.ListGetByIndex(key, len - 1));
                return database.ListGetByIndex(key, len - 2);
            }
        }
    }
}