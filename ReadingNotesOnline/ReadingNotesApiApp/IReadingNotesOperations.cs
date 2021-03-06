﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using ReadingNotesServices.Models;

namespace ReadingNotesServices
{
    public partial interface IReadingNotesOperations
    {
        /// <param name='editionNumber'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReadingNotes>> BuildReadingNotesWithOperationResponseAsync(string editionNumber, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='filename'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> ReProcessJSonReadingNotesWithOperationResponseAsync(string filename, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
