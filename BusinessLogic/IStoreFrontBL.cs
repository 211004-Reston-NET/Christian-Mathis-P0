using System.Collections.Generic;
using Models;

namespace BusinessLogic
{
    public interface IStoreFrontBL
    {
        /// <summary>
        /// This will return a list of StoreFronts stored in the database
        /// </summary>
        /// <returns>It will return a list of StoreFronts</returns>
        List<StoreFront> GetStoreFrontList();
    }
}