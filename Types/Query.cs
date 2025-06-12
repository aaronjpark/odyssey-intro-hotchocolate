using SpotifyWeb;

namespace Odyssey.MusicMatcher;

public class Query
{
  // where Query resolver functions will go

  [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
  public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
  {
    var response = await spotifyService.GetFeaturedPlaylistsAsync();
    // var items = response.Playlists.Items;
    // var playlists = items.Select(item => new Playlist(item));

    return response.Playlists.Items.Select(item => new Playlist(item)).ToList();
  }
}