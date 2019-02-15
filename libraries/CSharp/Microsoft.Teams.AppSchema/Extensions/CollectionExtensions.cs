//-----------------------------------------------------------------------
// <copyright file="CollectionExtensions.cs" company="Microsoft">
//     Copyright © Microsoft Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Microsoft.SkypeSpaces.MiddleTier.BackendServices.OfficeStore.Models.TeamsAppManifest.Extensions
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public static class CollectionExtensions
    {
        public static TResult[] NullSafeSelectToArray<TSource, TResult>(this Collection<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null)
            {
                return null;
            }

            return source.Select(selector).ToArray();
        }
    }
}
