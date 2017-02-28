using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ThomasRayner : IAmAMicrosoftMVP
    {
        public string FirstName => "Thomas";
        public string LastName => "Rayner";
        public string ShortBioOrTagLine => "Microsoft MVP - Cloud & Datacenter Management";
        public string StateOrRegion => "Canada";
        public string EmailAddress => "thmsrynr@outlook.com";
        public string TwitterHandle => "MrThomasRayner";
        public string GitHubHandle => "ThmsRynr";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(53.5443890, -113.4909270);

        public Uri WebSite => new Uri("http://workingsysadmin.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://workingsysadmin.com/feed/"); } }
    }

}
