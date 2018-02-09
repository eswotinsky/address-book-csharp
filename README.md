# Address Book (C#)

A web app, built with C#, that allows users to create a digital "address book" of their contacts. This project was completed to satisfy the C# Week 1 Independent Code Review at [Epicodus](https://www.epicodus.com) in Seattle, WA.

## Installation

1. Install .NET, if not already present on your local machine.

2. Clone this repository.

3. In your preferred shell, navigate to the address-book folder and run the following commands:

 ```
 $ dotnet restore
 ```
(above not required for .NET Core 2.0 SDK or newer releases)

 ```
 $ dotnet run
 ```

4. Navigate to localhost:5000 in your preferred browser.

## Specifications

1. App routes users to the home page, which displays a list of contacts (initially empty), a button to add a new contact, and a button to delete all contacts.
    1. Example Input: User clicks "add a new contact".
    2. Example Output: User is routed to /contacts/add.

2. App allows users to create new contacts by filling out a form containing fields for a name, phone number, and street address. When submitted, this form updates the list of all contacts and routes users back to the home page, where the updated list is displayed.
    1. Example Input: User enters data for each field in the form and clicks "submit".
    2. Example Output: User is returned to the home page, where their new contact is now visible as the last entry on the total list of contacts.

3. App allows users to delete all contacts from the list by clicking a "Clear All Contacts" button located on the home page beneath the list of contacts.
    1. Example Input: User clicks "Clear All Contacts".
    2. Example Output: The stored list of contacts is cleared, and a view of the home page is returned with all previous contacts removed.

### Built With

* [Atom](https://atom.io/) - Open-source, hackable code editor running on the Electron framework.

### Support and Contact Details
If you encounter any bugs or would like to make suggestions regarding this project, please feel free to open an issue within the repository.

### License

This project is distributed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
