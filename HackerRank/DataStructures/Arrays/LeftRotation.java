import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {



    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        String[] nd = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nd[0]);

        int d = Integer.parseInt(nd[1]);

        int[] a = new int[n];

        String[] aItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int aItem = Integer.parseInt(aItems[i]);
            a[i] = aItem;
        }

        scanner.close();

        a = leftShift(a, d);

        for (int i = 0; i < n; i++) {
            System.out.print(a[i] + " ");
        }
    }

    private static int[] leftShift(int[] arr, int shifts) {
        int[] newArray = new int[arr.length];
        for(int i = 0; i < arr.length; i++) {
            int newIndex = i - shifts;

            while(newIndex < 0) {
                newIndex = arr.length + newIndex;
            }

            newArray[newIndex] = arr[i];
        }

        return newArray;
    }
}
