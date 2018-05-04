﻿using ObjectManager.Rest.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectManager.Rest.Legacy
{
    internal class RSAPIObjectManager : IObjectManager
    {
        public RSAPIObjectManager()
        {

        }

        public Task<RelativityObject> ReadAsync(int workspaceId, RelativityObject obj, CallingContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task<RelativityObject> ReadAsync(int workspaceId, RelativityObject obj, CallingContext context, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }

        public Task<ObjectUpdateResult> UpdateAsync(int workspaceId, RelativityObject obj, CallingContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task<ObjectUpdateResult> UpdateAsync(int workspaceId, RelativityObject obj, CallingContext context, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }
    }
}
