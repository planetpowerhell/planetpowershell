﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class ToreGroneng : IAmACommunityMember
    {
        public string FirstName => "Tore";
        public string LastName => "Groneng";
        public string ShortBioOrTagLine => "Focus on Powershell, Azure, Cloud, System Center and Powershell DSC. Automate everything.";
        public string StateOrRegion => "Bergen, Norway";
        public string EmailAddress => "tore.groneng@gmail.com";
        public string TwitterHandle => "ToreGroneng";
        public string GitHubHandle => "torgro";
<<<<<<< HEAD
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(60.4698789, 5.3307659);

        public Uri WebSite => new Uri("http://asaconsultant.blogspot.no");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://asaconsultant.blogspot.com/feeds/posts/default/-/Powershell"); } }
    }
}
=======
        public string GravatarHash => "5179a5eb394ca18bf14daa4e3987989b";
        public GeoPosition Position => new GeoPosition(60.4698789, 5.3307659);

        public Uri WebSite => new Uri("https://asaconsultant.blogspot.no");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://asaconsultant.blogspot.com/feeds/posts/default/-/Powershell"); } }
        public string FeedLanguageCode => "en";
    }
}
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
