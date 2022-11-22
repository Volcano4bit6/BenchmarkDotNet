using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class BenchmarkAPIPerformance
    {
        private static HttpClient _httpClient;

        [Params(1, 5)]
        public int N;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44336");
            _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
        }

        [Benchmark]
        public async Task GetListFromRepo()
        {
            for (int i = 0; i < N; i++)
            {
                var response = await _httpClient.GetAsync("/api/app/register-of-examination/from-repo");
            }
        }

        [Benchmark]
        public async Task GetListThenOrderBy()
        {
            for (int i = 0; i < N; i++)
            {
                var response = await _httpClient.GetAsync("/api/app/register-of-examination/then-order-by");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BenchMarkDotNet");
            var summary = BenchmarkRunner.Run<BenchmarkAPIPerformance>();
        }
    }
}
