using System;
using System.Runtime.Serialization;

namespace StackExchange.Profiling
{
    /// <summary>
    /// An additional custom timing
    /// </summary>
    [DataContract]
    public class AdditionalTiming
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        public decimal Start { get; set; }

        [DataMember(Order = 3)]
        public decimal Duration { get; set; }

        [DataMember(Order = 4)]
        public decimal DurationWithoutChildren { get; set; }

        public Guid Id { get; set; }

        public Guid MiniProfilerId { get; set; }
    }
}
