import java.util.Scanner;
import java.util.InputMismatchException;

public class LibraryManagementSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] books = new String[20]; 
        int bookCount = 0; 

        System.out.println("Welcome to the Library Management System!");

        while (true) {
            System.out.println("\nMenu:");
            System.out.println("1. Add a book");
            System.out.println("2. List all books");
            System.out.println("3. Issue a book");
            System.out.println("4. Return a book");
            System.out.println("5. Exit");

            System.out.print("\nEnter your choice (1-5): ");
            
            try {
                int choice = scanner.nextInt();
                scanner.nextLine(); 

                switch (choice) {
                    case 1:
                        if (bookCount < 20) { 
                            System.out.print("Enter the title of the book: ");
                            String title = scanner.nextLine();
                            books[bookCount] = title;
                            bookCount++;
                            System.out.println("Book added successfully.");
                        } else {
                            System.out.println("The library is full, no more books can be added.");
                        }
                        break;
                    case 2:
                        System.out.println("\nList of books:");
                        for (int i = 0; i < bookCount; i++) {
                            System.out.println(i + 1 + ". " + books[i]);
                        }
                        break;
                    case 3:
                    if (bookCount == 0)
                    {
                       System.out.println("No books available to issue.");
                   } else 
                   {
                       System.out.print("Enter the title of the book to be issued: ");
                       String issueTitle = scanner.nextLine();
                       boolean bookFound = false;
                       for (int i = 0; i < bookCount; i++) 
                       {
                           if (books[i].equals(issueTitle))
                            {
                               bookFound = true;
                               System.out.println("Book issued successfully.");
                               books[i] = null;
                               bookCount--;
                               break;
                           }
                       }
                       if (!bookFound) 
                       {
                           System.out.println("Sorry, this book is not available in our library.");
                       }
                   }
                   break;
                        
                    case 4:
                    if (bookCount == 10) 
                    {
                        System.out.println("No books have been issued yet.");
                    } else {
                        System.out.print("Enter the title of the book to be returned: ");
                        String returnTitle = scanner.nextLine();
                        if (bookCount < 10)
                         { 
                            books[bookCount] = returnTitle;
                            bookCount++;
                            System.out.println("Book returned successfully.");
                        } else {
                            System.out.println("Sorry, the library is full and no more books can be returned.");
                        }
                    }
            
                        break;
                    case 5:
                        // Exit
                        System.out.println("Thank you for using the Library Management System!");
                        System.exit(0);
                        break;
                    default:
                        System.out.println("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            } catch (InputMismatchException e) {
                System.out.println("Invalid input.");
                scanner.nextLine();
            }
        }
    }
}
