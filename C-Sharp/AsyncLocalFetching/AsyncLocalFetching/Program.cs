using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace AsyncLocalFetching
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FetchAll().Wait();
        }

        private static async Task FetchAll()
        {
            var urls = new[]
            {
                "https://msdn.microsoft.com/en-us/library/dn906268(v=vs.110).aspx",
                "https://referencesource.microsoft.com/#mscorlib/system/threading/asynclocal.cs",
                "https://stackoverflow.com/questions/11564506/nesting-await-in-parallel-foreach/11565317#11565317"
            };

            int widerScopeTextLength;
            var asyncLocalTextLength = new AsyncLocal<int>();
            var boxedInt = new BoxedInt();
            var asyncLocalBoxedInt = new AsyncLocal<BoxedInt> {Value = new BoxedInt()};

            var fetchUrlBlock = new TransformBlock<string, string>(
                async url =>
                {
                    using (var httpClient = new HttpClient())
                    {
                        var text = await httpClient.GetStringAsync(url);

                        //await Task.Delay(100);

                        var textLength = text.Length;

                        widerScopeTextLength = textLength;
                        asyncLocalTextLength.Value = textLength;

                        boxedInt.Value = textLength;
                        asyncLocalBoxedInt.Value.Value = textLength;

                        return
                            $"{url}: Local - {textLength}; WS - {widerScopeTextLength}; AL - {asyncLocalTextLength.Value}; BI - {boxedInt.Value}; AL BI - {asyncLocalBoxedInt.Value.Value}";
                    }
                }, new ExecutionDataflowBlockOptions
                {
                    MaxDegreeOfParallelism = DataflowBlockOptions.Unbounded
                });

            var writeUrlReportBlock = new ActionBlock<string>(s => WriteLine(s));
            fetchUrlBlock.LinkTo(writeUrlReportBlock, new DataflowLinkOptions {PropagateCompletion = true});

            foreach (var url in urls) fetchUrlBlock.Post(url);

            fetchUrlBlock.Complete();
            writeUrlReportBlock.Completion.Wait();
        }

        private class BoxedInt
        {
            public int Value { get; set; }
        }
    }
}