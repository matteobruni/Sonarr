﻿using System.Collections.Generic;

namespace NzbDrone.Api.Notifications
{
    public class NotificationResource : ProviderResource
    {
#warning FIXME: Unused.
        public string Link { get; set; }
        public bool OnGrab { get; set; }
        public bool OnDownload { get; set; }
        public bool OnUpgrade { get; set; }
        public bool OnRename { get; set; }
        public bool SupportsOnGrab { get; set; }
        public bool SupportsOnDownload { get; set; }
        public bool SupportsOnUpgrade { get; set; }
        public bool SupportsOnRename { get; set; }
#warning FIXME: Unused.
        public string TestCommand { get; set; }
        public HashSet<int> Tags { get; set; }
    }
}