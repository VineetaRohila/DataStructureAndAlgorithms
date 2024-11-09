public class Solution {
   /* TC : O(N) SC : O(1)
    public bool CheckPerfectNumber(int num) {

        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num%i == 0)
            sum += i;

        }

        if (sum == num)
        return true;
        else 
        return false;
        
    }
    */

/*
    //TC : O(sqrt(N)) SC : O(1) 

    public bool CheckPerfectNumber(int num) {

        if (num == 1)
        return false;

        int sum = 1;

        for (int i = 2; i*i <= num; i++)
        {
            if (num%i == 0)
            {
                sum += i;
            
            if ( i != num/i)
            sum += num/i;

            }
        }        

        if (sum == num)
        return true;
        else 
        return false;
    }
    */

// same complexities as above 
    public bool CheckPerfectNumber(int num) { //num = 28

        int sum = 0;

        for (int i = 1; i*i <= num; i++)
        {
            if (num%i == 0) // for i = 1, factors : 1 and 28, 
                            //now this 28 i.e. num needs to be subtracted from sum
            {
                sum += i;
            
            if ( i != num/i)
            sum += num/i;

            }
        }        

        if (sum - num == num)
        return true;
        else 
        return false;
    }
}