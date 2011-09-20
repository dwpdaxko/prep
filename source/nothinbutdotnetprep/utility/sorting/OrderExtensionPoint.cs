using System;

namespace nothinbutdotnetprep.utility.sorting
{
    public class OrderExtensionPoint<ItemToSort, PropertyType>
    {
        public Func<ItemToSort, PropertyType> accessor;

        public OrderExtensionPoint(Func<ItemToSort, PropertyType> accessor)
        {
            this.accessor = accessor;
        }
    }
}