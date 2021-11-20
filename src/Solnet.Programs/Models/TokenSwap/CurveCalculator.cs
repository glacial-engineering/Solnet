using System;

namespace Solnet.Programs.Models.TokenSwap
{
    /// <summary>
    /// A curve calculator must serialize itself to 32 bytes
    /// </summary>
    public interface CurveCalculator
    {
        /// <summary>
        /// Serialize this calculator type
        /// </summary>
        /// <returns></returns>
        ReadOnlySpan<byte> Serialize();
    }
}