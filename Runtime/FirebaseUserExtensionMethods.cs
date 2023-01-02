using Firebase.Auth;

namespace Kogane
{
    public static class FirebaseUserExtensionMethods
    {
        public static string ToJson( this FirebaseUser self )
        {
            return new JsonFirebaseUser( self ).ToString();
        }
    }
}