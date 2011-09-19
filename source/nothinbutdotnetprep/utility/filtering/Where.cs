using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class Where<ItemToFilter>
    {
        public static Something has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            throw new NotImplementedException();
        }
    }
}