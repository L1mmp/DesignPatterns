using System;

namespace DesignPatterns.Patterns.Singleton
{
    public sealed class Database
    {
        private Database() { }
        private static Database _instance;

        public static Database GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Database();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        public void ExecuteSqlExpression(string sql)
        {
            Console.WriteLine(sql); 
        }
    }
}