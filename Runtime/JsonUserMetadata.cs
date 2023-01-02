using System;
using Firebase.Auth;
using UnityEngine;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonUserMetadata
    {
        [SerializeField] private ulong lastSignInTimestamp;
        [SerializeField] private ulong creationTimestamp;

        public JsonUserMetadata( UserMetadata value )
        {
            lastSignInTimestamp = value.LastSignInTimestamp;
            creationTimestamp   = value.CreationTimestamp;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}