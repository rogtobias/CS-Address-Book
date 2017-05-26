using Nancy;
using System.Collections.Generic;
using AddressBookProject.Objects;

namespace AddressBookObject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml", Contact.GetAll()];
      Get["/contacts/new"] = _ => View["add_address_form.cshtml"];
      Post["/"] = _ => {
        Contact newContact = new Contact (Request.Form["name"],
                                          Request.Form["address"],
                                          Request.Form["city"],
                                          Request.Form["state"],
                                          Request.Form["zipCode"]);
        return View["index.cshtml", Contact.GetAll()];
      };
      Post["/contacts/cleared"] = _ => {
        Contact.ClearAll();
        return View["addresses_cleared.cshtml"];
      };
      Get["/contacts/{id}"] = parameters => {
        return View["address_details.cshtml", Contact.SearchContacts(parameters.id)];
      };
      Post["/contacts/{id}"] = parameters => {
        Contact contact = Contact.SearchContacts(parameters.id);
        contact.Remove();
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
    }
  }
}
