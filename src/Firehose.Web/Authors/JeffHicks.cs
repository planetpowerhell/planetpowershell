using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JeffHicks : IFilterMyBlogPosts, IAmAMicrosoftMVP
    {
        public string FirstName => "Jeff";
        public string LastName => "Hicks";
        public string ShortBioOrTagLine => "Cloud and Datacenter MVP,Teacher,Author,Sensei";
        public string StateOrRegion => "New York, United States";
        public string TwitterHandle => "jeffhicks";
        public string GravatarHash => "1393cfe66dace329de043b14544985db ";

        public Uri WebSite => new Uri("https://blog.jdhitsolutions.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://jdhitsolutions.com/blog/feed"); }
        }

        public string GitHubHandle => "jdhitsolutions";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
            
        }

        public GeoPosition Position => new GeoPosition(43.035234,-76.13928);
        public string FeedLanguageCode => "en";
    }
}
