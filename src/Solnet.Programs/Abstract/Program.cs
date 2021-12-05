using Solnet.Wallet;

namespace Solnet.Programs.Abstract
{
    public interface Program
    {
        /// <summary>
        /// The program's key
        /// </summary>
        PublicKey ProgramIdKey { get; }

        /// <summary>
        /// The name of the program
        /// </summary>
        string ProgramName { get; }

        ProgramAccountDecoder AccountDecoder { get; }
    }
}
