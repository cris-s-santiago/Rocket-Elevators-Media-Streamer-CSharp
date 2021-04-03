using System;
using Xunit;
using MediaStreamer;

namespace MediaStreamerTest
{
    public class Program
    {
        [Fact]
        public void Test()
        {
            var streamer = new MedStreamer();
            bool result = streamer.getContent().Contains("<html>");
            Assert.Equal(result, true);
        }
    }
}
