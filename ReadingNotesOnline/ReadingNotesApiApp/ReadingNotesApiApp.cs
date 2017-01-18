﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Rest;
using ReadingNotesServices;

namespace ReadingNotesServices
{
    public partial class ReadingNotesApiApp : ServiceClient<ReadingNotesApiApp>, IReadingNotesApiApp
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private IConfigOperations _config;
        
        public virtual IConfigOperations Config
        {
            get { return this._config; }
        }
        
        private IReadingNotesOperations _readingNotes;
        
        public virtual IReadingNotesOperations ReadingNotes
        {
            get { return this._readingNotes; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ReadingNotesApiApp class.
        /// </summary>
        public ReadingNotesApiApp()
            : base()
        {
            this._config = new ConfigOperations(this);
            this._readingNotes = new ReadingNotesOperations(this);
            this._baseUri = new Uri("https://readingnotesapiapp.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ReadingNotesApiApp class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ReadingNotesApiApp(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._config = new ConfigOperations(this);
            this._readingNotes = new ReadingNotesOperations(this);
            this._baseUri = new Uri("https://readingnotesapiapp.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ReadingNotesApiApp class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ReadingNotesApiApp(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._config = new ConfigOperations(this);
            this._readingNotes = new ReadingNotesOperations(this);
            this._baseUri = new Uri("https://readingnotesapiapp.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ReadingNotesApiApp class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ReadingNotesApiApp(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the ReadingNotesApiApp class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ReadingNotesApiApp(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the ReadingNotesApiApp class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ReadingNotesApiApp(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}
