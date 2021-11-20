namespace Solnet.Programs.Models.TokenSwap
{
    public enum CurveType
    {
        /// Uniswap-style constant product curve, invariant = token_a_amount * token_b_amount
        ConstantProduct,
        /// Flat line, always providing 1:1 from one token to another
        ConstantPrice,
        /// Stable, like uniswap, but with wide zone of 1:1 instead of one point
        Stable,
        /// Offset curve, like Uniswap, but the token B side has a faked offset
        Offset,
    }
}