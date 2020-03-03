using System;
using System.Collections.Generic;
using System.Text;

namespace WePass.Infra.Entities.Base
{
    public class EntityComplexBase : EntityBase
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
