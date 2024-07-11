namespace Trabajo_Final___AbeasCorp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_EmptyRequests_ReturnsZero()
        {
            var requests = new List<Request>();

            var scheduler = new RequestSchedulerTest();

            var MaxGain = scheduler.GetMaxGain(requests);

            Assert.AreEqual(0, MaxGain);
        }

        [TestMethod]
        public void Test_SingleRequest_ReturnsRequestPrice()
        {
            var requests = new List<Request>
            {
               new Request("AF514", 0, 5 , 10)
            };

            var scheduler = new RequestSchedulerTest();

            var MaxGain = scheduler.GetMaxGain(requests);

            Assert.AreEqual(10, MaxGain);
        }

        [TestMethod]
        public void Test_MultipleNonOverlappingRequests_ReturnsSumOfPrices()
        {
            var requests = new List<Request>
            {
               new Request("AF514", 0, 5 , 10),
               new Request("CO5", 6, 10 , 15)
            };

            var scheduler = new RequestSchedulerTest();

            var MaxGain = scheduler.GetMaxGain(requests);

            Assert.AreEqual(25, MaxGain);
        }

        [TestMethod]
        public void Test_MultipleOverlappingRequests_ReturnsMaxPrice()
        {
            var requests = new List<Request>
            {
               new Request("AF514", 0, 5 , 10),
               new Request("CO5", 3, 7 , 14)
            };

            var scheduler = new RequestSchedulerTest();

            var MaxGain = scheduler.GetMaxGain(requests);

            Assert.AreEqual(14, MaxGain);
        }

        [TestMethod]
        public void Test_MixedOverlappingAndNonOverlappingRequests_ReturnsMaxGain()
        {
            var requests = new List<Request>
            {
               new Request("AF514", 0, 5 , 10),
               new Request("CO5", 3, 7 , 14),
               new Request("AF515", 12, 4 , 7)
            };    

            var scheduler = new RequestSchedulerTest();

            var MaxGain = scheduler.GetMaxGain(requests);

            Assert.AreEqual(21, MaxGain);
        }
    }
}