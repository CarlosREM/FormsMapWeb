using System;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Collections.Generic;

public class DBManager
{

    private static IFirebaseConfig config = new FirebaseConfig
    {
        AuthSecret = "1IvmhMQlGJV1wIjiin6g5vrhXoqqTF56hTEd93tm",
        BasePath = "https://formsmap-ac3a9.firebaseio.com/"
    };
    private static IFirebaseClient client = null;

    private static IFirebaseClient getClient()
    {
        if (client == null) {
            client = new FireSharp.FirebaseClient(config);
        }
        return client;
    }
}