using Solnet.Programs;
using Solnet.Programs.TokenSwap;
using Solnet.Programs.TokenSwap.Models;
using Solnet.Rpc;
using Solnet.Rpc.Builders;
using Solnet.Rpc.Core.Http;
using Solnet.Rpc.Messages;
using Solnet.Rpc.Models;
using Solnet.Wallet;
using System;

namespace Solnet.Examples
{
    public class ProgramAccountExample : IExample
    {

        private static readonly IRpcClient RpcClient = ClientFactory.GetClient(Cluster.MainNet);

        public void Run()
        {
            var programs = new ProgramRegistry();
            programs.AddProgram(new TokenSwapProgram());
            programs.AddProgram(new TokenProgram());

            var ai = RpcClient.GetAccountInfo("GAM8dQkm4LwYJgPZbML61mKPUCQX7uAquxu67p9oifSK");
            var a = programs.DecodeAccount(ai.Result.Value);
        }
    }
}