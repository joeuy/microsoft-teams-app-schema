using Microsoft.SkypeSpaces.MiddleTier.BackendServices.OfficeStore.Models.TeamsAppManifest.Extensions;
using Microsoft.Teams.AppSchema.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Teams.AppSchema
{
    public partial class MicrosoftTeamsAppSchema_v1_0 : IAppDefinition
    {
        INameDefinition IAppDefinition.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IDescriptionDefinition IAppDefinition.Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IDeveloperDefinition IAppDefinition.Developer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IEnumerable<string> IAppDefinition.ValidDomains { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IEnumerable<IBotDefinition> IAppDefinition.Bots
        {
            get
            {
                return this.Bots.NullSafeSelectToArray(bot => new BotDefinition());
            }
            set => throw new NotImplementedException(); }
    }
}
