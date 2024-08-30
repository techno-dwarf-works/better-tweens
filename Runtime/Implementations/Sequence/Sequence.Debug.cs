using System.Text;
using Better.Commons.Runtime.Extensions;

namespace Better.Tweens.Runtime
{
    public partial class Sequence
    {
        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendField(nameof(ChannelsCount), ChannelsCount);
        }
    }
}