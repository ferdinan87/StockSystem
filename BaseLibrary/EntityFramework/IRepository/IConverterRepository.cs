using BaseLibrary.EntityFramework.PlantLogsheetsDB;

namespace BaseLibrary.EntityFramework.IRepository
{
    public interface IConverterRepository
    {
        ConverterLogSheet getConverterLog(string converterLogSheetID);
    }
}