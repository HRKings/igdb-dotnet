using System;

namespace IGDB.Models
{
  public class Franchise : ITimestamps, IIdentifier
  {
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public long? Id { get; set; }
    public IdentitiesOrValues<Game> Games { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Url { get; set; }
  }
}