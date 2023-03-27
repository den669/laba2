
        Client client = new Client(new WindowsButtonFactory());
        client.Run();

        client = new Client(new IOSButtonFactory());
        client.Run();

        client = new Client(new AndroidButtonFactory());
        client.Run();
    