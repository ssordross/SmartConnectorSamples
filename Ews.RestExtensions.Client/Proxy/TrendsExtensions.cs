﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Trends.
    /// </summary>
    public static partial class TrendsExtensions
    {
            /// <summary>
            /// Creates a new Trend and returns it.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='newItem'>
            /// Definition of how the Trend will be created.
            /// </param>
            public static TrendModel Create(this ITrends operations, NewTrendModel newItem)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).CreateAsync(newItem), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Trend and returns it.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='newItem'>
            /// Definition of how the Trend will be created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrendModel> CreateAsync(this ITrends operations, NewTrendModel newItem, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(newItem, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all Trend which fit the filter criteria supplied. All filter
            /// parameters are optional. Trend will be ordered and paged as requested.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Return only Trend whose name contains this value.
            /// </param>
            /// <param name='orderBy'>
            /// Trend will be returned in this order.  NameAscending by default. Possible
            /// values include: 'NameAscending', 'NameDescending'
            /// </param>
            /// <param name='take'>
            /// Number of Trend that should be returned.  200 by default.
            /// </param>
            /// <param name='skip'>
            /// Number of Trend that should be skipped before items are returned.  0 by
            /// default.
            /// </param>
            public static IList<TrendModel> Retrieve(this ITrends operations, string name = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?))
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveAsync(name, orderBy, take, skip), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all Trend which fit the filter criteria supplied. All filter
            /// parameters are optional. Trend will be ordered and paged as requested.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Return only Trend whose name contains this value.
            /// </param>
            /// <param name='orderBy'>
            /// Trend will be returned in this order.  NameAscending by default. Possible
            /// values include: 'NameAscending', 'NameDescending'
            /// </param>
            /// <param name='take'>
            /// Number of Trend that should be returned.  200 by default.
            /// </param>
            /// <param name='skip'>
            /// Number of Trend that should be skipped before items are returned.  0 by
            /// default.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TrendModel>> RetrieveAsync(this ITrends operations, string name = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveWithHttpMessagesAsync(name, orderBy, take, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend requested.  Must be double URL encoded.
            /// </param>
            public static TrendModel RetrieveById(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveByIdAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend requested.  Must be double URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrendModel> RetrieveByIdAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Description property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Description property is to be returned.  Must be
            /// double URL encoded.
            /// </param>
            public static string RetrieveDescription(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveDescriptionAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Description property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Description property is to be returned.  Must be
            /// double URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveDescriptionAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveDescriptionWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies the Description property for the Trend with the Id provided to
            /// the new value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Description property is to be modified.  Must be
            /// double URL encoded.
            /// </param>
            /// <param name='newValue'>
            /// New Description value.
            /// </param>
            public static TrendModel UpdateDescription(this ITrends operations, string id, string newValue)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).UpdateDescriptionAsync(id, newValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies the Description property for the Trend with the Id provided to
            /// the new value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Description property is to be modified.  Must be
            /// double URL encoded.
            /// </param>
            /// <param name='newValue'>
            /// New Description value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrendModel> UpdateDescriptionAsync(this ITrends operations, string id, string newValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateDescriptionWithHttpMessagesAsync(id, newValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Name property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Name property is to be returned.  Must be double URL
            /// encoded.
            /// </param>
            public static string RetrieveName(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveNameAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Name property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Name property is to be returned.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveNameAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveNameWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies the Name property for the Trend with the Id provided to the new
            /// value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Name property is to be modified.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='newValue'>
            /// New Name value.
            /// </param>
            public static TrendModel UpdateName(this ITrends operations, string id, string newValue)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).UpdateNameAsync(id, newValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies the Name property for the Trend with the Id provided to the new
            /// value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Name property is to be modified.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='newValue'>
            /// New Name value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrendModel> UpdateNameAsync(this ITrends operations, string id, string newValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateNameWithHttpMessagesAsync(id, newValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the parent Container for the Trend with the Id supplied.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose parent Container is to be returned.  Must be double
            /// URL encoded.
            /// </param>
            public static ContainerModel RetrieveParent(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveParentAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the parent Container for the Trend with the Id supplied.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose parent Container is to be returned.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerModel> RetrieveParentAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveParentWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the ParentId property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose ParentId property is to be returned.  Must be double
            /// URL encoded.
            /// </param>
            public static string RetrieveParentId(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveParentIdAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the ParentId property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose ParentId property is to be returned.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveParentIdAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveParentIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies the ParentId property for the Trend with the Id provided to the
            /// new value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose ParentId property is to be modified.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='newValue'>
            /// New ParentId value.
            /// </param>
            public static TrendModel UpdateParentId(this ITrends operations, string id, string newValue)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).UpdateParentIdAsync(id, newValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies the ParentId property for the Trend with the Id provided to the
            /// new value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose ParentId property is to be modified.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='newValue'>
            /// New ParentId value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrendModel> UpdateParentIdAsync(this ITrends operations, string id, string newValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateParentIdWithHttpMessagesAsync(id, newValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Type property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Type property is to be returned.  Must be double URL
            /// encoded.
            /// </param>
            public static string RetrieveType(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveTypeAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Type property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Type property is to be returned.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveTypeAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveTypeWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Unit property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Unit property is to be returned.  Must be double URL
            /// encoded.
            /// </param>
            public static string RetrieveUnit(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveUnitAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Unit property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Unit property is to be returned.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveUnitAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveUnitWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Value for the Trend with the supplied Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Parent is to be returned.  Requires double URL
            /// encoding.
            /// </param>
            public static ValueModel RetrieveValue(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveValueAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Value for the Trend with the supplied Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Parent is to be returned.  Requires double URL
            /// encoding.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValueModel> RetrieveValueAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveValueWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the ValueId property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose ValueId property is to be returned.  Must be double
            /// URL encoded.
            /// </param>
            public static string RetrieveValueId(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).RetrieveValueIdAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the ValueId property for the Trend with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose ValueId property is to be returned.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveValueIdAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveValueIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies the Trend with the Id provided to the values supplied.  Returns
            /// the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend to be modified.  Must be double URL encoded.
            /// </param>
            /// <param name='updatedItem'>
            /// Item to be updated.  All modfied properties will be changed.  Requires
            /// double URL encoding.
            /// </param>
            public static TrendModel Update(this ITrends operations, string id, UpdateTrendModel updatedItem)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).UpdateAsync(id, updatedItem), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies the Trend with the Id provided to the values supplied.  Returns
            /// the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend to be modified.  Must be double URL encoded.
            /// </param>
            /// <param name='updatedItem'>
            /// Item to be updated.  All modfied properties will be changed.  Requires
            /// double URL encoding.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrendModel> UpdateAsync(this ITrends operations, string id, UpdateTrendModel updatedItem, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(id, updatedItem, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies the Id property for the Trend with the Id provided to the new
            /// value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Id property is to be modified.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='newValue'>
            /// New Id value.
            /// </param>
            public static string UpdateId(this ITrends operations, string id, string newValue)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).UpdateIdAsync(id, newValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies the Id property for the Trend with the Id provided to the new
            /// value supplied.  Returns the modified Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend whose Id property is to be modified.  Must be double URL
            /// encoded.
            /// </param>
            /// <param name='newValue'>
            /// New Id value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> UpdateIdAsync(this ITrends operations, string id, string newValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateIdWithHttpMessagesAsync(id, newValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Trend with the Id provided.  All TrendSample associated with
            /// the Trend will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend to be deleted.  Must be double URL encoded.
            /// </param>
            public static object Delete(this ITrends operations, string id)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Trend with the Id provided.  All TrendSample associated with
            /// the Trend will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend to be deleted.  Must be double URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this ITrends operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a range of TrendSample associated with the Trend with the Id
            /// provided.
            /// Open ended ranges are supported.  If sampleDateRange is not included all
            /// TrendSample will be deleted for the Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend for which TrendSample are to be deleted.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='sampleDateRange'>
            /// Only TrendSample with a SampleDate in this range will be deleted.
            /// </param>
            public static object PurgeTrendSamples(this ITrends operations, string id, DateRange sampleDateRange)
            {
                return Task.Factory.StartNew(s => ((ITrends)s).PurgeTrendSamplesAsync(id, sampleDateRange), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a range of TrendSample associated with the Trend with the Id
            /// provided.
            /// Open ended ranges are supported.  If sampleDateRange is not included all
            /// TrendSample will be deleted for the Trend.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the Trend for which TrendSample are to be deleted.  Must be double
            /// URL encoded.
            /// </param>
            /// <param name='sampleDateRange'>
            /// Only TrendSample with a SampleDate in this range will be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PurgeTrendSamplesAsync(this ITrends operations, string id, DateRange sampleDateRange, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PurgeTrendSamplesWithHttpMessagesAsync(id, sampleDateRange, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
