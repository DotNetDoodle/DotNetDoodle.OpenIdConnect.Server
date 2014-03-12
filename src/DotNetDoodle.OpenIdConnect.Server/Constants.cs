
namespace DotNetDoodle.OpenIdConnect.Server
{
    public static class Constants
    {
        /// <summary>
        /// Standard Claims as defined at http://openid.net/specs/openid-connect-core-1_0.html#StandardClaims
        /// </summary>
        public static class StandardClaims
        {
            /// <summary>
            /// Identifier for the End-User at the Issuer.
            /// </summary>
            public const string Subject = "sub";

            /// <summary>
            /// End-User's full name in displayable form including all name parts, possibly including 
            /// titles and suffixes, ordered according to the End-User's locale and preferences.
            /// </summary>
            public const string Name = "name";

            /// <summary>
            /// Given name(s) or first name(s) of the End-User. Note that in some cultures, people can have multiple 
            /// given names; all can be present, with the names being separated by space characters.
            /// </summary>
            public const string GivenName = "given_name";
        }
    }
}