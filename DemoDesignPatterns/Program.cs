// See https://aka.ms/new-console-template for more information


using DemoDesignPatterns;
using DemoDesignPatterns.Comments;
using DemoDesignPatterns.Configuration;
using DemoDesignPatterns.TracingLogging;

/*
DesignWorkerTemplate dworker = new DesignWorkerTemplate();
dworker.Start();


CommentWorker cworker = new CommentWorker();
int res = cworker.SomeSillyMethod(7, "3");
Console.WriteLine(res);
*/


//ConfigReaderWorker confworker = new ConfigReaderWorker();
//confworker.StartReadConfigfile(@"M:\uv\2026f-ASWC\prog\DemoDesignPatterns\DemoDesignPatterns\Configuration\Config.xml");

//LoggerWorker lworker = new LoggerWorker();
//lworker.StartLoggerService();


MyLogger l = MyLogger.Instance;
l.Tal = 9;
Console.WriteLine(l.Tal);

MyLogger l2 = MyLogger.Instance;
l2.Tal = 34;
Console.WriteLine(l2.Tal);
Console.WriteLine(l.Tal);
