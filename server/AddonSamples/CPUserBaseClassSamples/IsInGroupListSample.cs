﻿
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsInGroupListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // List of group ID numbers
            string groupIdCommaList = "1,2,3";
            int userId = cp.User.Id;

            if(cp.User.IsInGroupList(groupIdCommaList, userId))
            {
                return cp.User.Name + " belongs to one or more"
                    + " of the listed groups.";
            } else
            {
                return cp.User.Name + " does not belongs to any"
                    + " of the listed groups.";
            }
        }
    }
}