using System;

namespace OOFS.Model 
{
    public class Drive : BaseContainer
    {
        public Drive(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }
        public override BaseContainer Parent
        {
            get
            {
                throw new Exception("A drive is not contained in any other entity.");
            }
        }
    }
}