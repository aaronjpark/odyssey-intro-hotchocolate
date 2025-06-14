namespace Odyssey.MusicMatcher;

[GraphQLDescription("A single audio file, usaully a song.")]
public class Track
{
  [ID]
  [GraphQLDescription("The ID for the track.")]
  public string Id { get; init; }

  [GraphQLDescription("The name of the track.")]
  public string Name { get; set; }

  [GraphQLDescription("The track length in milliseconds.")]
  public double DurationMs { get; set; }

  [GraphQLDescription("Whether or not the track has explicit lyrics (true = yes it does; false = no it does not OR unknown)")]
  public bool Explicit { get; set; }

  [GraphQLDescription("The URI for the track, usually a Spotify link.")]
  public string Uri { get; set; }

  public Track(string id, string name, string uri)
  {
    Id = id;
    Name = name;
    Uri = uri;
  }
}