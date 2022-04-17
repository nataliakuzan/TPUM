using System;

namespace Shop.Data
{
    internal class Tag
    {
        private String TagName;

        public Tag(String Name)
        {
            TagName = Name;
        }

        public String Name
        {
            get
            {
                return TagName;
            }
        }
    }
}
