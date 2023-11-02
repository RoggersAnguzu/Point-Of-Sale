# Point-Of-Sale
This is a Point of Sale that does not allow more that 4 items to be purchased
## Overview
This is a simple command-line-based point of sale system for a shop. It allows customers to select items, enter quantities, and enforces a limit of four units per item. The program is designed for an unending queue of customers, allowing them to buy a variety of items.

## How to Use
Welcome Message: Upon running the program, you will be greeted with a welcome message.

Menu: The program will display a menu of available items in the shop, and you can select an option by entering the corresponding number (1-5).

Item Selection: After selecting an item, you will be prompted to enter the unit of the product you want to buy.

Quantity Entry: You can then enter the quantity of the products you anticipate buying. The program enforces a limit of four units per item.

Item Code: Next, you need to enter the code of the product you are purchasing.

Order Summary: The program will display a list of your order, including the number of units, quantities, and the item code. It will also thank you for your purchase.

Exit Option: You will have the option to exit the program or continue shopping for more items.

## Program Structure
The program is structured as follows:

Main: The entry point of the program, which initiates the shopping system.

Menu: Displays the item menu and handles user selection. It also provides the option to exit the program.

Choice: Collects information about the item, including the unit, quantity, and code. It enforces the limit of four units per item.

Exit: Gives the user the choice to exit the program or return to the main menu.

## Requirements
The program is written in C# and can be executed in a C# development environment.
Improvements
The program enforces the purchase limit and allows customers to buy a variety of items, but it does not include specific item codes or prices. To make it more practical, you can define a list of items with unique codes and associated prices.

Error handling and user input validation can be enhanced to provide more user-friendly messages and prevent incorrect inputs.

The program can be further improved by calculating and displaying the total cost of the items the customer has selected.

Consider adding options for the customer to continue shopping or finalize their order.

## Conclusion
This program is a simple and functional point of sale system for a shop. While it addresses the basic requirements, it can be extended and enhanced to meet more advanced needs and user expectations.
