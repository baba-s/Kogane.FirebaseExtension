using Firebase;
using Firebase.Auth;

namespace Kogane
{
    public static class FirebaseExceptionExtensionMethods
    {
        public static AuthError GetAuthError( this FirebaseException self )
        {
            return ( AuthError )self.ErrorCode;
        }
    }
}