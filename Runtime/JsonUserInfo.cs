using System;
using Firebase.Auth;
using UnityEngine;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonUserInfo
    {
        [SerializeField] private string displayName;
        [SerializeField] private string email;
        [SerializeField] private string photoUrl;
        [SerializeField] private string providerId;
        [SerializeField] private string userId;

        public JsonUserInfo( IUserInfo value )
        {
            displayName = value.DisplayName;
            email       = value.Email;
            photoUrl    = value.PhotoUrl?.ToString();
            providerId  = value.ProviderId;
            userId      = value.UserId;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}