﻿using ObjectManager.Rest.Common;
using ObjectManager.Rest.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ObjectManager.Rest.V2.Models
{
    internal class RestObject
    {
        public RestObject(int artifactId) => this.ArtifactId = artifactId;
        public int ArtifactId { get; set; }
    }

    internal class RelativityObjectRestReadPrep
    {
        internal class RequestObj
        {
            public RestObject Object { get; set; }
            public IEnumerable<object> Fields { get; set; }
        }


        public RequestObj Request { get; set; }

        public static RelativityObjectRestReadPrep Prep(RelativityObject obj)
        {
            var ret = new RelativityObjectRestReadPrep();
            ret.Request = new RequestObj();
            ret.Request.Object = new RestObject(obj.ArtifactId);
            var fields = obj?.FieldValues?.Where(x => x.Field != null).Select(x => RestFieldHelpers.Parse(x.Field)).ToList();
            ret.Request.Fields = fields ?? new List<object> { new NameRestField("Artifact Id") };
            return ret;
        }
    }
}
