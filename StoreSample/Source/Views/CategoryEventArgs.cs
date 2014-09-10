using System;

namespace Store
{
    public class CategoryEventArgs : EventArgs
    {
        public CategoryEventArgs(Category category)
        {
            Category = category;
        }

        public Category Category { get; private set; }
    }
}