using System;

namespace NumberSequence
{
    class NondecreasingNumberSequence
    {
        public bool MembershipCheck(int[] numberSequence)
        {
            bool check = true;
            for (int i = 1; i < numberSequence.Length; i++)
            {
                if (numberSequence[i] - numberSequence[i - 1] < 0)
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
        
        public void ShowResult(bool membershipCheck)
        {
            if (membershipCheck == true)
            {
                Console.WriteLine("\nThis number sequence is a nondecreasing number sequence.");
            }
            else
            {
                Console.WriteLine("\nThis number sequence is not a nondecreasing number sequence.");
            }
        }
    }
}
