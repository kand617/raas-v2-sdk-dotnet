using System;
using System.Threading.Tasks;

namespace TangoCard.Raas.Utilities
{
    public static class RetryHelper
    {
        public static async Task RetryOnExceptionAsync(
            int times, TimeSpan delay, Func<Task> operation)
        {
            await RetryOnExceptionAsync<Exception>(times, delay, operation).ConfigureAwait(false);
        }
        public static async Task RetryOnExceptionAsync<TException>(
            int times, TimeSpan delay, Func<Task> operation) where TException : Exception
        {
            TException capturedException;
            if (times < 0)
                throw new ArgumentOutOfRangeException();
            var attempts = -1;
            do
            {
                try
                {
                    attempts++;
                    await operation();
                    break;
                }
                catch (TException ex)
                {
                    capturedException = ex;
                }

                if (attempts == times)
                    throw capturedException;
#if WINDOWS_UWP
                await Task.Delay(delay).ConfigureAwait(false);
#else
                await TaskEx.Delay(delay).ConfigureAwait(false);
#endif

            } while (true);
        }
    }
}