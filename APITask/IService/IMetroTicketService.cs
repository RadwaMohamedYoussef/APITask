namespace APITask.IService
{
    public interface IMetroTicketService
    {
        int CalculateTicketPrice(int startStationId, int destinationStationId);
        int CalculatePriceBasedOnStations(int numberOfStations);
    }
}
