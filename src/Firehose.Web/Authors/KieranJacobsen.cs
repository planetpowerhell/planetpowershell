﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KieranJacobsen : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Kieran";
        public string LastName => "Jacobsen";
        public string ShortBioOrTagLine => "Readifarian, works with PowerShell";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "code@poshsecurity.com";
        public string TwitterHandle => "kjacobsen";
        public string GravatarHash => "ed4cadbdf180e7da1ce81da17126e571";
        public Uri WebSite => new Uri("https://poshsecurity.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://poshsecurity.com/blog/?format=rss"); }
        }
        public string GitHubHandle => "kjacobsen";
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("powershell")) ?? false;
        }
        public GeoPosition Position => new GeoPosition(-37.816667, 144.966667);
        public string FeedLanguageCode => "en";
    }
}
