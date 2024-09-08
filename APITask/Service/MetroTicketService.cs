using APITask.Constans;
using APITask.Context;
using APITask.IService;

namespace APITask.Service
{
    public class MetroTicketService : IMetroTicketService
    {
        private readonly ApplicationDbContext _context;

        public MetroTicketService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int CalculateTicketPrice(int startStationId, int destinationStationId)
        {
            var startStation = _context.Stations.FirstOrDefault(s => s.Id == startStationId);
            var destinationStation = _context.Stations.FirstOrDefault(s => s.Id == destinationStationId);

            if (startStation == null || destinationStation == null)
            {
                throw new Exception("Invalid Station Ids");
            }

            if (startStation.LineId == destinationStation.LineId)
            {
                int numberOfStations = Math.Abs(destinationStation.Position - startStation.Position);
                return CalculatePriceBasedOnStations(numberOfStations);
            }
            else
            {
                var transitionStation1 = _context.Stations
                    .Where(s => s.isTransitional && s.LineId == startStation.LineId)
                    .OrderBy(s => Math.Abs(s.Position - startStation.Position))
                    .FirstOrDefault();

                var transitionStation2 = _context.Stations
                    .FirstOrDefault(s => s.isTransitional &&
                                         s.LineId == destinationStation.LineId &&
                                         s.TransitionalStationId == transitionStation1.Id);

                if (transitionStation1 == null || transitionStation2 == null)
                {
                    throw new Exception("Transition Stations Not Found");
                }

                int firstLineStations = Math.Abs(transitionStation1.Position - startStation.Position);
                int secondLineStations = Math.Abs(transitionStation2.Position - destinationStation.Position);

                int totalStations = firstLineStations + secondLineStations;
                return CalculatePriceBasedOnStations(totalStations);
            }
        }


        public int CalculatePriceBasedOnStations(int numberOfStations)
        {
            if (numberOfStations <= Constant.ShortDistanceLimit)
            {
                return Constant.ShortDistancePrice;
            }
            else if (numberOfStations <= Constant.MediumDistanceLimit)
            {
                return Constant.MediumDistancePrice;
            }
            else
            {
                return Constant.LongDistancePrice;
            }
        }
    }
}
