using Solnet.Programs.Model;
using Solnet.Programs.TokenSwap.Models;
using Solnet.Rpc.Models;
using Solnet.Wallet;

namespace Solnet.Programs.TokenSwap
{
    public class TokenSwapProgramAccountDecoder : ProgramAccountDecoder
    {
        public override object Decode(byte[] data) => TokenSwapAccount.Deserialize(data);
    }
}