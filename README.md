# _Address Book_

#### _Address book that takes in user input that can easily be cleared (i.e. for short term project groups), saves it, and then shows the details of each contact, May 26, 2017_

#### By _Roger_

## Description

_This app will allow an user to input the name, address, city, state, zip code, and an image of a contact. Store it, and It will display the contact list in the home page. The user can click on the contact to bring up the contact's details. It will also allow the user to be able to delete these contacts with single button, making this for temporary teams. All of these will be individual HTML pages._

## Setup/Installation Requirements

* Go here: https://github.com/rogtobias?tab=repositories
* Select CS-Address-Book
* Click the Clone or Download button
* Save it to your machine
* In Windows PowerShell, go to CS-Address-Book root folder.
* In CS-Address-Book's root folder, input >dnx kestrel.

## Specs
* If the user doesn't select anything, nothing happens.
* If user selects "Clear All Contacts" button, it directs them to the /contacts/cleared page, displaying you cleared all of the contacts, and an "Add a new contact" link is under that. (ex. input:click"Clear All Contacts" => output:/contacts/cleared page)
* In the /contacts/cleared page, if the user selects "Add a new contact" link, it directs them to the main page again. (ex. input:click"Add a new contact" => output:main page)
* In the /contacts/new page, if the user selects the "Add Contact" button, without filling in all of the "Contact's Name:" through "Contact's Zip Code:", the user will get errors. (ex. input:click"Add Contact" => output:error)
* In the /contacts/new page, if the user fills in the "Contact's Name:" through "Contact's Zip Code:", and selects "Add Contact". The user will be redirected back to the main page and the user's contact will be displayed. (ex. input:click"Add Contact" w/ proper fields populated => output:main page)
* If a user can selects one of their contacts, it directs them to the /contacts/[] ([] being where they are in the list, ie 0 is 1, 1 is 2, etc.) (ex. input:click"(contact)" => output:/contacts/0 or 1 or 2 or 3 etc.)
* In the /contacts/0 or 1 or 2 or 3 etc. page, if the user selects "DELETE THIS CONTACT" button, it deletes that contact and redirects the user to the main page. (ex. input:click"DELETE THIS CONTACT" => output:main page w/ contact deleted)
* In the /contacts/0 or 1 or 2 or 3 etc. page, if the user selects "Back to homepage" link, it redirects the user back to the main page. (ex. input:click"Back to homepage" => output:main page)

## Known Bugs

_The empty contact name through zip codes throwing an error_

## Support and contact details

_Contact me at world@peace.com if you have any questions or concerns._

## Technologies Used

_HTML, Bootstrap, Nancy, C#_

### License

*This is licensed under MIT licensing.*

Copyright (c) 2016 **Roger**
