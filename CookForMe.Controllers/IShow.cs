
using CookForMeUtil;

namespace CookForMe.Controllers
{
    public interface IShow : IObserver
    {
        void PresentDialog();
    }
}
