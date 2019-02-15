namespace Microsoft.Teams.AppSchema
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface INameDefinition
    {
        /// <summary>
        /// A short name of the app
        /// </summary>
        string Short { get; set; }

        /// <summary>
        /// A full name of the app
        /// </summary>
        string Full { get; set; }
    }
}
