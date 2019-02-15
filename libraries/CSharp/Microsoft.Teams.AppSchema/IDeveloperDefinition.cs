namespace Microsoft.Teams.AppSchema
{
    public interface IDeveloperDefinition
    {
        /// <summary>
        /// The display name for the developer
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The url to the developer's website
        /// </summary>
        string WebsiteUrl { get; set; }

        /// <summary>
        /// The url to the developer's privacy policy
        /// </summary>
        string PrivacyUrl { get; set; }

        /// <summary>
        /// The url to the developer's terms of use
        /// </summary>
        string TermsOfUseUrl { get; set; }
    }
}
