﻿using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Entities;

namespace MediaBrowser.Controller.Providers
{
    public interface IMetadataService
    {
        /// <summary>
        /// Determines whether this instance can refresh the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if this instance can refresh the specified item; otherwise, <c>false</c>.</returns>
        bool CanRefresh(IHasMetadata item);

        /// <summary>
        /// Refreshes the metadata.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="refreshOptions">The options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task RefreshMetadata(IHasMetadata item, MetadataRefreshOptions refreshOptions, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <value>The order.</value>
        int Order { get; }
    }
}
