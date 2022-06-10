using BaseLibrary.EntityFramework.IRepository;
using BaseLibrary.EntityFramework.PlantLogsheetsDB;
using Microsoft.EntityFrameworkCore;


namespace BaseLibrary.EntityFramework.Repository
{
    public class ConverterRepository : IConverterRepository
    {
        private PlantLogsheetsContext _context;

        public ConverterRepository(PlantLogsheetsContext context)
        {
            _context = context;
        }

        public ConverterLogSheet getConverterLog(string converterLogSheetID)
        {
            //return _context.ConverterLogSheets.Find(converterLogSheetID);


            /*
             ConverterLogNote
             ConverterEvent
            ConverterLogCheck
            Charge
            GranulationDetail
            BlowSummary
            ProductionParameter
            FinalAssay
             */

            ConverterLogSheet? logsheet = _context.ConverterLogSheets
                                            .Where(c => c.BlowId == converterLogSheetID)
                                            .Include(c => c.ConverterLogCheck)
                                            // only 6 of these, ok to load here
                                            //.Include(c => c.ProductionParameters)
                                            .Include(c => c.ConverterFinalAssay)
                                            .Include(c => c.BlowSummary)
                                            //// only 3 of these, ok to load here
                                            //.Include(c => c.ConverterEvents)
                                            .Include(c => c.GranulationSummary)
                                            .FirstOrDefault();

            if (logsheet != null)
            {

                logsheet.ProductionParameters = _context.ProductionParameters
                            .Where(x => x.BlowId == converterLogSheetID)
                            .ToArray();

                logsheet.ConverterEvents = _context.ConverterEvents
                            .Where(x => x.BlowId == converterLogSheetID)
                            .ToArray();

                logsheet.ConverterLogCheck.TuyereMeasurements = _context.TuyereMeasurements
                                            .Where(x => x.BlowId == converterLogSheetID)
                                            .ToArray();

                // this has max of 14 records, seperating out
                logsheet.ConverterCharges = _context.ConverterCharges
                            .Where(x => x.BlowId == converterLogSheetID)
                            .ToArray();

                // max 11 records, seperating out
                logsheet.ConverterSheetNotes = _context.ConverterSheetNotes
                                                .Where(x => x.BlowId == converterLogSheetID)
                                                .ToArray();

                logsheet.BlowSummary.BlowDetails = _context.BlowDetails
                                                .Where(x => x.BlowId == converterLogSheetID)
                                                .Include(x => x.BlowFluxDopes)
                                                .ToArray();

                logsheet.BlowSummary.BlowSamples = _context.BlowSamples
                                                .Where(x => x.BlowId == converterLogSheetID)
                                                .ToArray();

                logsheet.GranulationSummary.GranulationPots = _context.GranulationPots
                                                .Where(x => x.BlowId == converterLogSheetID)
                                                .ToArray();
            }

            return logsheet;
            // this is way too slow as the query returns over 1 000 000 rows
            //return _context.ConverterLogSheets
            //    .Where(x => x.BlowId == converterLogSheetID)
            //    .Include(c => c.ConverterSheetNotes)
            //    .Include(c => c.ConverterEvents)
            //    .Include(c => c.ConverterLogCheck)
            //        .ThenInclude(l => l.TuyereMeasurements)
            //    .Include(c => c.ConverterCharges)
            //    .Include(c => c.ProductionParameters)
            //    .Include(c => c.GranulationSummary)
            //        .ThenInclude(g => g.GranulationPots)
            //    .Include(c => c.BlowSummary)
            //    .Include(c => c.BlowSummary.BlowSamples)
            //    .Include(c => c.BlowSummary.BlowDetails)
            //        //    .ThenInclude(b => b.BlowSamples)
            //        //.Include(c => c.BlowSummary)
            //        //.ThenInclude(b => b.BlowDetails)
            //    //        .ThenInclude(d => d.BlowFluxDopes)
            //    .FirstOrDefault();
        }

    }
}
