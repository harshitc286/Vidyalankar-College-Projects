import java.util.Scanner;

public class MonthlySalaryCalculator {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter the number of employees: ");
        int numEmployees = input.nextInt();

        // Create arrays to store employee information
        String[] employeeNames = new String[numEmployees];
        double[] hourlyRates = new double[numEmployees];
        double[] hoursWorked = new double[numEmployees];

        // Prompt the user to enter employee information
        for (int i = 0; i < numEmployees; i++) {
            System.out.println("Enter employee #" + (i + 1) + " information:");
            System.out.print("Name: ");
            employeeNames[i] = input.next();
            System.out.print("Hourly rate: ");
            hourlyRates[i] = input.nextDouble();
            System.out.print("Hours worked: ");
            hoursWorked[i] = input.nextDouble();
        }

        // Calculate each employee's monthly salary
        double[] salaries = new double[numEmployees];
        for (int i = 0; i < numEmployees; i++) {
            salaries[i] = hourlyRates[i] * hoursWorked[i] * 4; // assuming 4 weeks in a month
        }

        // Display the results
        System.out.println("\nMonthly Salary Report");
        System.out.println("--------------------");
        for (int i = 0; i < numEmployees; i++) {
            System.out.println(employeeNames[i] + ": $" + salaries[i]);
        }
    }
}