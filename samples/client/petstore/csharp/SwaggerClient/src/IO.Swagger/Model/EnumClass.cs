/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Gets or Sets EnumClass
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumClass
    {
        
        /// <summary>
        /// Enum Abc for "_abc"
        /// </summary>
        [EnumMember(Value = "_abc")]
        Abc,
        
        /// <summary>
        /// Enum efg for "-efg"
        /// </summary>
        [EnumMember(Value = "-efg")]
        efg,
        
        /// <summary>
        /// Enum xyz for "(xyz)"
        /// </summary>
        [EnumMember(Value = "(xyz)")]
        xyz
    }

}
