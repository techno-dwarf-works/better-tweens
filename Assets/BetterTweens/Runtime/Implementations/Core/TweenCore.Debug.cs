using System.Text;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public void CollectInfo(ref StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine(GetType().Name);
        }
    }
}