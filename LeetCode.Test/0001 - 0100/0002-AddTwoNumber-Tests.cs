using FluentAssertions;
using LeetCode._0001___0100;

namespace LeetCode.Tests._0001___0100
{
    public class _0002_AddTwoNumber_Tests
    {
        private ListNode CreateLinkedList(params int[] values)
        {
            ListNode head = null;
            ListNode current = null;
            foreach (var val in values)
            {
                if (head == null)
                {
                    head = new ListNode(val);
                    current = head;
                }
                else
                {
                    current.next = new ListNode(val);
                    current = current.next;
                }
            }
            return head;
        }

        private int[] ConvertToArray(ListNode node)
        {
            var values = new List<int>();
            while (node != null)
            {
                values.Add(node.val);
                node = node.next;
            }
            return values.ToArray();
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void AddTwoNumbers_ShouldReturnCorrectSum(int[] l1Values, int[] l2Values, int[] expectedValues)
        {
            // Arrange
            var sut = new _0002_AddTwoNumber();
            var l1 = CreateLinkedList(l1Values);
            var l2 = CreateLinkedList(l2Values);

            // Act
            var result = sut.AddTwoNumbers(l1, l2);

            // Assert
            var expected = CreateLinkedList(expectedValues);
            var resultArray = ConvertToArray(result);
            var expectedArray = ConvertToArray(expected);

            resultArray.Should().Equal(expectedArray);
        }
    }
}