using AutoFixture;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            var fixture = new Fixture();
            var dateTime = fixture.Create<DateTime>();

            return new RegistrationUser
            {
                FirstName = fixture.Create<string>(),
                LastName = fixture.Create<string>(),
                Year = dateTime.Year.ToString(),
                Month = dateTime.Month.ToString(),
                Date = dateTime.Day.ToString(),
                Password = fixture.Create<string>(),
                Gender = "Male",
                PostCode = fixture.Create<int>().ToString(),


            };
        }

    }
}
