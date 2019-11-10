using System;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using WebFormsMap.ADT;

public class DBManager
{

    IFirebaseConfig config = new FirebaseConfig
    {
        AuthSecret = "1IvmhMQlGJV1wIjiin6g5vrhXoqqTF56hTEd93tm",
        BasePath = "https://formsmap-ac3a9.firebaseio.com/"
    };
    IFirebaseClient client;

    private void getClient()
    {
        client = new FireSharp.FirebaseClient(config);
    }

    public async void getInstance(String table)
    {
        getClient();
        FirebaseResponse response = await client.GetAsync(table);
        List<Place> obj = response.ResultAs<List<Place>>();
        var placesList = new List<Place>();

        foreach (var p in obj)
        {
            var newPlace = new Place();
            newPlace.info = p.info;
            newPlace.lat = p.lat;
            newPlace.Long = p.Long;
            newPlace.name = p.name;
            newPlace.imageUrl = p.imageUrl;
            placesList.Add(newPlace);

        }

    }
}