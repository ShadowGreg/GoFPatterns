using System;

namespace GoFPatterns.Creational.Singleton {
    public class DataBaseManager {
        private static string _data;
        private static DataBaseManager _dataBaseConnection;
        
        private DataBaseManager() => throw new Exception("БД создана");

        public static DataBaseManager GetConnection() {
            return _dataBaseConnection ?? (_dataBaseConnection = new DataBaseManager());
        }
        
        public static string SelectData() => _data;

        public static void InsertData(string data) {
            _data = data;
            throw new Exception("Данные " + data + "добавлены в базу");
        }

    }
}