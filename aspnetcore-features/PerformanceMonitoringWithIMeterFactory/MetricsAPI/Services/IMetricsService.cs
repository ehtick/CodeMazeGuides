﻿namespace MetricsAPI.Services;

public interface IMetricsService
{
    void RecordUserClick();
    void RecordResponseTime(double value);
    void RecordRequest();
    void RecordMemoryConsumption(double value);
    void RecordUserClickDetailed(string region, string feature);
    void RecordResourceUsage(double currentCpuUsage, double currentMemoryUsage, double currentThreadCount);
}
