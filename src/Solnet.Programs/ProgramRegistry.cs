using Solnet.Programs.Abstract;
using Solnet.Programs.Model;
using Solnet.Rpc.Models;
using System.Collections.Generic;

namespace Solnet.Programs
{
    public class ProgramRegistry
    {
        private Dictionary<string, Program> _programs = new Dictionary<string, Program>();

        public Program GetProgram(string programId) => _programs[programId];
        public void AddProgram(Program p) => _programs.Add(p.ProgramIdKey, p);
        public IEnumerable<Program> Programs => _programs.Values;

        public IDecodedAccount<object> DecodeAccount(AccountInfo accountInfo)
        {
            if (!_programs.TryGetValue(accountInfo.Owner, out var p))
                return null;
            var da = p.AccountDecoder.DecodeAccount(accountInfo);
            return da;
        }

        public IDecodedAccount<T> DecodeAccount<T>(AccountInfo accountInfo)
        {
            if (!_programs.TryGetValue(accountInfo.Owner, out var p))
                return null;
            var da = p.AccountDecoder.DecodeAccount(accountInfo);
            return da as IDecodedAccount<T>;
        }
    }
}
