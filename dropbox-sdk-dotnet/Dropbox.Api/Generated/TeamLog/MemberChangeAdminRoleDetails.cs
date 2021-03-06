// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed team member admin role.</para>
    /// </summary>
    public class MemberChangeAdminRoleDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberChangeAdminRoleDetails> Encoder = new MemberChangeAdminRoleDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberChangeAdminRoleDetails> Decoder = new MemberChangeAdminRoleDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberChangeAdminRoleDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New admin role. This field is relevant when the admin role
        /// is changed or whenthe user role changes from no admin rights to with admin
        /// rights.</param>
        /// <param name="previousValue">Previous admin role. This field is relevant when the
        /// admin role is changed or when the admin role is removed.</param>
        public MemberChangeAdminRoleDetails(AdminRole newValue = null,
                                            AdminRole previousValue = null)
        {
            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberChangeAdminRoleDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberChangeAdminRoleDetails()
        {
        }

        /// <summary>
        /// <para>New admin role. This field is relevant when the admin role is changed or
        /// whenthe user role changes from no admin rights to with admin rights.</para>
        /// </summary>
        public AdminRole NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous admin role. This field is relevant when the admin role is changed or
        /// when the admin role is removed.</para>
        /// </summary>
        public AdminRole PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberChangeAdminRoleDetails" />.</para>
        /// </summary>
        private class MemberChangeAdminRoleDetailsEncoder : enc.StructEncoder<MemberChangeAdminRoleDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberChangeAdminRoleDetails value, enc.IJsonWriter writer)
            {
                if (value.NewValue != null)
                {
                    WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.AdminRole.Encoder);
                }
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.AdminRole.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberChangeAdminRoleDetails" />.</para>
        /// </summary>
        private class MemberChangeAdminRoleDetailsDecoder : enc.StructDecoder<MemberChangeAdminRoleDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberChangeAdminRoleDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberChangeAdminRoleDetails Create()
            {
                return new MemberChangeAdminRoleDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberChangeAdminRoleDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.AdminRole.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.AdminRole.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
