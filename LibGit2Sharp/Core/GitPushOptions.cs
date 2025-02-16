﻿using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal class GitPushOptions
    {
        public int Version = 1;
        public int PackbuilderDegreeOfParallelism;
        public GitRemoteCallbacks RemoteCallbacks;
        public GitProxyOptions ProxyOptions;
        public RemoteRedirectMode FollowRedirects = RemoteRedirectMode.Auto;
        public GitStrArrayManaged CustomHeaders;
    }
}
