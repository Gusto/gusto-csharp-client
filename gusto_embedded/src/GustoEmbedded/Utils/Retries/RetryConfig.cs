//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded.Utils.Retries
{
    public class RetryConfig
    {
        public enum RetryStrategy
        {
            BACKOFF,
            NONE
        }
        public readonly RetryStrategy Strategy;
        public readonly BackoffStrategy? Backoff;
        public readonly bool RetryConnectionErrors;

        /// <summary>
        /// Selects the retry strategy.
        /// </summary>
        /// <param name="strategy">The retry strategy.</param>
        /// <param name="backoff">The backoff strategy configuration (if applicable)</param>
        /// <param name="retryConnectionErrors">Whether to retry on connection errors.</param>
        /// <remarks>
        /// The backoff strategy is only required if the retry strategy is set to BACKOFF.
        /// To disable retries, set the strategy to NONE.
        /// </remarks>
        public RetryConfig(RetryStrategy strategy, BackoffStrategy? backoff = null, bool retryConnectionErrors = false)
        {

            if (strategy == RetryStrategy.BACKOFF && backoff == null)
            {
                throw new System.ArgumentNullException("Backoff strategy configuration was not provided");
            }

            Strategy = strategy;
            Backoff = backoff;
            RetryConnectionErrors = retryConnectionErrors;
        }
    }
}