import java.util.Scanner;

// task: https://pl.spoj.com/problems/TABLICA/


class TABLICA {
  public static void main(String[] args) throws java.lang.Exception {
    Scanner sc = new Scanner(System.in);    
    String x = sc.nextLine();    
    
    String[] numbers = x.split(" ");

    int realNumbers[] = new int[numbers.length];
    int i = 0;    
    for (int j = realNumbers.length - 1; j >= 0; j--) {
      realNumbers[i] = Integer.parseInt(numbers[j]);
      i++;
    }

    for (int j = 0; j < realNumbers.length; j++) {
      System.out.print(realNumbers[j] + " ");
    }

  }
}