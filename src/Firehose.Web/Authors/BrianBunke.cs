﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BrianBunke : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Brian";
        public string LastName => "Bunke";
        public string ShortBioOrTagLine => "A self-deprecating Systems Automator interested in learning, testing, documenting, and open source.";
        public string StateOrRegion => "WA, USA";
        public string EmailAddress => "me@brianbunke.com";
        public string TwitterHandle => "brianbunke";
        public string GitHubHandle => "brianbunke";
<<<<<<< HEAD
        public string GravatarHash => "";

        public GeoPosition Position => new GeoPosition(48.751911, -122.478685);

        public Uri WebSite => new Uri("http://www.brianbunke.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.brianbunke.com/feed.xml"); }
=======
        public string GravatarHash => "5eb2b9485a755280dc633d2a9ab2160b";

        public GeoPosition Position => new GeoPosition(48.751911, -122.478685);

        public Uri WebSite => new Uri("https://www.brianbunke.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.brianbunke.com/feed.xml"); }
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
<<<<<<< HEAD
=======
        public string FeedLanguageCode => "en";
>>>>>>> 9eab8079ac1607d478edbee7c9564718e09a7ded
    }
}
