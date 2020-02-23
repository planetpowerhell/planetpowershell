using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SebastianFeldmann : IAmACommunityMember
    {
        public string FirstName => "Sebastian";
        public string LastName => "Feldmann";
        public string ShortBioOrTagLine => "dad, musician, sysadmin";
        public string StateOrRegion => "Bremen, Germany";
        public string EmailAddress => "sebastian@feldmann.io";
        public string TwitterHandle => "sebfieldman";
        public string GravatarHash => "36fca3ceda7415942ff31f2bad2a8e62";
        public string GitHubHandle => "seebus";
        public GeoPosition Position => new GeoPosition(53.073635, 8.806422);

        public Uri WebSite => new Uri("https://blog.feldmann.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.feldmann.io/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}
