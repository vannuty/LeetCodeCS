using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001___0100
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class _0002_AddTwoNumber
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(-1);
            var listNode = result;

            var carry = 0;
            while (l1 is not null || l2 is not null)
            {
                var value1 = l1 == null ? 0 : l1.val;
                var value2 = l2 == null ? 0 : l2.val;

                var sum = value1 + value2 + carry;
                carry = sum / 10;
                sum %= 10;
                listNode.next = new ListNode(sum);

                listNode = listNode.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry != 0)
                listNode.next = new ListNode(carry);

            return result.next;
        }

    }
}
