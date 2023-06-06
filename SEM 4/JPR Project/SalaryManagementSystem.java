import java.util.Scanner;
import java.io.IOException;

public class SalaryManagementSystem {

    // Declaring ANSI_RESET so that we can reset the color
    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_BLACK = "\u001B[30m";
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_GREEN = "\u001B[32m";
    public static final String ANSI_YELLOW = "\u001B[33m";
    public static final String ANSI_BLUE = "\u001B[34m";
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_CYAN = "\u001B[36m";
    public static final String ANSI_WHITE = "\u001B[37m";

    // Declaring the background color
    public static final String ANSI_BLACK_BACKGROUND = "\u001B[40m";
    public static final String ANSI_RED_BACKGROUND = "\u001B[41m";
    public static final String ANSI_GREEN_BACKGROUND = "\u001B[42m";
    public static final String ANSI_YELLOW_BACKGROUND = "\u001B[43m";
    public static final String ANSI_BLUE_BACKGROUND = "\u001B[44m";
    public static final String ANSI_PURPLE_BACKGROUND = "\u001B[45m";
    public static final String ANSI_CYAN_BACKGROUND = "\u001B[46m";
    public static final String ANSI_WHITE_BACKGROUND = "\u001B[47m";

    // Bold High Intensity
    public static final String BLACK_BOLD_BRIGHT = "\033[1;90m"; // BLACK
    public static final String RED_BOLD_BRIGHT = "\033[1;91m";   // RED
    public static final String GREEN_BOLD_BRIGHT = "\033[1;92m"; // GREEN
    public static final String YELLOW_BOLD_BRIGHT = "\033[1;93m";// YELLOW
    public static final String BLUE_BOLD_BRIGHT = "\033[1;94m";  // BLUE
    public static final String PURPLE_BOLD_BRIGHT = "\033[1;95m";// PURPLE
    public static final String CYAN_BOLD_BRIGHT = "\033[1;96m";  // CYAN
    public static final String WHITE_BOLD_BRIGHT = "\033[1;97m"; // WHITE

    public static void main(String[] args) throws IOException, InterruptedException
    {
        // Create a Scanner object to read input
        Scanner sc = new Scanner(System.in);

        // Define variables to hold employee details and salary information
        String employeeName;
        int employeeId;
        double basicSalary, grossSalary, netSalary, da, hra, pf, tax, allowance;

        System.out.print("\033[1;93m" + "Enter employee name: ");
        employeeName = sc.nextLine();
        System.out.println("\u001B[0m");

        System.out.print("\033[1;92m" + "Enter employee ID: ");
        employeeId = sc.nextInt();
        System.out.println("\u001B[0m");

        System.out.print("\033[1;91m" + "Enter basic salary: " + "\u001B[0m");
        basicSalary = sc.nextDouble();
        System.out.println("\u001B[0m");

        // Clear the screen
        new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
    

        // Calculate the gross salary
        da = 0.5 * basicSalary;
        hra = 0.25 * basicSalary;
        allowance = 0.2 * basicSalary;
        grossSalary = basicSalary + da + hra + allowance;

        // Calculate the net salary
        pf = 0.12 * basicSalary;
        tax = 0.1 * grossSalary;
        netSalary = grossSalary - pf - tax;

        // Print the employee details and salary information
        System.out.println(" ");
        System.out.println(
                "\033[0;105m" + "==========The Employee Details And Salary Information==========" + "\u001B[0m");
        System.out.println(" ");
        System.out.println("\u001B[0m");

        System.out.println("\033[1;92m"+"Employee name: " + "\033[4;37m" + employeeName);
        System.out.println("\u001B[0m");
        System.out.println("\033[1;93m" + "Employee ID: " + "\033[4;37m" + employeeId);
        System.out.println("\u001B[0m");
        System.out.println( "\033[1;91m"+"Basic salary: Rs." + String.format("\033[4;37m" + "%.2f", basicSalary));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"DA: Rs." + String.format("\033[4;37m" + "%.2f", da));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"HRA: Rs." + String.format("\033[4;37m" + "%.2f", hra));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"Allowance: Rs." + String.format("\033[4;37m" + "%.2f", allowance));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"Gross salary: Rs." + String.format("\033[4;37m" + "%.2f", grossSalary));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"PF: Rs." + String.format("\033[4;37m" + "%.2f", pf));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"Tax: Rs." + String.format("\033[4;37m" + "%.2f", tax));
        System.out.println("\u001B[0m");
        System.out.println("\033[1;94m"+"Net salary: Rs." + String.format("\033[4;37m" + "%.2f", netSalary));
        System.out.println("\u001B[0m");
    }
}