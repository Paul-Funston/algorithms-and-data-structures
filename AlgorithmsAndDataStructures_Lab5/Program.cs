/*
 Using Stacks and Queues where appropriate, create a simple command line playlist app that allows a user to add a song to a playlist. Provide commands to play the next song, skip the next song, or add a new song to the playlist. Users should be able to rewind by one song many times to play a previous track.

Example user experience:

Choose an option:
1. Add a song to your playlist
2. Play the next song in your playlist

3. Skip the next song

4. Rewind one song

5. Exit

> 1

Enter Song Name: > Enter Sandman

"Enter Sandman" added to your playlist.

Next song - "Enter Sandman"

1. Add a song to your playlist
2. Play the next song in your playlist

3. Skip the next song

4. Rewind one song

> 1

Enter Song Name: > "Dr. Feelgood"

"Dr. Feelgood" added to your playlist.

Next song "Enter Sandman"

1. Add a song to your playlist
2. Play the next song in your playlist

3. Skip the next song

4. Rewind one song

> 2

Now playing "Enter Sandman"

Next song "Dr. Feelgood"

1. Add a song to your playlist
2. Play the next song in your playlist

3. Skip the next song

4. Rewind one song
 */

Queue<string> playlist = new();
Stack<string> played = new();
bool programRunning = true;
string songPlaying = "";
bool isPlaying = false;

while (programRunning)
{
    int option = -1;
    
    if (!string.IsNullOrEmpty(songPlaying))
    {
        Console.WriteLine($"Now Playing \"{songPlaying}\"");
    }
    if(playlist.Count > 0) 
    {
        Console.WriteLine($"Next Song \"{playlist.First()}\"");
    }

    Console.WriteLine();
    Console.WriteLine("Choose an Option");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");

    Console.Write("> ");
    char input = Console.ReadKey().KeyChar;
    option = (int)char.GetNumericValue(input);

    while(option > 5 || option < 1)
    {
        Console.Write("> ");
        option = (int)char.GetNumericValue(Console.ReadKey().KeyChar);
    }
    Console.WriteLine();

    // Exit
    if (option == 5) { programRunning = false; }

    // ADDING A SONG
    if (option == 1)
    {
        Console.Write("Enter Song Name: > ");
        string newSong = Console.ReadLine().Trim();

        while (string.IsNullOrEmpty(newSong))
        {
            newSong = Console.ReadLine().Trim();
        }

        playlist.Enqueue(newSong);
        Console.WriteLine($"{newSong} added to playlist");
        Console.WriteLine();
    }


    // PLAYING NEXT SONG
    if (option == 2)
    {
        if (playlist.Count > 0)
        {
            if (!String.IsNullOrEmpty(songPlaying)) { played.Push(songPlaying); }
            songPlaying = playlist.Dequeue();
        } else
        {
            Console.WriteLine("Add a song first");
        }
    }

    // SKIPPING SONG
    if (option == 3)
    {
        Console.WriteLine($"{playlist.First()} Skipped and added to the end of the playlist.");
        playlist.Enqueue(playlist.Dequeue());
        
    }


    // REWIND SONG

    if (option == 4)
    {
        if ( played.Count < 1 ) 
        {
            Console.WriteLine( "\nYou are at the start of the playlist. "); 
        } else 
        {     
            Queue<string> tempPlaylist = new();

            tempPlaylist.Enqueue(songPlaying);

            while( playlist.Count > 0)
            {
                tempPlaylist.Enqueue(playlist.Dequeue());
            }

            playlist = tempPlaylist;
            songPlaying = played.Pop();
        } 
    }



    // Console.WriteLine();
}
// .Enqueue(songPlaying).Enqueue(playlist)





