using Microsoft.AspNetCore.Identity;
using System;

namespace ProjectWebapplicaties.Areas.Identity.Data
{
    public class CustomUser: IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }

        public string Familienaam { get; set; }

        public string Straatnaam { get; set; }

        public string Huisnummer { get; set; }

        public string Postcode { get; set; }

        public string Gemeente { get; set; }

    }
}
