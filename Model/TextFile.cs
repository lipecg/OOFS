using System;

namespace OOFS.Model 
{
    public class TextFile : BaseEntity
    {
        private string content;

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public override int Size
        {
            get 
            {
                return content.Length;
            }
        }
    }
}