import java.util.Scanner;

public class RNO_DOD {
    public static void main(String[] args) throws java.lang.Exception {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i = 0; i < n; i++) {
            int sum = 0;
            int n2 = sc.nextInt();

            sc.nextLine();
            String x = sc.nextLine();
            String[] numbers = x.split(" ");

            int realNumbers[] = new int[numbers.length];
            for(int j = 0; j < n2; j++) {
                realNumbers[j] = Integer.parseInt(numbers[j]);
                sum += realNumbers[j];
            }


            System.out.println(sum);
        }
    }
}
