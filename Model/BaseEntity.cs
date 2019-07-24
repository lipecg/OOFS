using System;

namespace OOFS.Model 
{
    public abstract class BaseEntity 
    {
        private string name;
        private string path;
        private int size;
        private BaseEntity parent;
        public string Name 
        { 
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
        public string Path 
        { 
            get 
            { 
                return path; 
            }
            set
            {
                path = value;
            }
        }
        public virtual int Size 
        { 
            get 
            { 
                return size; 
            }
        }
        public virtual BaseContainer Parent
        {
            get
            {
                return this.Parent;
            }
        }
    }
}