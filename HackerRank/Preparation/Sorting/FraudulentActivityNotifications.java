import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

import javax.lang.model.util.ElementScanner6;

import sun.awt.AWTAccessor.MenuAccessor;

public class Solution {

    // Complete the activityNotifications function below.
    static int activityNotifications(int[] expenditure, int d) {
        int possibleDays = expenditure.length - d;
        if (possibleDays <= 0)
        {
            return 0;
        }

        int notifications = 0;
        int mid = (int) Math.floor((float)d / 2);
        boolean isOdd = d%2 == 1;

        if(isOdd) {
            mid++;
        }
        
        Queue<Integer> queue = new LinkedList<Integer>();
        int[] expenditureCount = new int[201];

        for(int i = 0; i < d; i++) {
            queue.add(expenditure[i]);
            expenditureCount[expenditure[i]]++;
        }

        for(int i = d; i < expenditure.length; i++) {
            int spentOnDay = expenditure[i];

            int doubleMedian = getMedian(expenditureCount, mid, isOdd);

            if(spentOnDay >= doubleMedian) {
                notifications++;
            }

            int poll = queue.poll();
            expenditureCount[poll]--;

            queue.add(expenditure[i]);
            expenditureCount[expenditure[i]]++;
        }

        return notifications;
    }

    static int getMedian(int[] expenditureCount, int mid, boolean isOdd)
    {
        int count = 0;
        System.out.println();

        for(int i = 0; i < expenditureCount.length; i++)
        {
            count+= expenditureCount[i];

            if (count > mid) {
                return 2 * i;
            } 
            else if (count == mid) {
                if(isOdd) {
                    return 2 * i;
                } 
                else {
                    int j = i + 1;
                    while(expenditureCount[j] == 0)
                    {
                        j++;
                    }

                    return i + j;
                }
            }
        }
        return -1;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nd = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nd[0]);

        int d = Integer.parseInt(nd[1]);

        int[] expenditure = new int[n];

        String[] expenditureItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int expenditureItem = Integer.parseInt(expenditureItems[i]);
            expenditure[i] = expenditureItem;
        }

        int result = activityNotifications(expenditure, d);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
