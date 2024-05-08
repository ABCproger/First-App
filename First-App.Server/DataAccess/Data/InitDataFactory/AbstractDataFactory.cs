using First_App.Server.Entities;

namespace First_App.Server.DataAccess.Data.InitDataFactory
{
    public abstract class AbstractDataFactory
    {
        public abstract Board[] GetBoardData();
        public abstract Card[] GetCardData();
        public abstract CardColumn[] GetCardColumnData();
        public abstract Priority[] GetPriorityData();
    }
}
