using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solnet.Programs.Models.TokenSwap
{
    /// <summary>
    /// Encapsulates all fee information and calculations for swap operations
    /// </summary>
    public class Fees
    {
        /// <summary>
        /// Trade fee numerator.
        /// </summary>
        public ulong TradeFeeNumerator;

        /// <summary>
        /// Trade fee denominator.
        /// </summary>
        public ulong TradeFeeDenominator;

        /// <summary>
        /// Owner trade fee numerator.
        /// </summary>
        public ulong OwnerTradeFeeNumerator;

        /// <summary>
        /// Owner trade fee denominator.
        /// </summary>
        public ulong OwnerTradeFeeDenomerator;

        /// <summary>
        /// Owner withdraw fee numerator.
        /// </summary>
        public ulong OwnerWithrawFeeNumerator;

        /// <summary>
        /// Owner withdraw fee denominator.
        /// </summary>
        public ulong OwnerWithrawFeeDenomerator;

        /// <summary>
        /// Host trading fee numerator.
        /// </summary>
        public ulong HostFeeNumerator;

        /// <summary>
        /// Host trading fee denominator.
        /// </summary>
        public ulong HostFeeDenomerator;
    }
}
