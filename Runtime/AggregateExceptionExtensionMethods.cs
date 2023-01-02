using System;
using System.Linq;
using Firebase;

namespace Kogane
{
    public static class AggregateExceptionExtensionMethods
    {
        public static bool IsFirebaseException( this AggregateException self )
        {
            return self
                    .Flatten()
                    .InnerExceptions.Any( x => x is FirebaseException )
                ;
        }

        public static FirebaseException GetFirebaseException( this AggregateException self )
        {
            return self
                    .Flatten()
                    .InnerExceptions
                    .OfType<FirebaseException>()
                    .First()
                ;
        }
    }
}