using LiveDemoSeleniumAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Factories
{
    public static class PracticeFormFactory
    {
        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {
                FirstName = "Marti",
                LastName = "Bolen",
                Email = "ma@abv.bg",
                PhoneNumber = "0896567896",
            };
    }
    }
}
