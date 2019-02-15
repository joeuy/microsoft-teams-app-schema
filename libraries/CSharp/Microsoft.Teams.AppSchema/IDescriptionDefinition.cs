namespace Microsoft.Teams.AppSchema
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IDescriptionDefinition
    {
        /// <summary>
        /// A short description of the app
        /// </summary>
        string Short { get; set; }

        /// <summary>
        /// A full description of the app
        /// </summary>
        string Full { get; set; }
    }
}
