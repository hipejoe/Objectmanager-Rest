﻿using ObjectManager.Rest.Interfaces;
using ObjectManager.Rest.Interfaces.Authentication;
using ObjectManager.Rest.Legacy;
using ObjectManager.Rest.V1;
using ObjectManager.Rest.V2;
using System.Threading.Tasks;

namespace ObjectManager
{
    public class ObjectManagerFactory : IObjectManagerFactory
    {
        private readonly IRelativityVersionResolver _versionResolver;

        public ObjectManagerFactory(IRelativityVersionResolver versionResolver)
        {
            _versionResolver = versionResolver;
        }
        public async Task<IObjectManager> GetObjectManagerAsync(string host, IAuthentication authentication)
        {
            var version = await _versionResolver.GetRelativityVersionAsync();
            if (version == new System.Version("9.5.411.4"))
            {
                return new ObjectManagerV1(host, authentication);
            }
            else if (version >= new System.Version("9.6.50.31"))
            {
                return new ObjectManagerV2(host, authentication);
            }
            else
            {
                return new RSAPIObjectManager();
            }

        }
    }
}