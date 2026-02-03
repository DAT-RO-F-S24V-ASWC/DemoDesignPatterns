// See https://aka.ms/new-console-template for more information


using DemoDesignPatterns;
using DemoDesignPatterns.Comments;

/*
DesignWorkerTemplate dworker = new DesignWorkerTemplate();
dworker.Start();
*/

CommentWorker cworker = new CommentWorker();
int res = cworker.SomeSillyMethod(7, "3");

Console.WriteLine(res);




