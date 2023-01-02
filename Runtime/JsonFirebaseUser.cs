using System;
using System.Linq;
using Firebase.Auth;
using UnityEngine;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonFirebaseUser
    {
        [SerializeField] private string           photoUrl;
        [SerializeField] private string           displayName;
        [SerializeField] private string           email;
        [SerializeField] private bool             isAnonymous;
        [SerializeField] private bool             isEmailVerified;
        [SerializeField] private JsonUserMetadata metadata;
        [SerializeField] private string           phoneNumber;
        [SerializeField] private JsonUserInfo[]   providerData;
        [SerializeField] private string           providerId;
        [SerializeField] private string           userId;

        public JsonFirebaseUser( FirebaseUser value )
        {
            photoUrl        = value.PhotoUrl?.ToString();
            displayName     = value.DisplayName;
            email           = value.Email;
            isAnonymous     = value.IsAnonymous;
            isEmailVerified = value.IsEmailVerified;
            metadata        = new( value.Metadata );
            phoneNumber     = value.PhoneNumber;
            providerData    = value.ProviderData?.Select( x => new JsonUserInfo( x ) ).ToArray();
            providerId      = value.ProviderId;
            userId          = value.UserId;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}