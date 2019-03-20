using StackExchange.Redis;

namespace RedisCrudApi.Business.Facade.Repositories
{
    public class StudentRepository
    {
        ConnectionMultiplexer redis;
        public StudentRepository()
        {
            // This should be injected but for simplicity I will do it like this
            redis = ConnectionMultiplexer.Connect("localhost:6379");
        }

        public string CreateStudent(string key, string value) 
        {
            IDatabase db = redis.GetDatabase();
            db.StringSet(key, value);
            return db.StringGet(key);
        }

        public string ReadStudent(string key) 
        {
            IDatabase db = redis.GetDatabase();
            return db.StringGet(key);
        }

        public string UpdateStudent(string key, string value) 
        {
            IDatabase db = redis.GetDatabase();
            db.StringSet(key, value);
            return db.StringGet(key);
        }

        public string DeleteStudent(string key) 
        {
            IDatabase db = redis.GetDatabase();
            db.KeyDelete(key);
            return db.StringGet(key);
        }
    }
}