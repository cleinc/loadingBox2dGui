using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models.ProductionRecord
{
    public interface IProductionRecordRepository
    {
        List<ProductionRecord> GetRecords(int count = -1);
        List<ProductionRecord> GetRecordsByResult(DateTime? startDate, InspectionResult result);
        List<ProductionRecord> GetProductionRecordByDateRange(DateTime startDate, DateTime endDate);
        List<ProductionRecord> GetProductionRecordByCarType(int carType);
        List<ProductionRecord> GetProductionRecordBySequenceNumber(string sequenceNumber);
        List<ProductionRecord> GetProductionRecordByBodyNumber(string bodyNumber);
        List<ProductionRecord> GetProductionRecordByMultipleCondition(DateTime startDate,
                                                                      DateTime endDate,
                                                                      List<InspectionResult> productionResults,
                                                                      string carName = null,
                                                                      string[] sequenceNumber = null,
                                                                      string bodyNumber = null);
        List<string> GetCarNames();
        void AddProductionRecord(ProductionRecord record);
        string GetCarType(int carType);
        int CreateTableProductionRecordIfNotExistsForProductionRecord();
    }
}