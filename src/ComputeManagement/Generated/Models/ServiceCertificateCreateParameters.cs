// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Create Service Certificate operation.
    /// </summary>
    public partial class ServiceCertificateCreateParameters
    {
        private CertificateFormat _certificateFormat;
        
        /// <summary>
        /// The service certificate format. Windows Azure supports the pfx and
        /// cer file formats.
        /// </summary>
        public CertificateFormat CertificateFormat
        {
            get { return this._certificateFormat; }
            set { this._certificateFormat = value; }
        }
        
        private byte[] _data;
        
        /// <summary>
        /// The pfx or .cer file.
        /// </summary>
        public byte[] Data
        {
            get { return this._data; }
            set { this._data = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// The password for a .pfx certificate. A .cer certificate does not
        /// require a password.
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceCertificateCreateParameters class.
        /// </summary>
        public ServiceCertificateCreateParameters()
        {
        }
    }
}
