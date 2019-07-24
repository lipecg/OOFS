using System;
using System.Collections.Generic;

namespace OOFS.Model 
{
    public abstract class BaseContainer : BaseEntity
    {
        private List<BaseEntity> children;
        
        public override int Size 
        {
            get
            {
                return children.Count;
            }
        }

        public List<BaseEntity> Children
        {
            get 
            {
                return children;
            }
        }
    }
}