﻿namespace Bucket.OpenTracing
{
    internal static class TextMapCarrierHelpers
    {
        public const string prefix = "ot-bg-";
        public const string prefix_traceId = "ot-traceId";
        public const string prefix_spanId = "ot-spanId";
        public const string prefix_sampled = "ot-sampled";
    }
}