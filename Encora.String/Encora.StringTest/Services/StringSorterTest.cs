using Encora.String.services;
using Xunit;
using Assert = Xunit.Assert;

namespace Encora.StringTest.Services
{
    public class StringSorterTest : BaseTestContext
    {
        [Theory]
        [MemberData(nameof(TestCaseData01))]
        [MemberData(nameof(TestCaseData02))]
        [MemberData(nameof(TestCaseData03))]
        [MemberData(nameof(TestCaseData04))]
        [MemberData(nameof(TestCaseData05))]
        [MemberData(nameof(TestCaseData06))]
        public void TestSortStringByFrequency(string input, string expectedOutput)
        {
            // Act
            var result = StringSorter.SortStringByFrequency(input);

            // Assert
           Assert.Equal(expectedOutput, result); 
        }
        [Theory]
        [InlineData("5", null)]
        [InlineData("3", null)]
        [InlineData("10", null)]
        public void TestSortStringByFrequency_NumericInput(string input, string expectedOutput)
        {
            // Act
            var result = StringSorter.SortStringByFrequency(input);

            // Assert
            Assert.NotEqual(expectedOutput, result);
        }
    }

}
