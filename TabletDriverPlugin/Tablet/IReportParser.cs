namespace TabletDriverPlugin.Tablet
{
    public interface IReportParser<T> where T : IDeviceReport
    {
        T Parse(byte[] report);
    }
}