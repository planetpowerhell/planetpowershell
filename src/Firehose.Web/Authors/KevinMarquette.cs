using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KevinMarquette : IAmACommunityMember
    {
        public string FirstName => "Kevin";
        public string LastName => "Marquette";
        public string ShortBioOrTagLine => "Sr. DevOps Engineer. Powershell all the things!";
        public string StateOrRegion => "Orange County, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "kevinmarquette";
        public string GitHubHandle => "kevinmarquette";
        public string GravatarHash => "e5a95c365e8f06786d6439474bc733df";
        public GeoPosition Position => new GeoPosition(33.6800000,-117.7900000);

        public Uri WebSite => new Uri("http://kevinmarquette.github.io");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://kevinmarquette.github.io/feed.xml"); } }
    }
}
