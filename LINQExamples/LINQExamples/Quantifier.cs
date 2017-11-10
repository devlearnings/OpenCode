using System.Linq;

namespace LINQExamples
{
    public static class Quantifier
    {
        public static bool ExecuteAllCheckIfAllAreTeenager()
        {
            return Data.StudentdList.All(s => s.Age > 12 && s.Age < 20);
        }
        
    }
}