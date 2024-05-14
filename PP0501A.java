import java.util.Scanner;

class PP0501A {
  public static void main(String[] args) throws java.lang.Exception {
    Scanner sc = new Scanner(System.in);
    int n = sc.nextInt();
    sc.nextLine();
    for(int i = 0; i < n; i++) {
      int nwd = 1;
      
      
      String x = sc.nextLine();
      
      String[] numbers = x.split(" ");      

      int realNumbers[] = new int[numbers.length];
      for(int j = 0; j < realNumbers.length; j++) {
        realNumbers[j] = Integer.parseInt(numbers[j]);
      }

      nwd = nwd(realNumbers[0], realNumbers[1]);

      System.out.println(nwd);
    }    
  }

  static int nwd(int a, int b) {    
    while (b != 0) {
      int c = a % b;
      a = b;
      b = c;
    }
    return a;
  }
}