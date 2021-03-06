using AElf.Standards.ACS10;
using AElf.Contracts.Consensus.AEDPoS;
using AElf.Contracts.MultiToken;
using AElf.Contracts.Profit;
using AElf.Contracts.Vote;
using AElf.Contracts.Parliament;

namespace AElf.Contracts.Election
{
    // ReSharper disable InconsistentNaming
    public partial class ElectionContractState
    {
        internal VoteContractContainer.VoteContractReferenceState VoteContract { get; set; }
        internal ProfitContractContainer.ProfitContractReferenceState ProfitContract { get; set; }
        internal TokenContractContainer.TokenContractReferenceState TokenContract { get; set; }
        internal AEDPoSContractContainer.AEDPoSContractReferenceState AEDPoSContract { get; set; }
        internal ParliamentContractContainer.ParliamentContractReferenceState ParliamentContract { get; set; }
        internal DividendPoolContractContainer.DividendPoolContractReferenceState DividendPoolContract { get; set; }
    }
}