using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.Networking;
using System;
using System.Threading.Tasks;
//using MongoDB.Bson;
//using MongoDB.Driver;

public class PlayerData : MonoBehaviour
{

    public string plummie_tag;
    public int collisions;
    public int steps;

    //private MongoClient mongoClient;
    //private IMongoDatabase database;
    //private IMongoCollection<BsonDocument> collection;

    private const string connectionString = "plummie_game_save"; 
    private const string databaseName = "<Plummie_Database>";
    private const string collectionName = "progression";


    public string Stringify() {
        return JsonUtility.ToJson(this);
    }

    public static PlayerData Parse(string json)
    {
        return JsonUtility.FromJson<PlayerData>(json);
    }

    public void FetchPlayerData()
    {
        
    }

    public void SavePlayerData()
    {
        
    }

    private void Start()
    {
        
       // mongoClient = new MongoClient(connectionString);
       // database = mongoClient.GetDatabase(databaseName);
       // collection = database.GetCollection<BsonDocument>(collectionName);
    }

    public async Task SavePlayerScoreAsync(int playerScore)
    {
        try
        {
            // Create a JSON document with the score data
            //var document = new BsonDocument
            //{
            //    { "game", "<NomPrenomEtudiant>_fall_guy" },
            //    { "score", playerScore },
           //     { "timestamp", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") }
            //};

            Debug.Log("Connecting to the database...");

            // Insert the document into the MongoDB collection
            //await collection.InsertOneAsync(document);

            Debug.Log("Score saved successfully.");
        }
        catch (Exception e)
        {
            Debug.LogError($"Failed to save score: {e.Message}");
        }
    }

    
}
