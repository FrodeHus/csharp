// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// SecretEnvSource selects a Secret to populate the environment variables with.
        /// 
        /// The contents of the target Secret&apos;s Data field will represent the key-value
        /// pairs as environment variables.
    /// </summary>
    public partial class V1SecretEnvSource
    {
        /// <summary>
        /// Initializes a new instance of the V1SecretEnvSource class.
        /// </summary>
        public V1SecretEnvSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SecretEnvSource class.
        /// </summary>
        /// <param name="name">
        /// Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </param>
        /// <param name="optional">
        /// Specify whether the Secret must be defined
        /// </param>
        public V1SecretEnvSource(string name = null, bool? optional = null)
        {
            Name = name;
            Optional = optional;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Specify whether the Secret must be defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
