using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class MattMcNabb : IAmACommunityMember
    {
        public string FirstName => "Matt";
        public string LastName => "McNabb";
        public string ShortBioOrTagLine => "Systems Engineer and PowerShell enthusiast; erratic blogger";
        public string StateOrRegion => "Ohio";
        public string EmailAddress => "mmcnabb@outlook.com";
        public string TwitterHandle => "mcnabbmh";
        public string GitHubHandle => "mattmcnabb";
        public GeoPosition Position => new GeoPosition(39.403986, -84.406761);
        public Uri WebSite => new Uri("https://mattmcnabb.github.io");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://mattmcnabb.github.io/feed.xml"); } }
<<<<<<< HEAD
        public string GravatarHash => "";
=======
        public string GravatarHash => "719f5e885b7641673038f02b79923f1a";
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}
