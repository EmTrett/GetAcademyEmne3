using RaceResults;
using RaceResults.Console;

var report = new ReportService(FileLineReaderService.GetLines("timedate.csv"));
report.ShowReport();