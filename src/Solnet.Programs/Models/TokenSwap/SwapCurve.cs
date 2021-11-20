using Solnet.Programs.Utilities;
using System;

namespace Solnet.Programs.Models.TokenSwap
{
    public class SwapCurve
    {
        public CurveType CurveType { get; set; }
        public CurveCalculator Calculator { get; set; }

        private SwapCurve() { }

        public ReadOnlySpan<byte> Serialize()
        {
            var ret = new byte[33];
            ret.WriteU8((byte)CurveType, 0);
            ret.WriteSpan(Calculator.Serialize(), 1);
            return new Span<byte>(ret);
        }

        public static SwapCurve ConstantProduct => new SwapCurve() { CurveType = CurveType.ConstantProduct, Calculator = new ConstantProductCurve() };
    }
}
