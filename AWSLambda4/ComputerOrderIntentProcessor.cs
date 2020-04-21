using Amazon.Lambda.Core;
using Amazon.Lambda.LexEvents;

namespace AWSLambda4
{
    public class ComputerOrderIntentProcessor : AbstractIntentProcessor
    {
        public override LexResponse Process(LexEvent lexEvent, ILambdaContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}