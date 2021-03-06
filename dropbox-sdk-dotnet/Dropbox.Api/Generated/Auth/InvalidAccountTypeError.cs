// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Auth
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The invalid account type error object</para>
    /// </summary>
    public class InvalidAccountTypeError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<InvalidAccountTypeError> Encoder = new InvalidAccountTypeErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<InvalidAccountTypeError> Decoder = new InvalidAccountTypeErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="InvalidAccountTypeError" />
        /// class.</para>
        /// </summary>
        public InvalidAccountTypeError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Endpoint</para>
        /// </summary>
        public bool IsEndpoint
        {
            get
            {
                return this is Endpoint;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Endpoint, or <c>null</c>.</para>
        /// </summary>
        public Endpoint AsEndpoint
        {
            get
            {
                return this as Endpoint;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Feature</para>
        /// </summary>
        public bool IsFeature
        {
            get
            {
                return this is Feature;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Feature, or <c>null</c>.</para>
        /// </summary>
        public Feature AsFeature
        {
            get
            {
                return this as Feature;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="InvalidAccountTypeError" />.</para>
        /// </summary>
        private class InvalidAccountTypeErrorEncoder : enc.StructEncoder<InvalidAccountTypeError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(InvalidAccountTypeError value, enc.IJsonWriter writer)
            {
                if (value is Endpoint)
                {
                    WriteProperty(".tag", "endpoint", writer, enc.StringEncoder.Instance);
                    Endpoint.Encoder.EncodeFields((Endpoint)value, writer);
                    return;
                }
                if (value is Feature)
                {
                    WriteProperty(".tag", "feature", writer, enc.StringEncoder.Instance);
                    Feature.Encoder.EncodeFields((Feature)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="InvalidAccountTypeError" />.</para>
        /// </summary>
        private class InvalidAccountTypeErrorDecoder : enc.UnionDecoder<InvalidAccountTypeError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="InvalidAccountTypeError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override InvalidAccountTypeError Create()
            {
                return new InvalidAccountTypeError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override InvalidAccountTypeError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "endpoint":
                        return Endpoint.Decoder.DecodeFields(reader);
                    case "feature":
                        return Feature.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Current account type doesn't have permission to access this route
        /// endpoint.</para>
        /// </summary>
        public sealed class Endpoint : InvalidAccountTypeError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Endpoint> Encoder = new EndpointEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Endpoint> Decoder = new EndpointDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Endpoint" /> class.</para>
            /// </summary>
            private Endpoint()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Endpoint</para>
            /// </summary>
            public static readonly Endpoint Instance = new Endpoint();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Endpoint" />.</para>
            /// </summary>
            private class EndpointEncoder : enc.StructEncoder<Endpoint>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Endpoint value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Endpoint" />.</para>
            /// </summary>
            private class EndpointDecoder : enc.StructDecoder<Endpoint>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Endpoint" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Endpoint Create()
                {
                    return Endpoint.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Current account type doesn't have permission to access this feature.</para>
        /// </summary>
        public sealed class Feature : InvalidAccountTypeError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Feature> Encoder = new FeatureEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Feature> Decoder = new FeatureDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Feature" /> class.</para>
            /// </summary>
            private Feature()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Feature</para>
            /// </summary>
            public static readonly Feature Instance = new Feature();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Feature" />.</para>
            /// </summary>
            private class FeatureEncoder : enc.StructEncoder<Feature>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Feature value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Feature" />.</para>
            /// </summary>
            private class FeatureDecoder : enc.StructDecoder<Feature>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Feature" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Feature Create()
                {
                    return Feature.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : InvalidAccountTypeError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
