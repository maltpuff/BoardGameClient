using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SQLiteUnity;

namespace SQLiteUnity
{
    public class DBTest : MonoBehaviour
    {
        // DB
        public static SQLite dataBase;
        // 出力先
        public static Text playerName;

        // 準備 
        private void Awake()
        {
            playerName = GetComponentInChildren<Text>();
        }

        // データベース読み込み
        void Start()
        {
            playerName.text = "SQLiteUnity Test Start\n\n";
            Debug.Log("Start");
            /*
            // DB接続とテスト (初回は生成)
            using (dataBase = new SQLite("DB_test.db",))
            {

            }*/            
            
            // 保存場所の報告
            playerName.text += $"\npath {Application.persistentDataPath}";
            Debug.Log(Application.persistentDataPath);
        }

        // Update is called once per frame
        /*
        void Update()
        {

        }
        */
        
    }
}
public class PlayerProfileModel
{
    public string plaer_id;
    public string player_name;
}

public static class PlayerProfile {

    public static void CreateTable()
    {
        string query = "create table if not exists user_profile(player_id text,player_name text)";
        //SqliteDatabase sqlDB =
    }


    public static void Set(PlayerProfileModel plater_prof)
    {

    }
}